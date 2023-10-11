// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetworkUsageName
    {
        internal static VirtualNetworkUsageName DeserializeVirtualNetworkUsageName(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> localizedValue = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localizedValue"u8))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworkUsageName(localizedValue.Value, value.Value);
        }
    }
}
