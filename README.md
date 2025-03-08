# Jolpica Developer API .NET Client

[![license](https://img.shields.io/badge/license-Unlicense-blue.svg)](https://github.com/PhilipWoulfe/JolpicaApi.Net/blob/master/LICENSE.md)
[![Build](https://github.com/PhilipWoulfe/JolpicaApi.Net/actions/workflows/ci.yml/badge.svg)](https://github.com/PhilipWoulfe/JolpicaApi.Net/actions/workflows/ci.yml)

## Credit

This is a fork of the [ErgastApi.Net](https://github.com/Krusen/ErgastApi.Net) nuget package by Søren Kruse. 

The only changes I have made are updating the .NET framework to 8.0, changing the API url to a configurable appsetting and updating the list of drivers, constructors and race venues.

I also changed most of the references to Ergast to Jolpica, which was probably a mistake. Oh well.

## Information

This a C# library wrapping the Jolpica Developer API (https://github.com/jolpica/jolpica-f1, https://api.jolpi.ca/ergast/f1/).

The library makes it easy to explore and use the API and also takes care of caching the responses to minimize the load on API server.

The Jolpica Developer API is an experimental web service which provides access a historical record of motor racing data for non-commercial purposes.
Please read the [documentation](https://github.com/jolpica/jolpica-f1/blob/main/docs/README.md).

The API provides data for the Formula One series, from the beginning of the world championships in 1950.

Non-programmers can query the database using the [manual interface](https://api.jolpi.ca/ergast/).

## Installation


Install the package **JolpicaApiClient** from [NuGet](https://www.nuget.org/packages/JolpicaApiClient/) 
or install it from the [Package Manager Console](https://docs.microsoft.com/da-dk/nuget/tools/package-manager-console):

```
PM> Install-Package JolpicaApiClient
```


## Usage

The library is easy to use.

Start by creating an `JolpicaClient`. Then create one of the request types and set parameters to narrow down your query.
Then execute the request throughe the client with the `GetResponseAsync(IJolpicaRequest)` method.

Below is an example of how to get the race results of the 11th race of the 2017 season.

```C#
// Relevant imports
using JolpicaApi.Client;
using JolpicaApi.Ids;
using JolpicaApi.Requests;

// The client should be stored and reused during the lifetime of your application
var client = new JolpicaClient();

// All request properties are optional (except 'Season' if 'Round' is set)
var request = new RaceResultsRequest
{
    Season = "2017",     // or Seasons.Current for current season
    Round = "11",        // or Rounds.Last or Rounds.Next for last or next round
    DriverId = "vettel", // or Drivers.SebastianVettel

    Limit = 30      // Limit the number of results returned
    Offset = 0      // Result offset (used for paging)
};

// RaceResultsRequest returns a RaceResultsResponse
// Other requests returns other response types
RaceResultsResponse response = await client.GetResponseAsync(request);
```

The following request types are available:

- Race & Results
  - `CircuitInfoRequest`
  - `ConstructorInfoRequest` 
  - `DriverInfoRequest`
  - `FinishingStatusRequest`
  - `QualifyingResultsRequest`
  - `RaceListRequest`
  - `RaceResultsRequest`
  - `SeasonListRequest`
- Standings
  - `ConstructorStandingsRequest`
  - `DriverStandingsRequest`
- Lap Times & Pit Stops
  - `LapTimesRequest`
  - `PitStopsRequest`

Here are some other examples:

```C#
// List of seasons where Alonso won the WDC and Ferrari got second in the WCC
new SeasonListRequest
{
    DriverId = Drivers.FernandoAlonso,
    DriverStanding = 1,

    ConstructorId = Constructors.Ferrari,
    ConstructorStanding = 2
}

// List of races where Raikkonen retired because
// of engine problems while racing for Ferrari
new RaceListRequest
{
    DriverId = Drivers.KimiRaikkonen,
    ConstructorId = Constructors.Ferrari,
    FinishingStatus = FinishingStatusId.Engine
}

// Qualifying results from last round
new QualifyingResultsRequest
{
    Season = Seasons.Current,
    Round = Rounds.Last
}

// Driver standings after race 3 in 2017
new DriverStandingsRequest
{ 
    Season = "2017", 
    Round = "3"
}

// List of circuits where Hamilton got pole, won the race
// and set fastest lap time while racing for McLaren
new CircuitInfoRequest
{
    DriverId = Drivers.LewisHamilton,
    ConstructorId = Constructors.McLaren,
    QualifyingPosition = 1,
    FinishingPosition = 1,
    FastestLapRank = 1
}

// Drivers who have won the race at Baku
new DriverInfoRequest
{
    CircuitId = Circuits.Baku,
    FinishingPosition = 1
}
```

### Driver, constructor and circuit IDs

Most current IDs are stored as constants in the `Drivers`, `Constructors` and `Circuits` static classes.

```C#
Drivers.SebastianVettel // "vettel"
Constructors.Ferrari    // "ferrari"
Circuits.Monza          // "monza"
```

If the ID you are looking for is not listed there, then you will have to query the API with either
a `DriverInfoRequest`, `ConstructorInfoRequest` or `CircuitInfoRequest`.

Here is how you could find the ID of Fernando Alonso:

```C#
// Get drivers in current season (leave out season to get a list of all drivers ever (requires paging))
var request = new DriverInfoRequest { Limit = 1000 }
var response = await client.GetResponseAsync(request);

response.Drivers.Single(x => x.FullName == "Fernando Alonso").DriverId;
```


### Paging

Some responses will have a lot of results. Every request type has two properties used for paging - `Limit` and `Offset`.

The `Limit` property allows you to limit the number of returned results.
The maximum value is 1000 but please use the smallest value that you can. If not set it defaults to 30.

The `Offset` property specifies an offset into the result set (i.e. start from this position).
If not set it defaults to zero.

The response object returned from `JolpicaClient.GetResponseAsync()` contains the following information to help you with paging:

- `Limit` and `Offset` (the values used for the response)
- `TotalResults`
- `Page`
- `TotalPages`
- `HasMorePages`


### Caching

`JolpicaClient` caches the response for all requests to minimize the load on the API server. Requests are cached by the resulting URL.

The default cache lifetime is one hour. You can change this by setting `client.Cache.CacheEntryLifetime` to a different `TimeSpan` value.

You can clear the cache by calling `client.Cache.Clear()`.


## TODOs

- Add helper methods for getting next/previous page
- Add more XML documentation for better intellisense
- Add more unit tests


