// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class RegionContract
    {
        internal static RegionContract DeserializeRegionContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<bool> isMasterRegion = default;
            Optional<bool> isDeleted = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMasterRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMasterRegion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeleted = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RegionContract(name.Value, Optional.ToNullable(isMasterRegion), Optional.ToNullable(isDeleted));
        }
    }
}