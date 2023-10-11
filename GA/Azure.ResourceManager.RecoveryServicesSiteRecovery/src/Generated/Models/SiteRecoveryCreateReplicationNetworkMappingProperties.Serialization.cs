// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryCreateReplicationNetworkMappingProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryFabricName))
            {
                writer.WritePropertyName("recoveryFabricName"u8);
                writer.WriteStringValue(RecoveryFabricName);
            }
            writer.WritePropertyName("recoveryNetworkId"u8);
            writer.WriteStringValue(RecoveryNetworkId);
            if (Optional.IsDefined(FabricSpecificDetails))
            {
                writer.WritePropertyName("fabricSpecificDetails"u8);
                writer.WriteObjectValue(FabricSpecificDetails);
            }
            writer.WriteEndObject();
        }
    }
}