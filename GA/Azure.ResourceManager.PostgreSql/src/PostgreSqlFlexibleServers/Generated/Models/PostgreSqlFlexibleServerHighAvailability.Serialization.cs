// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerHighAvailability : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(StandbyAvailabilityZone))
            {
                writer.WritePropertyName("standbyAvailabilityZone"u8);
                writer.WriteStringValue(StandbyAvailabilityZone);
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlFlexibleServerHighAvailability DeserializePostgreSqlFlexibleServerHighAvailability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PostgreSqlFlexibleServerHighAvailabilityMode> mode = default;
            Optional<PostgreSqlFlexibleServerHAState> state = default;
            Optional<string> standbyAvailabilityZone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new PostgreSqlFlexibleServerHighAvailabilityMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PostgreSqlFlexibleServerHAState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("standbyAvailabilityZone"u8))
                {
                    standbyAvailabilityZone = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerHighAvailability(Optional.ToNullable(mode), Optional.ToNullable(state), standbyAvailabilityZone.Value);
        }
    }
}