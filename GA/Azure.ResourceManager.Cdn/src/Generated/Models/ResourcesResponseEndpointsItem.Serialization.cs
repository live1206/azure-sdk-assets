// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResourcesResponseEndpointsItem
    {
        internal static ResourcesResponseEndpointsItem DeserializeResourcesResponseEndpointsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<bool> history = default;
            Optional<IReadOnlyList<ResourcesResponseEndpointsPropertiesItemsItem>> customDomains = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    history = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customDomains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourcesResponseEndpointsPropertiesItemsItem> array = new List<ResourcesResponseEndpointsPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourcesResponseEndpointsPropertiesItemsItem.DeserializeResourcesResponseEndpointsPropertiesItemsItem(item));
                    }
                    customDomains = array;
                    continue;
                }
            }
            return new ResourcesResponseEndpointsItem(id.Value, name.Value, Optional.ToNullable(history), Optional.ToList(customDomains));
        }
    }
}