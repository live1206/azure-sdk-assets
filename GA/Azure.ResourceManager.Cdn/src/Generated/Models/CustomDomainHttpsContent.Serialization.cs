// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CustomDomainHttpsContent : IUtf8JsonSerializable
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

        internal static CustomDomainHttpsContent DeserializeCustomDomainHttpsContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("certificateSource", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureKeyVault": return UserManagedHttpsContent.DeserializeUserManagedHttpsContent(element);
                    case "Cdn": return CdnManagedHttpsContent.DeserializeCdnManagedHttpsContent(element);
                }
            }
            return UnknownCustomDomainHttpsParameters.DeserializeUnknownCustomDomainHttpsParameters(element);
        }
    }
}
