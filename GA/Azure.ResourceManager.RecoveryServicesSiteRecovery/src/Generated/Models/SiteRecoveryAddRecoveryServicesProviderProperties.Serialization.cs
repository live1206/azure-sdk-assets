// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryAddRecoveryServicesProviderProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            if (Optional.IsDefined(MachineId))
            {
                writer.WritePropertyName("machineId"u8);
                writer.WriteStringValue(MachineId);
            }
            if (Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            writer.WritePropertyName("authenticationIdentityInput"u8);
            writer.WriteObjectValue(AuthenticationIdentityContent);
            writer.WritePropertyName("resourceAccessIdentityInput"u8);
            writer.WriteObjectValue(ResourceAccessIdentityContent);
            if (Optional.IsDefined(DataPlaneAuthenticationIdentityContent))
            {
                writer.WritePropertyName("dataPlaneAuthenticationIdentityInput"u8);
                writer.WriteObjectValue(DataPlaneAuthenticationIdentityContent);
            }
            writer.WriteEndObject();
        }
    }
}