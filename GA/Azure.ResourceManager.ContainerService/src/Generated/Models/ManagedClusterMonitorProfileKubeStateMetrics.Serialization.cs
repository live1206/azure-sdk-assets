// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterMonitorProfileKubeStateMetrics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MetricLabelsAllowlist))
            {
                writer.WritePropertyName("metricLabelsAllowlist"u8);
                writer.WriteStringValue(MetricLabelsAllowlist);
            }
            if (Optional.IsDefined(MetricAnnotationsAllowList))
            {
                writer.WritePropertyName("metricAnnotationsAllowList"u8);
                writer.WriteStringValue(MetricAnnotationsAllowList);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterMonitorProfileKubeStateMetrics DeserializeManagedClusterMonitorProfileKubeStateMetrics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metricLabelsAllowlist = default;
            Optional<string> metricAnnotationsAllowList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricLabelsAllowlist"u8))
                {
                    metricLabelsAllowlist = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricAnnotationsAllowList"u8))
                {
                    metricAnnotationsAllowList = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedClusterMonitorProfileKubeStateMetrics(metricLabelsAllowlist.Value, metricAnnotationsAllowList.Value);
        }
    }
}