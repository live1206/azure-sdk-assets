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
    public partial class MetricAlertStatusProperties
    {
        internal static MetricAlertStatusProperties DeserializeMetricAlertStatusProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> dimensions = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> timestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensions"u8))
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
                    dimensions = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MetricAlertStatusProperties(Optional.ToDictionary(dimensions), status.Value, Optional.ToNullable(timestamp));
        }
    }
}
