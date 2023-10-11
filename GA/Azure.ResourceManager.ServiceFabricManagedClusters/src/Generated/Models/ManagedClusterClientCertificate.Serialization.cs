// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterClientCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin"u8);
            writer.WriteBooleanValue(IsAdmin);
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Thumbprint.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CommonName))
            {
                writer.WritePropertyName("commonName"u8);
                writer.WriteStringValue(CommonName);
            }
            if (Optional.IsDefined(IssuerThumbprint))
            {
                writer.WritePropertyName("issuerThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(IssuerThumbprint);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(IssuerThumbprint.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterClientCertificate DeserializeManagedClusterClientCertificate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isAdmin = default;
            Optional<BinaryData> thumbprint = default;
            Optional<string> commonName = default;
            Optional<BinaryData> issuerThumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"u8))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("commonName"u8))
                {
                    commonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuerThumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issuerThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ManagedClusterClientCertificate(isAdmin, thumbprint.Value, commonName.Value, issuerThumbprint.Value);
        }
    }
}