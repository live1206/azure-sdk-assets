// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TopologyResourceInfo
    {
        internal static TopologyResourceInfo DeserializeTopologyResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<TopologyAssociation>> associations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("associations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TopologyAssociation> array = new List<TopologyAssociation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologyAssociation.DeserializeTopologyAssociation(item));
                    }
                    associations = array;
                    continue;
                }
            }
            return new TopologyResourceInfo(name.Value, id.Value, Optional.ToNullable(location), Optional.ToList(associations));
        }
    }
}