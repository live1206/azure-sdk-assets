// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class CustomHttpsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateSource"u8);
            writer.WriteStringValue(CertificateSource.ToString());
            writer.WritePropertyName("protocolType"u8);
            writer.WriteStringValue(ProtocolType.ToString());
            writer.WritePropertyName("minimumTlsVersion"u8);
            writer.WriteStringValue(MinimumTlsVersion.ToString());
            writer.WritePropertyName("frontDoorCertificateSourceParameters"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateType))
            {
                writer.WritePropertyName("certificateType"u8);
                writer.WriteStringValue(CertificateType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("keyVaultCertificateSourceParameters"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Vault))
            {
                writer.WritePropertyName("vault"u8);
                JsonSerializer.Serialize(writer, Vault);
            }
            if (Optional.IsDefined(SecretName))
            {
                writer.WritePropertyName("secretName"u8);
                writer.WriteStringValue(SecretName);
            }
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomHttpsConfiguration DeserializeCustomHttpsConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FrontDoorCertificateSource certificateSource = default;
            FrontDoorTlsProtocolType protocolType = default;
            FrontDoorRequiredMinimumTlsVersion minimumTlsVersion = default;
            Optional<FrontDoorEndpointConnectionCertificateType> certificateType = default;
            Optional<WritableSubResource> vault = default;
            Optional<string> secretName = default;
            Optional<string> secretVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSource"u8))
                {
                    certificateSource = new FrontDoorCertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"u8))
                {
                    protocolType = new FrontDoorTlsProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    minimumTlsVersion = new FrontDoorRequiredMinimumTlsVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontDoorCertificateSourceParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("certificateType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certificateType = new FrontDoorEndpointConnectionCertificateType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("keyVaultCertificateSourceParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vault = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("secretName"u8))
                        {
                            secretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretVersion"u8))
                        {
                            secretVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomHttpsConfiguration(certificateSource, protocolType, minimumTlsVersion, Optional.ToNullable(certificateType), vault, secretName.Value, secretVersion.Value);
        }
    }
}