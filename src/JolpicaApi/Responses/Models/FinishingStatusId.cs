namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Enum representing the finishing status of a race.
    /// </summary>
    public enum FinishingStatusId
    {
        /// <summary>
        /// Finished the race.
        /// </summary>
        Finished = 1,
        /// <summary>
        /// Disqualified from the race.
        /// </summary>
        Disqualified = 2,
        /// <summary>
        /// Accident during the race.
        /// </summary>
        Accident = 3,
        /// <summary>
        /// Collision during the race.
        /// </summary>
        Collision = 4,
        /// <summary>
        /// Engine failure.
        /// </summary>
        Engine = 5,
        /// <summary>
        /// Gearbox failure.
        /// </summary>
        Gearbox = 6,
        /// <summary>
        /// Transmission failure.
        /// </summary>
        Transmission = 7,
        /// <summary>
        /// Clutch failure.
        /// </summary>
        Clutch = 8,
        /// <summary>
        /// Hydraulics failure.
        /// </summary>
        Hydraulics = 9,
        /// <summary>
        /// Electrical failure.
        /// </summary>
        Electrical = 10,
        /// <summary>
        /// +1 Lap
        /// </summary>
        Laps1 = 11,
        /// <summary>
        /// +2 Laps
        /// </summary>
        Laps2 = 12,
        /// <summary>
        /// +3 Laps
        /// </summary>
        Laps3 = 13,
        /// <summary>
        /// +4 Laps
        /// </summary>
        Laps4 = 14,
        /// <summary>
        /// +5 Laps
        /// </summary>
        Laps5 = 15,
        /// <summary>
        /// +6 Laps
        /// </summary>
        Laps6 = 16,
        /// <summary>
        /// +7 Laps
        /// </summary>
        Laps7 = 17,
        /// <summary>
        /// +8 Laps
        /// </summary>
        Laps8 = 18,
        /// <summary>
        /// +9 Laps
        /// </summary>
        Laps9 = 19,
        /// <summary>
        /// Spun off the track.
        /// </summary>
        SpunOff = 20,
        /// <summary>
        /// Radiator failure.
        /// </summary>
        Radiator = 21,
        /// <summary>
        /// Suspension failure.
        /// </summary>
        Suspension = 22,
        /// <summary>
        /// Brakes failure.
        /// </summary>
        Brakes = 23,
        /// <summary>
        /// Differential failure.
        /// </summary>
        Differential = 24,
        /// <summary>
        /// Overheating.
        /// </summary>
        Overheating = 25,
        /// <summary>
        /// Mechanical failure.
        /// </summary>
        Mechanical = 26,
        /// <summary>
        /// Tyre failure.
        /// </summary>
        Tyre = 27,
        /// <summary>
        /// Driver seat issue.
        /// </summary>
        DriverSeat = 28,
        /// <summary>
        /// Puncture.
        /// </summary>
        Puncture = 29,
        /// <summary>
        /// Driveshaft failure.
        /// </summary>
        Driveshaft = 30,
        /// <summary>
        /// Retired from the race.
        /// </summary>
        Retired = 31,
        /// <summary>
        /// Fuel pressure issue.
        /// </summary>
        FuelPressure = 32,
        /// <summary>
        /// Front wing failure.
        /// </summary>
        FrontWing = 33,
        /// <summary>
        /// Water pressure issue.
        /// </summary>
        WaterPressure = 34,
        /// <summary>
        /// Refuelling issue.
        /// </summary>
        Refuelling = 35,
        /// <summary>
        /// Wheel failure.
        /// </summary>
        Wheel = 36,
        /// <summary>
        /// Throttle issue.
        /// </summary>
        Throttle = 37,
        /// <summary>
        /// Steering issue.
        /// </summary>
        Steering = 38,
        /// <summary>
        /// Technical issue.
        /// </summary>
        Technical = 39,
        /// <summary>
        /// Electronics failure.
        /// </summary>
        Electronics = 40,
        /// <summary>
        /// Broken wing.
        /// </summary>
        BrokenWing = 41,
        /// <summary>
        /// Heat shield fire.
        /// </summary>
        HeatShieldFire = 42,
        /// <summary>
        /// Exhaust failure.
        /// </summary>
        Exhaust = 43,
        /// <summary>
        /// Oil leak.
        /// </summary>
        OilLeak = 44,
        /// <summary>
        /// +11 Laps
        /// </summary>
        Laps11 = 45,
        /// <summary>
        /// Wheel rim failure.
        /// </summary>
        WheelRim = 46,
        /// <summary>
        /// Water leak.
        /// </summary>
        WaterLeak = 47,
        /// <summary>
        /// Fuel pump failure.
        /// </summary>
        FuelPump = 48,
        /// <summary>
        /// Track rod failure.
        /// </summary>
        TrackRod = 49,
        /// <summary>
        /// +17 Laps
        /// </summary>
        Laps17 = 50,
        /// <summary>
        /// Oil pressure issue.
        /// </summary>
        OilPressure = 51,
        /// <summary>
        /// +13 Laps
        /// </summary>
        Laps13 = 53,
        /// <summary>
        /// Withdrew from the race.
        /// </summary>
        Withdrew = 54,
        /// <summary>
        /// +12 Laps
        /// </summary>
        Laps12 = 55,
        /// <summary>
        /// Engine fire.
        /// </summary>
        EngineFire = 56,
        /// <summary>
        /// +26 Laps
        /// </summary>
        Laps26 = 58,
        /// <summary>
        /// Tyre puncture.
        /// </summary>
        TyrePuncture = 59,
        /// <summary>
        /// Out of fuel.
        /// </summary>
        OutOfFuel = 60,
        /// <summary>
        /// Wheel nut issue.
        /// </summary>
        WheelNut = 61,
        /// <summary>
        /// Not classified.
        /// </summary>
        NotClassified = 62,
        /// <summary>
        /// Pneumatics issue.
        /// </summary>
        Pneumatics = 63,
        /// <summary>
        /// Handling issue.
        /// </summary>
        Handling = 64,
        /// <summary>
        /// Rear wing failure.
        /// </summary>
        RearWing = 65,
        /// <summary>
        /// Fire.
        /// </summary>
        Fire = 66,
        /// <summary>
        /// Wheel bearing failure.
        /// </summary>
        WheelBearing = 67,
        /// <summary>
        /// Physical issue.
        /// </summary>
        Physical = 68,
        /// <summary>
        /// Fuel system issue.
        /// </summary>
        FuelSystem = 69,
        /// <summary>
        /// Oil line issue.
        /// </summary>
        OilLine = 70,
        /// <summary>
        /// Fuel rig issue.
        /// </summary>
        FuelRig = 71,
        /// <summary>
        /// Launch control issue.
        /// </summary>
        LaunchControl = 72,
        /// <summary>
        /// Injured.
        /// </summary>
        Injured = 73,
        /// <summary>
        /// Fuel issue.
        /// </summary>
        Fuel = 74,
        /// <summary>
        /// Power loss.
        /// </summary>
        PowerLoss = 75,
        /// <summary>
        /// Vibrations.
        /// </summary>
        Vibrations = 76,
        /// <summary>
        /// Rule 107% violation.
        /// </summary>
        Rule107Percent = 77,
        /// <summary>
        /// Safety issue.
        /// </summary>
        Safety = 78,
        /// <summary>
        /// Drivetrain failure.
        /// </summary>
        Drivetrain = 79,
        /// <summary>
        /// Ignition issue.
        /// </summary>
        Ignition = 80,
        /// <summary>
        /// Did not qualify.
        /// </summary>
        DidNotQualify = 81,
        /// <summary>
        /// Injury.
        /// </summary>
        Injury = 82,
        /// <summary>
        /// Chassis issue.
        /// </summary>
        Chassis = 83,
        /// <summary>
        /// Battery failure.
        /// </summary>
        Battery = 84,
        /// <summary>
        /// Stalled.
        /// </summary>
        Stalled = 85,
        /// <summary>
        /// Halfshaft failure.
        /// </summary>
        Halfshaft = 86,
        /// <summary>
        /// Crankshaft failure.
        /// </summary>
        Crankshaft = 87,
        /// <summary>
        /// +10 Laps
        /// </summary>
        Laps10 = 88,
        /// <summary>
        /// Safety concerns.
        /// </summary>
        SafetyConcerns = 89,
        /// <summary>
        /// Not restarted.
        /// </summary>
        NotRestarted = 90,
        /// <summary>
        /// Alternator failure.
        /// </summary>
        Alternator = 91,
        /// <summary>
        /// Underweight.
        /// </summary>
        Underweight = 92,
        /// <summary>
        /// Safety belt issue.
        /// </summary>
        SafetyBelt = 93,
        /// <summary>
        /// Oil pump failure.
        /// </summary>
        OilPump = 94,
        /// <summary>
        /// Fuel leak.
        /// </summary>
        FuelLeak = 95,
        /// <summary>
        /// Excluded from the race.
        /// </summary>
        Excluded = 96,
        /// <summary>
        /// Did not prequalify.
        /// </summary>
        DidNotPrequalify = 97,
        /// <summary>
        /// Injection issue.
        /// </summary>
        Injection = 98,
        /// <summary>
        /// Distributor issue.
        /// </summary>
        Distributor = 99,
        /// <summary>
        /// Driver unwell.
        /// </summary>
        DriverUnwell = 100,
        /// <summary>
        /// Turbo failure.
        /// </summary>
        Turbo = 101,
        /// <summary>
        /// CV joint failure.
        /// </summary>
        CVJoint = 102,
        /// <summary>
        /// Water pump failure.
        /// </summary>
        WaterPump = 103,
        /// <summary>
        /// Fatal accident.
        /// </summary>
        FatalAccident = 104,
        /// <summary>
        /// Spark plugs issue.
        /// </summary>
        SparkPlugs = 105,
        /// <summary>
        /// Fuel pipe issue.
        /// </summary>
        FuelPipe = 106,
        /// <summary>
        /// Eye injury.
        /// </summary>
        EyeInjury = 107,
        /// <summary>
        /// Oil pipe issue.
        /// </summary>
        OilPipe = 108,
        /// <summary>
        /// Axle failure.
        /// </summary>
        Axle = 109,
        /// <summary>
        /// Water pipe issue.
        /// </summary>
        WaterPipe = 110,
        /// <summary>
        /// +14 Laps
        /// </summary>
        Laps14 = 111,
        /// <summary>
        /// +15 Laps
        /// </summary>
        Laps15 = 112,
        /// <summary>
        /// +25 Laps
        /// </summary>
        Laps25 = 113,
        /// <summary>
        /// +18 Laps
        /// </summary>
        Laps18 = 114,
        /// <summary>
        /// +22 Laps
        /// </summary>
        Laps22 = 115,
        /// <summary>
        /// +16 Laps
        /// </summary>
        Laps16 = 116,
        /// <summary>
        /// +24 Laps
        /// </summary>
        Laps24 = 117,
        /// <summary>
        /// +29 Laps
        /// </summary>
        Laps29 = 118,
        /// <summary>
        /// +23 Laps
        /// </summary>
        Laps23 = 119,
        /// <summary>
        /// +21 Laps
        /// </summary>
        Laps21 = 120,
        /// <summary>
        /// Magneto issue.
        /// </summary>
        Magneto = 121,
        /// <summary>
        /// +44 Laps
        /// </summary>
        Laps44 = 122,
        /// <summary>
        /// +30 Laps
        /// </summary>
        Laps30 = 123,
        /// <summary>
        /// +19 Laps
        /// </summary>
        Laps19 = 124,
        /// <summary>
        /// +46 Laps
        /// </summary>
        Laps46 = 125,
        /// <summary>
        /// Supercharger failure.
        /// </summary>
        Supercharger = 126,
        /// <summary>
        /// +20 Laps
        /// </summary>
        Laps20 = 127,
        /// <summary>
        /// +42 Laps
        /// </summary>
        Laps42 = 128,
        /// <summary>
        /// Engine misfire.
        /// </summary>
        EngineMisfire = 129,
        /// <summary>
        /// Collision damage.
        /// </summary>
        CollisionDamage = 130,
        /// <summary>
        /// Power unit issue.
        /// </summary>
        PowerUnit = 131,
        /// <summary>
        /// ERS issue.
        /// </summary>
        ERS = 132,
        /// <summary>
        /// Brake duct issue.
        /// </summary>
        BrakeDuct = 135
    }
}