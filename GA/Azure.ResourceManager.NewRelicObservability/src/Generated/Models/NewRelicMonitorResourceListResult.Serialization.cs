// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NewRelicObservability;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    internal partial class NewRelicMonitorResourceListResult
    {
        internal static NewRelicMonitorResourceListResult DeserializeNewRelicMonitorResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NewRelicMonitorResourceData> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<NewRelicMonitorResourceData> array = new List<NewRelicMonitorResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicMonitorResourceData.DeserializeNewRelicMonitorResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new NewRelicMonitorResourceListResult(value, nextLink.Value);
        }
    }
}