// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterAzureActiveDirectory : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(ClusterApplication))
            {
                writer.WritePropertyName("clusterApplication"u8);
                writer.WriteStringValue(ClusterApplication);
            }
            if (Optional.IsDefined(ClientApplication))
            {
                writer.WritePropertyName("clientApplication"u8);
                writer.WriteStringValue(ClientApplication);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAzureActiveDirectory DeserializeManagedClusterAzureActiveDirectory(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> tenantId = default;
            Optional<string> clusterApplication = default;
            Optional<string> clientApplication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clusterApplication"u8))
                {
                    clusterApplication = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientApplication"u8))
                {
                    clientApplication = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedClusterAzureActiveDirectory(Optional.ToNullable(tenantId), clusterApplication.Value, clientApplication.Value);
        }
    }
}