// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentAvailableFeatures
    {
        internal static ApplicationInsightsComponentAvailableFeatures DeserializeApplicationInsightsComponentAvailableFeatures(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ApplicationInsightsComponentFeature>> result = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationInsightsComponentFeature> array = new List<ApplicationInsightsComponentFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationInsightsComponentFeature.DeserializeApplicationInsightsComponentFeature(item));
                    }
                    result = array;
                    continue;
                }
            }
            return new ApplicationInsightsComponentAvailableFeatures(Optional.ToList(result));
        }
    }
}