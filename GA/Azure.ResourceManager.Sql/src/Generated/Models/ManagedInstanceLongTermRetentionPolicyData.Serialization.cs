// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceLongTermRetentionPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WeeklyRetention))
            {
                writer.WritePropertyName("weeklyRetention"u8);
                writer.WriteStringValue(WeeklyRetention);
            }
            if (Optional.IsDefined(MonthlyRetention))
            {
                writer.WritePropertyName("monthlyRetention"u8);
                writer.WriteStringValue(MonthlyRetention);
            }
            if (Optional.IsDefined(YearlyRetention))
            {
                writer.WritePropertyName("yearlyRetention"u8);
                writer.WriteStringValue(YearlyRetention);
            }
            if (Optional.IsDefined(WeekOfYear))
            {
                writer.WritePropertyName("weekOfYear"u8);
                writer.WriteNumberValue(WeekOfYear.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedInstanceLongTermRetentionPolicyData DeserializeManagedInstanceLongTermRetentionPolicyData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> weeklyRetention = default;
            Optional<string> monthlyRetention = default;
            Optional<string> yearlyRetention = default;
            Optional<int> weekOfYear = default;
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
                        if (property0.NameEquals("weeklyRetention"u8))
                        {
                            weeklyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("monthlyRetention"u8))
                        {
                            monthlyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("yearlyRetention"u8))
                        {
                            yearlyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weekOfYear"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weekOfYear = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedInstanceLongTermRetentionPolicyData(id, name, type, systemData.Value, weeklyRetention.Value, monthlyRetention.Value, yearlyRetention.Value, Optional.ToNullable(weekOfYear));
        }
    }
}