// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AutoScaleConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(MinReplicas))
            {
                writer.WritePropertyName("minReplicas"u8);
                writer.WriteNumberValue(MinReplicas.Value);
            }
            if (Optional.IsDefined(MaxReplicas))
            {
                writer.WritePropertyName("maxReplicas"u8);
                writer.WriteNumberValue(MaxReplicas.Value);
            }
            if (Optional.IsDefined(TargetUtilization))
            {
                writer.WritePropertyName("targetUtilization"u8);
                writer.WriteNumberValue(TargetUtilization.Value);
            }
            if (Optional.IsDefined(RefreshPeriodInSeconds))
            {
                writer.WritePropertyName("refreshPeriodInSeconds"u8);
                writer.WriteNumberValue(RefreshPeriodInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static AutoScaleConfiguration DeserializeAutoScaleConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Status> status = default;
            Optional<int> minReplicas = default;
            Optional<int> maxReplicas = default;
            Optional<float> targetUtilization = default;
            Optional<int> refreshPeriodInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new Status(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetUtilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetUtilization = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("refreshPeriodInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshPeriodInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new AutoScaleConfiguration(Optional.ToNullable(status), Optional.ToNullable(minReplicas), Optional.ToNullable(maxReplicas), Optional.ToNullable(targetUtilization), Optional.ToNullable(refreshPeriodInSeconds));
        }
    }
}