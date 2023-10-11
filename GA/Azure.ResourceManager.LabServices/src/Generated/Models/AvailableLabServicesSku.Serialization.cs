// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSku
    {
        internal static AvailableLabServicesSku DeserializeAvailableLabServicesSku(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<string> name = default;
            Optional<AvailableLabServicesSkuTier> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<AvailableLabServicesSkuCapacity> capacity = default;
            Optional<IReadOnlyList<AvailableLabServicesSkuCapability>> capabilities = default;
            Optional<IReadOnlyList<AzureLocation>> locations = default;
            Optional<IReadOnlyList<AvailableLabServicesSkuCost>> costs = default;
            Optional<IReadOnlyList<AvailableLabServicesSkuRestrictions>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new AvailableLabServicesSkuTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"u8))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = AvailableLabServicesSkuCapacity.DeserializeAvailableLabServicesSkuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableLabServicesSkuCapability> array = new List<AvailableLabServicesSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSkuCapability.DeserializeAvailableLabServicesSkuCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableLabServicesSkuCost> array = new List<AvailableLabServicesSkuCost>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSkuCost.DeserializeAvailableLabServicesSkuCost(item));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableLabServicesSkuRestrictions> array = new List<AvailableLabServicesSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSkuRestrictions.DeserializeAvailableLabServicesSkuRestrictions(item));
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new AvailableLabServicesSku(resourceType.Value, name.Value, Optional.ToNullable(tier), size.Value, family.Value, capacity.Value, Optional.ToList(capabilities), Optional.ToList(locations), Optional.ToList(costs), Optional.ToList(restrictions));
        }
    }
}