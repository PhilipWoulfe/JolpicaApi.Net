﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models.RaceInfo
{
    public class SprintWithResults : Race
    {
        [JsonProperty(nameof(SprintResults))]
        public IList<RaceResult> SprintResults { get; private set; }
    }
}
