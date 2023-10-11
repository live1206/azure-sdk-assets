// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class LogAnalyticsQueryPackQueryListResult
    {
        internal static LogAnalyticsQueryPackQueryListResult DeserializeLogAnalyticsQueryPackQueryListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LogAnalyticsQueryData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<LogAnalyticsQueryData> array = new List<LogAnalyticsQueryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogAnalyticsQueryData.DeserializeLogAnalyticsQueryData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalyticsQueryPackQueryListResult(value, nextLink.Value);
        }
    }
}
