// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    public partial class NewRelicObservabilityTagRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LogRules))
            {
                writer.WritePropertyName("logRules"u8);
                writer.WriteObjectValue(LogRules);
            }
            if (Optional.IsDefined(MetricRules))
            {
                writer.WritePropertyName("metricRules"u8);
                writer.WriteObjectValue(MetricRules);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NewRelicObservabilityTagRuleData DeserializeNewRelicObservabilityTagRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NewRelicProvisioningState> provisioningState = default;
            Optional<NewRelicObservabilityLogRules> logRules = default;
            Optional<NewRelicObservabilityMetricRules> metricRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NewRelicProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("logRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logRules = NewRelicObservabilityLogRules.DeserializeNewRelicObservabilityLogRules(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("metricRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metricRules = NewRelicObservabilityMetricRules.DeserializeNewRelicObservabilityMetricRules(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NewRelicObservabilityTagRuleData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), logRules.Value, metricRules.Value);
        }
    }
}