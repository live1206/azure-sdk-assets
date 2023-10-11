// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class StorageClassificationMappingProperties
    {
        internal static StorageClassificationMappingProperties DeserializeStorageClassificationMappingProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> targetStorageClassificationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetStorageClassificationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetStorageClassificationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new StorageClassificationMappingProperties(targetStorageClassificationId.Value);
        }
    }
}