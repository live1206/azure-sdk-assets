// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class FirewallPolicySQL : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowSqlRedirect))
            {
                writer.WritePropertyName("allowSqlRedirect"u8);
                writer.WriteBooleanValue(AllowSqlRedirect.Value);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicySQL DeserializeFirewallPolicySQL(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> allowSqlRedirect = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowSqlRedirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowSqlRedirect = property.Value.GetBoolean();
                    continue;
                }
            }
            return new FirewallPolicySQL(Optional.ToNullable(allowSqlRedirect));
        }
    }
}