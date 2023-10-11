// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ThrottlingMetric. </summary>
    public partial class ThrottlingMetric
    {
        /// <summary> Initializes a new instance of ThrottlingMetric. </summary>
        /// <param name="metricType"></param>
        /// <param name="limit"></param>
        public ThrottlingMetric(ThrottlingMetricType metricType, long limit)
        {
            MetricType = metricType;
            Limit = limit;
        }

        /// <summary> Initializes a new instance of ThrottlingMetric. </summary>
        /// <param name="metricType"></param>
        /// <param name="limit"></param>
        /// <param name="interval"></param>
        internal ThrottlingMetric(ThrottlingMetricType metricType, long limit, TimeSpan? interval)
        {
            MetricType = metricType;
            Limit = limit;
            Interval = interval;
        }

        /// <summary> Gets or sets the metric type. </summary>
        public ThrottlingMetricType MetricType { get; set; }
        /// <summary> Gets or sets the limit. </summary>
        public long Limit { get; set; }
        /// <summary> Gets or sets the interval. </summary>
        public TimeSpan? Interval { get; set; }
    }
}