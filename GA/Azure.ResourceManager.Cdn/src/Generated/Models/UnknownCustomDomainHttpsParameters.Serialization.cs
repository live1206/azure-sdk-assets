// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class UnknownCustomDomainHttpsParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateSource"u8);
            writer.WriteStringValue(CertificateSource.ToString());
            writer.WritePropertyName("protocolType"u8);
            writer.WriteStringValue(ProtocolType.ToString());
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static UnknownCustomDomainHttpsParameters DeserializeUnknownCustomDomainHttpsParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CertificateSource certificateSource = "Unknown";
            SecureDeliveryProtocolType protocolType = default;
            Optional<CdnMinimumTlsVersion> minimumTlsVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSource"u8))
                {
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"u8))
                {
                    protocolType = new SecureDeliveryProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToCdnMinimumTlsVersion();
                    continue;
                }
            }
            return new UnknownCustomDomainHttpsParameters(certificateSource, protocolType, Optional.ToNullable(minimumTlsVersion));
        }
    }
}