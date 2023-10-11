// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class SystemAssignedIdentityAuthInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            writer.WriteEndObject();
        }

        internal static SystemAssignedIdentityAuthInfo DeserializeSystemAssignedIdentityAuthInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkerAuthType authType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authType"u8))
                {
                    authType = new LinkerAuthType(property.Value.GetString());
                    continue;
                }
            }
            return new SystemAssignedIdentityAuthInfo(authType);
        }
    }
}