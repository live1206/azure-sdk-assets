// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterClientCertificateThumbprint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin"u8);
            writer.WriteBooleanValue(IsAdmin);
            writer.WritePropertyName("certificateThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CertificateThumbprint);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(CertificateThumbprint.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        internal static ClusterClientCertificateThumbprint DeserializeClusterClientCertificateThumbprint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isAdmin = default;
            BinaryData certificateThumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"u8))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificateThumbprint"u8))
                {
                    certificateThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ClusterClientCertificateThumbprint(isAdmin, certificateThumbprint);
        }
    }
}