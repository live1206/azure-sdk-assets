// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ContinentsResponse
    {
        internal static ContinentsResponse DeserializeContinentsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ContinentsResponseContinentsItem>> continents = default;
            Optional<IReadOnlyList<ContinentsResponseCountryOrRegionsItem>> countryOrRegions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContinentsResponseContinentsItem> array = new List<ContinentsResponseContinentsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContinentsResponseContinentsItem.DeserializeContinentsResponseContinentsItem(item));
                    }
                    continents = array;
                    continue;
                }
                if (property.NameEquals("countryOrRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContinentsResponseCountryOrRegionsItem> array = new List<ContinentsResponseCountryOrRegionsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContinentsResponseCountryOrRegionsItem.DeserializeContinentsResponseCountryOrRegionsItem(item));
                    }
                    countryOrRegions = array;
                    continue;
                }
            }
            return new ContinentsResponse(Optional.ToList(continents), Optional.ToList(countryOrRegions));
        }
    }
}