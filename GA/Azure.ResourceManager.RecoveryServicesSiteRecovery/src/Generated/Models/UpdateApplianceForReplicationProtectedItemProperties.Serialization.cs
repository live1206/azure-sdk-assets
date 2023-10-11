// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class UpdateApplianceForReplicationProtectedItemProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetApplianceId"u8);
            writer.WriteStringValue(TargetApplianceId);
            writer.WritePropertyName("providerSpecificDetails"u8);
            writer.WriteObjectValue(ProviderSpecificDetails);
            writer.WriteEndObject();
        }
    }
}