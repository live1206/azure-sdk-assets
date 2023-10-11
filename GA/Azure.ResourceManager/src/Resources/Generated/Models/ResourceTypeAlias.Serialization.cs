// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourceTypeAlias
    {
        internal static ResourceTypeAlias DeserializeResourceTypeAlias(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<ResourceTypeAliasPath>> paths = default;
            Optional<ResourceTypeAliasType> type = default;
            Optional<string> defaultPath = default;
            Optional<ResourceTypeAliasPattern> defaultPattern = default;
            Optional<ResourceTypeAliasPathMetadata> defaultMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeAliasPath> array = new List<ResourceTypeAliasPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeAliasPath.DeserializeResourceTypeAliasPath(item));
                    }
                    paths = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasType();
                    continue;
                }
                if (property.NameEquals("defaultPath"u8))
                {
                    defaultPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultPattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultPattern = ResourceTypeAliasPattern.DeserializeResourceTypeAliasPattern(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMetadata = ResourceTypeAliasPathMetadata.DeserializeResourceTypeAliasPathMetadata(property.Value);
                    continue;
                }
            }
            return new ResourceTypeAlias(name.Value, Optional.ToList(paths), Optional.ToNullable(type), defaultPath.Value, defaultPattern.Value, defaultMetadata.Value);
        }
    }
}
