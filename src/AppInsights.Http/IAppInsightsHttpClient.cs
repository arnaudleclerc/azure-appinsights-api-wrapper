﻿namespace AppInsights.Http
{
    using System.Threading.Tasks;
    using AppInsights.Http.Analytics;
    using AppInsights.Http.Metadata;
    using AppInsights.Http.Metrics;
    
    /// <summary>
    /// Exposes methods to call the application insights API
    /// </summary>
    public interface IAppInsightsHttpClient
    {
        /// <summary>
        /// Fetch metrics from the application insights API according to the given definition
        /// </summary>
        /// <param name="metrics">Type of metrics to retrieve</param>
        /// <returns>Metrics retrieved from application insights.</returns>
        Task<IMetric> GetMetricAsync(MetricsDefinition metrics);
        /// <summary>
        /// Fetch metrics from the application insights API according to the given definition
        /// </summary>
        /// <param name="metrics">Type of metrics to retrieve</param>
        /// <param name="id">ID of the application to get the metrics from</param>
        /// <returns>Metrics retrieved from application insights.</returns>
        Task<IMetric> GetMetricAsync(MetricsDefinition metrics, string id);
        /// <summary>
        /// Fetch the metadata from the application insights API
        /// </summary>
        /// <returns>Metadata retrieved from application insights.</returns>
        Task<IMetadata> GetMetadataAsync();
        /// <summary>
        /// Fetch the metadata from the application insights API
        /// </summary>
        /// <param name="id">ID of the application to fetch the metadata from</param>
        /// <returns>Metadata retrieved from application insights.</returns>
        Task<IMetadata> GetMetadataAsync(string id);
        /// <summary>
        /// Executes an analytics query
        /// </summary>
        /// <param name="analyticsQueryBuilder">Query to execute</param>
        /// <returns>Result of the query</returns>
        Task<IAnalyticQueryResult> QueryAsync(IAnalyticsQueryBuilder analyticsQueryBuilder);
        /// <summary>
        /// Executes an analytics query
        /// </summary>
        /// <param name="analyticsQueryBuilder">Query to execute</param>
        /// <param name="id">ID of the application on which the query will be executed</param>
        /// <returns>Result of the query</returns>
        Task<IAnalyticQueryResult> QueryAsync(IAnalyticsQueryBuilder analyticsQueryBuilder, string id);
        /// <summary>
        /// Executes an analytics query
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <returns>Result of the query</returns>
        Task<IAnalyticQueryResult> QueryAsync(string query);
        /// <summary>
        /// Executes an analytics query
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="id">ID of the application on which the query will be executed</param>
        /// <returns>Result of the query</returns>
        Task<IAnalyticQueryResult> QueryAsync(string query, string id);
    }
}
