// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerNetwork : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DelegatedSubnetResourceId))
            {
                writer.WritePropertyName("delegatedSubnetResourceId"u8);
                writer.WriteStringValue(DelegatedSubnetResourceId);
            }
            if (Optional.IsDefined(PrivateDnsZoneArmResourceId))
            {
                writer.WritePropertyName("privateDnsZoneArmResourceId"u8);
                writer.WriteStringValue(PrivateDnsZoneArmResourceId);
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlFlexibleServerNetwork DeserializePostgreSqlFlexibleServerNetwork(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PostgreSqlFlexibleServerPublicNetworkAccessState> publicNetworkAccess = default;
            Optional<ResourceIdentifier> delegatedSubnetResourceId = default;
            Optional<ResourceIdentifier> privateDnsZoneArmResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PostgreSqlFlexibleServerPublicNetworkAccessState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("delegatedSubnetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delegatedSubnetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateDnsZoneArmResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateDnsZoneArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerNetwork(Optional.ToNullable(publicNetworkAccess), delegatedSubnetResourceId.Value, privateDnsZoneArmResourceId.Value);
        }
    }
}