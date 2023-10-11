// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class VirtualNetworkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetResourceId))
            {
                writer.WritePropertyName("subnetResourceId"u8);
                writer.WriteStringValue(SubnetResourceId);
            }
            writer.WriteEndObject();
        }

        internal static VirtualNetworkConfiguration DeserializeVirtualNetworkConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> vnetid = default;
            Optional<string> subnetname = default;
            Optional<ResourceIdentifier> subnetResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("subnetname"u8))
                {
                    subnetname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualNetworkConfiguration(Optional.ToNullable(vnetid), subnetname.Value, subnetResourceId.Value);
        }
    }
}