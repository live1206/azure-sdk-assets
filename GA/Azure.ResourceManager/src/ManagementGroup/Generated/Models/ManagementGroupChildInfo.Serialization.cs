// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupChildInfo
    {
        internal static ManagementGroupChildInfo DeserializeManagementGroupChildInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagementGroupChildType> type = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<ManagementGroupChildInfo>> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ManagementGroupChildType(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("children"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagementGroupChildInfo> array = new List<ManagementGroupChildInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeManagementGroupChildInfo(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new ManagementGroupChildInfo(Optional.ToNullable(type), id.Value, name.Value, displayName.Value, Optional.ToList(children));
        }
    }
}