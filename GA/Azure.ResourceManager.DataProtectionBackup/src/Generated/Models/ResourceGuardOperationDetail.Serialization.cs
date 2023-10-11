// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ResourceGuardOperationDetail : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VaultCriticalOperation))
            {
                writer.WritePropertyName("vaultCriticalOperation"u8);
                writer.WriteStringValue(VaultCriticalOperation);
            }
            if (Optional.IsDefined(DefaultResourceRequest))
            {
                writer.WritePropertyName("defaultResourceRequest"u8);
                writer.WriteStringValue(DefaultResourceRequest);
            }
            writer.WriteEndObject();
        }

        internal static ResourceGuardOperationDetail DeserializeResourceGuardOperationDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vaultCriticalOperation = default;
            Optional<string> defaultResourceRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultCriticalOperation"u8))
                {
                    vaultCriticalOperation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultResourceRequest"u8))
                {
                    defaultResourceRequest = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceGuardOperationDetail(vaultCriticalOperation.Value, defaultResourceRequest.Value);
        }
    }
}