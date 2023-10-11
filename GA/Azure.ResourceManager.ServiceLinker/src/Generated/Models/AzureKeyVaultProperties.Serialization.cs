// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class AzureKeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DoesConnectAsKubernetesCsiDriver))
            {
                if (DoesConnectAsKubernetesCsiDriver != null)
                {
                    writer.WritePropertyName("connectAsKubernetesCsiDriver"u8);
                    writer.WriteBooleanValue(DoesConnectAsKubernetesCsiDriver.Value);
                }
                else
                {
                    writer.WriteNull("connectAsKubernetesCsiDriver");
                }
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AzureResourceType.ToString());
            writer.WriteEndObject();
        }

        internal static AzureKeyVaultProperties DeserializeAzureKeyVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool?> connectAsKubernetesCsiDriver = default;
            AzureResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectAsKubernetesCsiDriver"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectAsKubernetesCsiDriver = null;
                        continue;
                    }
                    connectAsKubernetesCsiDriver = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new AzureResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureKeyVaultProperties(type, Optional.ToNullable(connectAsKubernetesCsiDriver));
        }
    }
}