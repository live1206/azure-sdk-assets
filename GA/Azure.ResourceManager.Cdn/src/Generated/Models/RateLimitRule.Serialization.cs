// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RateLimitRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rateLimitThreshold"u8);
            writer.WriteNumberValue(RateLimitThreshold);
            writer.WritePropertyName("rateLimitDurationInMinutes"u8);
            writer.WriteNumberValue(RateLimitDurationInMinutes);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("matchConditions"u8);
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }

        internal static RateLimitRule DeserializeRateLimitRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rateLimitThreshold = default;
            int rateLimitDurationInMinutes = default;
            string name = default;
            Optional<CustomRuleEnabledState> enabledState = default;
            int priority = default;
            IList<CustomRuleMatchCondition> matchConditions = default;
            OverrideActionType action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rateLimitThreshold"u8))
                {
                    rateLimitThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rateLimitDurationInMinutes"u8))
                {
                    rateLimitDurationInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabledState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledState = new CustomRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    List<CustomRuleMatchCondition> array = new List<CustomRuleMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomRuleMatchCondition.DeserializeCustomRuleMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new OverrideActionType(property.Value.GetString());
                    continue;
                }
            }
            return new RateLimitRule(name, Optional.ToNullable(enabledState), priority, matchConditions, action, rateLimitThreshold, rateLimitDurationInMinutes);
        }
    }
}