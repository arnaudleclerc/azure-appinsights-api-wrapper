﻿namespace AppInsights.Http.Analytics
{
    public interface IAnalyticsQueryBuilder
    {
        AnalyticsSchema Schema { get; }

        IAnalyticsQueryBuilder WithFilter(string filterName, AnalyticFilterOperator filterOperator, string value);
        IAnalyticsQueryBuilder WithFilter(string filterName, AnalyticFilterOperator filterOperator, params string[] value);
        IAnalyticsQueryBuilder WithTimestampFilter(AnalyticFilterOperator filterOperator, AnalyticTimestampFilterOperator timestampFilterOperator, AnalyticTimestampDuration duration);
        IAnalyticsQueryBuilder WithTimestampFilter(AnalyticFilterOperator filterOperator, AnalyticTimestampFilterOperator timestampFilterOperator, string duration);
        IAnalyticsQueryBuilder WithSummarizeCount(params string[] fields);
        IAnalyticsQueryBuilder WithProject(params string[] fields);
    }
}
