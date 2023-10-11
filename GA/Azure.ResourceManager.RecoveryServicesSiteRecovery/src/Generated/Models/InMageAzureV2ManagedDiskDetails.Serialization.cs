// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2ManagedDiskDetails
    {
        internal static InMageAzureV2ManagedDiskDetails DeserializeInMageAzureV2ManagedDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> seedManagedDiskId = default;
            Optional<string> replicaDiskType = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<string> targetDiskName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaDiskType"u8))
                {
                    replicaDiskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskName"u8))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
            }
            return new InMageAzureV2ManagedDiskDetails(diskId.Value, seedManagedDiskId.Value, replicaDiskType.Value, diskEncryptionSetId.Value, targetDiskName.Value);
        }
    }
}