// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceUsage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceUsage DeserializeAppServiceUsage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> resourceName = default;
            Optional<string> unit = default;
            Optional<long> currentValue = default;
            Optional<long> limit = default;
            Optional<DateTimeOffset> nextResetTime = default;
            Optional<ComputeModeOption> computeMode = default;
            Optional<string> siteMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceName"u8))
                        {
                            resourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("unit"u8))
                        {
                            unit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentValue = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("limit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            limit = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("nextResetTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextResetTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("computeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeMode = property0.Value.GetString().ToComputeModeOption();
                            continue;
                        }
                        if (property0.NameEquals("siteMode"u8))
                        {
                            siteMode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceUsage(id, name, type, systemData.Value, displayName.Value, resourceName.Value, unit.Value, Optional.ToNullable(currentValue), Optional.ToNullable(limit), Optional.ToNullable(nextResetTime), Optional.ToNullable(computeMode), siteMode.Value, kind.Value);
        }
    }
}