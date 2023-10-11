// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafMetricsResponseSeriesItem
    {
        internal static WafMetricsResponseSeriesItem DeserializeWafMetricsResponseSeriesItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metric = default;
            Optional<WafMetricsResponseSeriesItemUnit> unit = default;
            Optional<IReadOnlyList<WafMetricsResponseSeriesPropertiesItemsItem>> groups = default;
            Optional<IReadOnlyList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new WafMetricsResponseSeriesItemUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        groups = null;
                        continue;
                    }
                    List<WafMetricsResponseSeriesPropertiesItemsItem> array = new List<WafMetricsResponseSeriesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WafMetricsResponseSeriesPropertiesItemsItem.DeserializeWafMetricsResponseSeriesPropertiesItemsItem(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> array = new List<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems.DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new WafMetricsResponseSeriesItem(metric.Value, Optional.ToNullable(unit), Optional.ToList(groups), Optional.ToList(data));
        }
    }
}