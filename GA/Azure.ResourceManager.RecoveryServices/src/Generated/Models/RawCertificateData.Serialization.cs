// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RawCertificateData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthType))
            {
                writer.WritePropertyName("authType"u8);
                writer.WriteStringValue(AuthType.Value.ToString());
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteBase64StringValue(Certificate, "D");
            }
            writer.WriteEndObject();
        }
    }
}