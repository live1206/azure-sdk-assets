// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class AverageServiceLoadScalingTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            writer.WritePropertyName("lowerLoadThreshold"u8);
            writer.WriteNumberValue(LowerLoadThreshold);
            writer.WritePropertyName("upperLoadThreshold"u8);
            writer.WriteNumberValue(UpperLoadThreshold);
            writer.WritePropertyName("scaleInterval"u8);
            writer.WriteStringValue(ScaleInterval);
            writer.WritePropertyName("useOnlyPrimaryLoad"u8);
            writer.WriteBooleanValue(UseOnlyPrimaryLoad);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static AverageServiceLoadScalingTrigger DeserializeAverageServiceLoadScalingTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricName = default;
            double lowerLoadThreshold = default;
            double upperLoadThreshold = default;
            string scaleInterval = default;
            bool useOnlyPrimaryLoad = default;
            ServiceScalingTriggerKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lowerLoadThreshold"u8))
                {
                    lowerLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperLoadThreshold"u8))
                {
                    upperLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("scaleInterval"u8))
                {
                    scaleInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useOnlyPrimaryLoad"u8))
                {
                    useOnlyPrimaryLoad = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingTriggerKind(property.Value.GetString());
                    continue;
                }
            }
            return new AverageServiceLoadScalingTrigger(kind, metricName, lowerLoadThreshold, upperLoadThreshold, scaleInterval, useOnlyPrimaryLoad);
        }
    }
}
