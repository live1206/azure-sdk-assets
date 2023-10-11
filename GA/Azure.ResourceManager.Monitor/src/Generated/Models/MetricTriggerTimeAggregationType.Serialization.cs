// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    internal static partial class MetricTriggerTimeAggregationTypeExtensions
    {
        public static string ToSerialString(this MetricTriggerTimeAggregationType value) => value switch
        {
            MetricTriggerTimeAggregationType.Average => "Average",
            MetricTriggerTimeAggregationType.Minimum => "Minimum",
            MetricTriggerTimeAggregationType.Maximum => "Maximum",
            MetricTriggerTimeAggregationType.Total => "Total",
            MetricTriggerTimeAggregationType.Count => "Count",
            MetricTriggerTimeAggregationType.Last => "Last",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricTriggerTimeAggregationType value.")
        };

        public static MetricTriggerTimeAggregationType ToMetricTriggerTimeAggregationType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Average")) return MetricTriggerTimeAggregationType.Average;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Minimum")) return MetricTriggerTimeAggregationType.Minimum;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Maximum")) return MetricTriggerTimeAggregationType.Maximum;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Total")) return MetricTriggerTimeAggregationType.Total;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Count")) return MetricTriggerTimeAggregationType.Count;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Last")) return MetricTriggerTimeAggregationType.Last;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricTriggerTimeAggregationType value.");
        }
    }
}