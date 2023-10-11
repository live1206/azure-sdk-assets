// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessorArchitecture))
            {
                writer.WritePropertyName("processorArchitecture"u8);
                writer.WriteStringValue(ProcessorArchitecture.Value.ToString());
            }
            if (Optional.IsDefined(AuthenticationMethod))
            {
                writer.WritePropertyName("authenticationMethod"u8);
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            if (Optional.IsDefined(RadiusServerAuthCertificate))
            {
                writer.WritePropertyName("radiusServerAuthCertificate"u8);
                writer.WriteStringValue(RadiusServerAuthCertificate);
            }
            if (Optional.IsCollectionDefined(ClientRootCertificates))
            {
                writer.WritePropertyName("clientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in ClientRootCertificates)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}