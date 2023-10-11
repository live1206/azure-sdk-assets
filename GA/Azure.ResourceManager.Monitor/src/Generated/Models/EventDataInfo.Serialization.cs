// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class EventDataInfo
    {
        internal static EventDataInfo DeserializeEventDataInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SenderAuthorization> authorization = default;
            Optional<IReadOnlyDictionary<string, string>> claims = default;
            Optional<string> caller = default;
            Optional<string> description = default;
            Optional<string> id = default;
            Optional<string> eventDataId = default;
            Optional<string> correlationId = default;
            Optional<MonitorLocalizableString> eventName = default;
            Optional<MonitorLocalizableString> category = default;
            Optional<EventDataHttpRequestInfo> httpRequest = default;
            Optional<MonitorEventLevel> level = default;
            Optional<string> resourceGroupName = default;
            Optional<MonitorLocalizableString> resourceProviderName = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<MonitorLocalizableString> resourceType = default;
            Optional<string> operationId = default;
            Optional<MonitorLocalizableString> operationName = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            Optional<MonitorLocalizableString> status = default;
            Optional<MonitorLocalizableString> subStatus = default;
            Optional<DateTimeOffset> eventTimestamp = default;
            Optional<DateTimeOffset> submissionTimestamp = default;
            Optional<string> subscriptionId = default;
            Optional<Guid> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorization = SenderAuthorization.DeserializeSenderAuthorization(property.Value);
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    claims = dictionary;
                    continue;
                }
                if (property.NameEquals("caller"u8))
                {
                    caller = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventDataId"u8))
                {
                    eventDataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventName = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("httpRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRequest = EventDataHttpRequestInfo.DeserializeEventDataHttpRequestInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = property.Value.GetString().ToMonitorEventLevel();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProviderName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceProviderName = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationName = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("subStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subStatus = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("submissionTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submissionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
            }
            return new EventDataInfo(authorization.Value, Optional.ToDictionary(claims), caller.Value, description.Value, id.Value, eventDataId.Value, correlationId.Value, eventName.Value, category.Value, httpRequest.Value, Optional.ToNullable(level), resourceGroupName.Value, resourceProviderName.Value, resourceId.Value, resourceType.Value, operationId.Value, operationName.Value, Optional.ToDictionary(properties), status.Value, subStatus.Value, Optional.ToNullable(eventTimestamp), Optional.ToNullable(submissionTimestamp), subscriptionId.Value, Optional.ToNullable(tenantId));
        }
    }
}