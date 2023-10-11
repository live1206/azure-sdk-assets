// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class SoftwareUpdateConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("updateConfiguration"u8);
            writer.WriteObjectValue(UpdateConfiguration);
            writer.WritePropertyName("scheduleInfo"u8);
            writer.WriteObjectValue(ScheduleInfo);
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(Tasks))
            {
                writer.WritePropertyName("tasks"u8);
                writer.WriteObjectValue(Tasks);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SoftwareUpdateConfigurationData DeserializeSoftwareUpdateConfigurationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            SoftwareUpdateConfigurationSpecificProperties updateConfiguration = default;
            SoftwareUpdateConfigurationScheduleProperties scheduleInfo = default;
            Optional<string> provisioningState = default;
            Optional<AutomationResponseError> error = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> createdBy = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> lastModifiedBy = default;
            Optional<SoftwareUpdateConfigurationTasks> tasks = default;
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
                        if (property0.NameEquals("updateConfiguration"u8))
                        {
                            updateConfiguration = SoftwareUpdateConfigurationSpecificProperties.DeserializeSoftwareUpdateConfigurationSpecificProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scheduleInfo"u8))
                        {
                            scheduleInfo = SoftwareUpdateConfigurationScheduleProperties.DeserializeSoftwareUpdateConfigurationScheduleProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = AutomationResponseError.DeserializeAutomationResponseError(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            createdBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tasks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tasks = SoftwareUpdateConfigurationTasks.DeserializeSoftwareUpdateConfigurationTasks(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SoftwareUpdateConfigurationData(id, name, type, systemData.Value, updateConfiguration, scheduleInfo, provisioningState.Value, error.Value, Optional.ToNullable(creationTime), createdBy.Value, Optional.ToNullable(lastModifiedTime), lastModifiedBy.Value, tasks.Value);
        }
    }
}