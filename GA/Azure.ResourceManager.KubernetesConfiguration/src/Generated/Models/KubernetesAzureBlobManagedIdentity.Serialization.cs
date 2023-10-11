// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    internal partial class KubernetesAzureBlobManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            writer.WriteEndObject();
        }

        internal static KubernetesAzureBlobManagedIdentity DeserializeKubernetesAzureBlobManagedIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid?> clientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
            }
            return new KubernetesAzureBlobManagedIdentity(Optional.ToNullable(clientId));
        }
    }
}