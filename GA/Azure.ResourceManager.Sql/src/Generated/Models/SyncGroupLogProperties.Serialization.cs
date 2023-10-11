// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupLogProperties
    {
        internal static SyncGroupLogProperties DeserializeSyncGroupLogProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<SyncGroupLogType> type = default;
            Optional<string> source = default;
            Optional<string> details = default;
            Optional<Guid> tracingId = default;
            Optional<string> operationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SyncGroupLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tracingId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tracingId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("operationStatus"u8))
                {
                    operationStatus = property.Value.GetString();
                    continue;
                }
            }
            return new SyncGroupLogProperties(Optional.ToNullable(timestamp), Optional.ToNullable(type), source.Value, details.Value, Optional.ToNullable(tracingId), operationStatus.Value);
        }
    }
}