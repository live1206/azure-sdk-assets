// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsPropertyConditionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConditionProperties))
            {
                writer.WritePropertyName("conditionProperties"u8);
                writer.WriteObjectValue(ConditionProperties);
            }
            writer.WritePropertyName("conditionType"u8);
            writer.WriteStringValue(ConditionType.ToString());
            writer.WriteEndObject();
        }

        internal static SecurityInsightsPropertyConditionProperties DeserializeSecurityInsightsPropertyConditionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRulePropertyValuesCondition> conditionProperties = default;
            ConditionType conditionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionProperties = AutomationRulePropertyValuesCondition.DeserializeAutomationRulePropertyValuesCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("conditionType"u8))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityInsightsPropertyConditionProperties(conditionType, conditionProperties.Value);
        }
    }
}