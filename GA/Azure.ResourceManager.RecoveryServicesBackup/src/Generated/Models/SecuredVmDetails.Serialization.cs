// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal partial class SecuredVmDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecuredVmOSDiskEncryptionSetId))
            {
                writer.WritePropertyName("securedVMOsDiskEncryptionSetId"u8);
                writer.WriteStringValue(SecuredVmOSDiskEncryptionSetId);
            }
            writer.WriteEndObject();
        }

        internal static SecuredVmDetails DeserializeSecuredVmDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> securedVmOSDiskEncryptionSetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securedVMOsDiskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securedVmOSDiskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new SecuredVmDetails(securedVmOSDiskEncryptionSetId.Value);
        }
    }
}