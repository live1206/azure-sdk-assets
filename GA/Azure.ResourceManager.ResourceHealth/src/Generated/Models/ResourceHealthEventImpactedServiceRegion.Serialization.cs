// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventImpactedServiceRegion
    {
        internal static ResourceHealthEventImpactedServiceRegion DeserializeResourceHealthEventImpactedServiceRegion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> impactedRegion = default;
            Optional<ResourceHealthEventStatusValue> status = default;
            Optional<IReadOnlyList<string>> impactedSubscriptions = default;
            Optional<IReadOnlyList<string>> impactedTenants = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<IReadOnlyList<ResourceHealthEventUpdate>> updates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("impactedRegion"u8))
                {
                    impactedRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ResourceHealthEventStatusValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactedSubscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    impactedSubscriptions = array;
                    continue;
                }
                if (property.NameEquals("impactedTenants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    impactedTenants = array;
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
                if (property.NameEquals("updates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceHealthEventUpdate> array = new List<ResourceHealthEventUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceHealthEventUpdate.DeserializeResourceHealthEventUpdate(item));
                    }
                    updates = array;
                    continue;
                }
            }
            return new ResourceHealthEventImpactedServiceRegion(impactedRegion.Value, Optional.ToNullable(status), Optional.ToList(impactedSubscriptions), Optional.ToList(impactedTenants), Optional.ToNullable(lastUpdateTime), Optional.ToList(updates));
        }
    }
}