// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticMetricSample : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(RoleInstance))
            {
                writer.WritePropertyName("roleInstance"u8);
                writer.WriteStringValue(RoleInstance);
            }
            if (Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
            }
            if (Optional.IsDefined(Maximum))
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (Optional.IsDefined(Minimum))
            {
                writer.WritePropertyName("minimum"u8);
                writer.WriteNumberValue(Minimum.Value);
            }
            if (Optional.IsDefined(IsAggregated))
            {
                writer.WritePropertyName("isAggregated"u8);
                writer.WriteBooleanValue(IsAggregated.Value);
            }
            writer.WriteEndObject();
        }

        internal static DiagnosticMetricSample DeserializeDiagnosticMetricSample(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> roleInstance = default;
            Optional<double> total = default;
            Optional<double> maximum = default;
            Optional<double> minimum = default;
            Optional<bool> isAggregated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("roleInstance"u8))
                {
                    roleInstance = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isAggregated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAggregated = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DiagnosticMetricSample(Optional.ToNullable(timestamp), roleInstance.Value, Optional.ToNullable(total), Optional.ToNullable(maximum), Optional.ToNullable(minimum), Optional.ToNullable(isAggregated));
        }
    }
}
