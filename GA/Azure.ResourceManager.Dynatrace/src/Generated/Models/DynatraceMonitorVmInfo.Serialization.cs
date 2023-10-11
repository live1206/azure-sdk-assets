// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorVmInfo
    {
        internal static DynatraceMonitorVmInfo DeserializeDynatraceMonitorVmInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> version = default;
            Optional<DynatraceOneAgentMonitoringType> monitoringType = default;
            Optional<DynatraceOneAgentAutoUpdateSetting> autoUpdateSetting = default;
            Optional<DynatraceOneAgentUpdateStatus> updateStatus = default;
            Optional<DynatraceOneAgentAvailabilityState> availabilityState = default;
            Optional<DynatraceLogModuleState> logModule = default;
            Optional<string> hostGroup = default;
            Optional<string> hostName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitoringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringType = new DynatraceOneAgentMonitoringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoUpdateSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpdateSetting = new DynatraceOneAgentAutoUpdateSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateStatus = new DynatraceOneAgentUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availabilityState = new DynatraceOneAgentAvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logModule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logModule = new DynatraceLogModuleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostGroup"u8))
                {
                    hostGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
            }
            return new DynatraceMonitorVmInfo(resourceId.Value, version.Value, Optional.ToNullable(monitoringType), Optional.ToNullable(autoUpdateSetting), Optional.ToNullable(updateStatus), Optional.ToNullable(availabilityState), Optional.ToNullable(logModule), hostGroup.Value, hostName.Value);
        }
    }
}