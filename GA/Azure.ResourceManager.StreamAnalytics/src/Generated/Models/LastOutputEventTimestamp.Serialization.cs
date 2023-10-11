// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class LastOutputEventTimestamp
    {
        internal static LastOutputEventTimestamp DeserializeLastOutputEventTimestamp(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastOutputEventTime = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastOutputEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastOutputEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new LastOutputEventTimestamp(Optional.ToNullable(lastOutputEventTime), Optional.ToNullable(lastUpdateTime));
        }
    }
}