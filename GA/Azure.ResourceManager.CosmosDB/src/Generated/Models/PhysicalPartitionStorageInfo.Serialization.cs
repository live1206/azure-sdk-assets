// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PhysicalPartitionStorageInfo
    {
        internal static PhysicalPartitionStorageInfo DeserializePhysicalPartitionStorageInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<double> storageInKB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageInKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageInKB = property.Value.GetDouble();
                    continue;
                }
            }
            return new PhysicalPartitionStorageInfo(id.Value, Optional.ToNullable(storageInKB));
        }
    }
}
