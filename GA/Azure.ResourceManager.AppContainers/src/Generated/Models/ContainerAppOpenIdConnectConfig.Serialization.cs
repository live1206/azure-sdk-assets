// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppOpenIdConnectConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationEndpoint))
            {
                writer.WritePropertyName("authorizationEndpoint"u8);
                writer.WriteStringValue(AuthorizationEndpoint);
            }
            if (Optional.IsDefined(TokenEndpoint))
            {
                writer.WritePropertyName("tokenEndpoint"u8);
                writer.WriteStringValue(TokenEndpoint);
            }
            if (Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (Optional.IsDefined(CertificationUri))
            {
                writer.WritePropertyName("certificationUri"u8);
                writer.WriteStringValue(CertificationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(WellKnownOpenIdConfiguration))
            {
                writer.WritePropertyName("wellKnownOpenIdConfiguration"u8);
                writer.WriteStringValue(WellKnownOpenIdConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppOpenIdConnectConfig DeserializeContainerAppOpenIdConnectConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> authorizationEndpoint = default;
            Optional<string> tokenEndpoint = default;
            Optional<string> issuer = default;
            Optional<Uri> certificationUri = default;
            Optional<string> wellKnownOpenIdConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationEndpoint"u8))
                {
                    authorizationEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenEndpoint"u8))
                {
                    tokenEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificationUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wellKnownOpenIdConfiguration"u8))
                {
                    wellKnownOpenIdConfiguration = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppOpenIdConnectConfig(authorizationEndpoint.Value, tokenEndpoint.Value, issuer.Value, certificationUri.Value, wellKnownOpenIdConfiguration.Value);
        }
    }
}