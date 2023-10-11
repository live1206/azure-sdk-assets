// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ServiceImpactingEvent
    {
        internal static ServiceImpactingEvent DeserializeServiceImpactingEvent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> eventStartTime = default;
            Optional<DateTimeOffset> eventStatusLastModifiedTime = default;
            Optional<string> correlationId = default;
            Optional<ServiceImpactingEventStatus> status = default;
            Optional<ServiceImpactingEventIncidentProperties> incidentProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eventStatusLastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventStatusLastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ServiceImpactingEventStatus.DeserializeServiceImpactingEventStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("incidentProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incidentProperties = ServiceImpactingEventIncidentProperties.DeserializeServiceImpactingEventIncidentProperties(property.Value);
                    continue;
                }
            }
            return new ServiceImpactingEvent(Optional.ToNullable(eventStartTime), Optional.ToNullable(eventStatusLastModifiedTime), correlationId.Value, status.Value, incidentProperties.Value);
        }
    }
}