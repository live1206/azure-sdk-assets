// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WorkloadMonitor.Models;

namespace Azure.ResourceManager.WorkloadMonitor
{
    public partial class HealthMonitorData
    {
        internal static HealthMonitorData DeserializeHealthMonitorData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> monitorName = default;
            Optional<string> monitorType = default;
            Optional<string> monitoredObject = default;
            Optional<string> parentMonitorName = default;
            Optional<HealthState> previousMonitorState = default;
            Optional<HealthState> currentMonitorState = default;
            Optional<string> evaluationTimestamp = default;
            Optional<string> currentStateFirstObservedTimestamp = default;
            Optional<string> lastReportedTimestamp = default;
            Optional<BinaryData> evidence = default;
            Optional<BinaryData> monitorConfiguration = default;
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
                        if (property0.NameEquals("monitorName"u8))
                        {
                            monitorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("monitorType"u8))
                        {
                            monitorType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("monitoredObject"u8))
                        {
                            monitoredObject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentMonitorName"u8))
                        {
                            parentMonitorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("previousMonitorState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            previousMonitorState = new HealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("currentMonitorState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentMonitorState = new HealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("evaluationTimestamp"u8))
                        {
                            evaluationTimestamp = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentStateFirstObservedTimestamp"u8))
                        {
                            currentStateFirstObservedTimestamp = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastReportedTimestamp"u8))
                        {
                            lastReportedTimestamp = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("evidence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            evidence = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("monitorConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitorConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HealthMonitorData(id, name, type, systemData.Value, monitorName.Value, monitorType.Value, monitoredObject.Value, parentMonitorName.Value, Optional.ToNullable(previousMonitorState), Optional.ToNullable(currentMonitorState), evaluationTimestamp.Value, currentStateFirstObservedTimestamp.Value, lastReportedTimestamp.Value, evidence.Value, monitorConfiguration.Value);
        }
    }
}