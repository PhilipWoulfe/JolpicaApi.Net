using System;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models
{
    /// <summary>
    /// Represents a driver in the Jolpi API.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Gets the unique identifier for the driver.
        /// </summary>
        [JsonProperty("driverId")]
        public string DriverId { get; private set; }

        /// <summary>
        /// Gets the permanent number of the driver.
        /// Drivers who participated in the 2014 season onwards have a permanent driver number.
        /// However, this may differ from the value of the number attribute of the Result element in earlier seasons
        /// or where the reigning champion has chosen to use "1" rather than his permanent driver number.
        /// </summary>
        [JsonProperty("permanentNumber")]
        public int? PermanentNumber { get; private set; }

        /// <summary>
        /// Gets the code of the driver.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the Wikipedia URL of the driver.
        /// </summary>
        [JsonProperty("url")]
        public string WikiUrl { get; private set; }

        /// <summary>
        /// Gets the full name of the driver.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// Gets the first name of the driver.
        /// </summary>
        [JsonProperty("givenName")]
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets the last name of the driver.
        /// </summary>
        [JsonProperty("familyName")]
        public string LastName { get; private set; }

        /// <summary>
        /// Gets the date of birth of the driver.
        /// </summary>
        [JsonProperty("dateOfBirth")]
        public DateTime? DateOfBirth { get; private set; }

        /// <summary>
        /// Gets the nationality of the driver.
        /// </summary>
        [JsonProperty("nationality")]
        public string Nationality { get; private set; }
    }
}