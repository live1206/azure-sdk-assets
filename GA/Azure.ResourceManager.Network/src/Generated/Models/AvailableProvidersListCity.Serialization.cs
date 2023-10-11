// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AvailableProvidersListCity
    {
        internal static AvailableProvidersListCity DeserializeAvailableProvidersListCity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cityName = default;
            Optional<IReadOnlyList<string>> providers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cityName"u8))
                {
                    cityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providers"u8))
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
                    providers = array;
                    continue;
                }
            }
            return new AvailableProvidersListCity(cityName.Value, Optional.ToList(providers));
        }
    }
}