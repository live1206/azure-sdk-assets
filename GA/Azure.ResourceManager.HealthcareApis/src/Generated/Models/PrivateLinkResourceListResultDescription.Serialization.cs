// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    internal partial class PrivateLinkResourceListResultDescription
    {
        internal static PrivateLinkResourceListResultDescription DeserializePrivateLinkResourceListResultDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HealthcareApisPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisPrivateLinkResourceData> array = new List<HealthcareApisPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisPrivateLinkResourceData.DeserializeHealthcareApisPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkResourceListResultDescription(Optional.ToList(value));
        }
    }
}
