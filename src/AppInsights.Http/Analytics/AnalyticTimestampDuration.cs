﻿namespace AppInsights.Http.Analytics
{
    public class AnalyticTimestampDuration
    {
        public static AnalyticTimestampDuration HalfHour = new AnalyticTimestampDuration("30m");
        public static AnalyticTimestampDuration Hour = new AnalyticTimestampDuration("1h");
        public static AnalyticTimestampDuration HalfDay = new AnalyticTimestampDuration("12h");
        public static AnalyticTimestampDuration Day = new AnalyticTimestampDuration("1d");
        public static AnalyticTimestampDuration ThreeDays = new AnalyticTimestampDuration("3d");
        public static AnalyticTimestampDuration Week = new AnalyticTimestampDuration("7d");

        public static AnalyticTimestampDuration MinusHalfHour = new AnalyticTimestampDuration("-30m");
        public static AnalyticTimestampDuration MinusHour = new AnalyticTimestampDuration("-1h");
        public static AnalyticTimestampDuration MinusHalfDay = new AnalyticTimestampDuration("-12h");
        public static AnalyticTimestampDuration MinusDay = new AnalyticTimestampDuration("-1d");
        public static AnalyticTimestampDuration MinusThreeDays = new AnalyticTimestampDuration("-3d");
        public static AnalyticTimestampDuration MinusWeek = new AnalyticTimestampDuration("-7d");

        private readonly string _duration;
        private AnalyticTimestampDuration(string duration) => _duration = duration;

        public override string ToString()
        {
            return _duration;
        }
    }
}
