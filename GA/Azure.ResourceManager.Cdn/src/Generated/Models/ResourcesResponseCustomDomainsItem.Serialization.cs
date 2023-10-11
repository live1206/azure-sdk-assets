// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResourcesResponseCustomDomainsItem
    {
        internal static ResourcesResponseCustomDomainsItem DeserializeResourcesResponseCustomDomainsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> endpointId = default;
            Optional<bool> history = default;
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
                if (property.NameEquals("endpointId"u8))
                {
                    endpointId = property.Value.GetString();
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
            }
            return new ResourcesResponseCustomDomainsItem(id.Value, name.Value, endpointId.Value, Optional.ToNullable(history));
        }
    }
}