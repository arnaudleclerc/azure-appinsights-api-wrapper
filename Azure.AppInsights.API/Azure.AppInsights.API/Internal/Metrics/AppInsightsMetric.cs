﻿using Newtonsoft.Json;
using System;

namespace Azure.AppInsights.API.Internal.Metrics
{
    internal class AppInsightsMetric
    {
        [JsonProperty("value")]
        public AppInsightsMetricValue Value { get; set; }
    }

    internal class AppInsightsMetricValue
    {
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("end")]
        public DateTime End { get; set; }
    }
}
