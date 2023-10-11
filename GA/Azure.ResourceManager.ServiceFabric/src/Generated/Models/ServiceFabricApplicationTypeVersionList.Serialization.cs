// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    internal partial class ServiceFabricApplicationTypeVersionList
    {
        internal static ServiceFabricApplicationTypeVersionList DeserializeServiceFabricApplicationTypeVersionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ServiceFabricApplicationTypeVersionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceFabricApplicationTypeVersionData> array = new List<ServiceFabricApplicationTypeVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceFabricApplicationTypeVersionData.DeserializeServiceFabricApplicationTypeVersionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceFabricApplicationTypeVersionList(Optional.ToList(value), nextLink.Value);
        }
    }
}