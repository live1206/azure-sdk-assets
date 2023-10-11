// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class MonitoredResourceContent
    {
        internal static MonitoredResourceContent DeserializeMonitoredResourceContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<bool> sendingMetrics = default;
            Optional<string> reasonForMetricsStatus = default;
            Optional<bool> sendingLogs = default;
            Optional<string> reasonForLogsStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForMetricsStatus"u8))
                {
                    reasonForMetricsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForLogsStatus"u8))
                {
                    reasonForLogsStatus = property.Value.GetString();
                    continue;
                }
            }
            return new MonitoredResourceContent(id.Value, Optional.ToNullable(sendingMetrics), reasonForMetricsStatus.Value, Optional.ToNullable(sendingLogs), reasonForLogsStatus.Value);
        }
    }
}