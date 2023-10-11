// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AEventDetails
    {
        internal static A2AEventDetails DeserializeA2AEventDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protectedItemName = default;
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<string> fabricName = default;
            Optional<AzureLocation> fabricLocation = default;
            Optional<string> remoteFabricName = default;
            Optional<AzureLocation> remoteFabricLocation = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteFabricName"u8))
                {
                    remoteFabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new A2AEventDetails(instanceType, protectedItemName.Value, fabricObjectId.Value, fabricName.Value, Optional.ToNullable(fabricLocation), remoteFabricName.Value, Optional.ToNullable(remoteFabricLocation));
        }
    }
}