// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class BackendPoolsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnforceCertificateNameCheck))
            {
                writer.WritePropertyName("enforceCertificateNameCheck"u8);
                writer.WriteStringValue(EnforceCertificateNameCheck.Value.ToString());
            }
            if (Optional.IsDefined(SendRecvTimeoutInSeconds))
            {
                writer.WritePropertyName("sendRecvTimeoutSeconds"u8);
                writer.WriteNumberValue(SendRecvTimeoutInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static BackendPoolsSettings DeserializeBackendPoolsSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EnforceCertificateNameCheckEnabledState> enforceCertificateNameCheck = default;
            Optional<int> sendRecvTimeoutSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enforceCertificateNameCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enforceCertificateNameCheck = new EnforceCertificateNameCheckEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendRecvTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendRecvTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new BackendPoolsSettings(Optional.ToNullable(enforceCertificateNameCheck), Optional.ToNullable(sendRecvTimeoutSeconds));
        }
    }
}