// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxCertificateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVirtualPath))
            {
                writer.WritePropertyName("keyVirtualPath"u8);
                writer.WriteStringValue(KeyVirtualPath);
            }
            if (Optional.IsDefined(CertificateVirtualPath))
            {
                writer.WritePropertyName("certificateVirtualPath"u8);
                writer.WriteStringValue(CertificateVirtualPath);
            }
            if (Optional.IsDefined(KeyVaultSecretId))
            {
                writer.WritePropertyName("keyVaultSecretId"u8);
                writer.WriteStringValue(KeyVaultSecretId);
            }
            writer.WriteEndObject();
        }

        internal static NginxCertificateProperties DeserializeNginxCertificateProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> keyVirtualPath = default;
            Optional<string> certificateVirtualPath = default;
            Optional<string> keyVaultSecretId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVirtualPath"u8))
                {
                    keyVirtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateVirtualPath"u8))
                {
                    certificateVirtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultSecretId"u8))
                {
                    keyVaultSecretId = property.Value.GetString();
                    continue;
                }
            }
            return new NginxCertificateProperties(Optional.ToNullable(provisioningState), keyVirtualPath.Value, certificateVirtualPath.Value, keyVaultSecretId.Value);
        }
    }
}