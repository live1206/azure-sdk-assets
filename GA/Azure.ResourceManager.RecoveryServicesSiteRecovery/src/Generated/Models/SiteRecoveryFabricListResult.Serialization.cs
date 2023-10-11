// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class SiteRecoveryFabricListResult
    {
        internal static SiteRecoveryFabricListResult DeserializeSiteRecoveryFabricListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SiteRecoveryFabricData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryFabricData> array = new List<SiteRecoveryFabricData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryFabricData.DeserializeSiteRecoveryFabricData(item));
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
            return new SiteRecoveryFabricListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}