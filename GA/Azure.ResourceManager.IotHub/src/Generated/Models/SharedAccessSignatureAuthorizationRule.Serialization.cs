// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class SharedAccessSignatureAuthorizationRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            writer.WritePropertyName("rights"u8);
            writer.WriteStringValue(Rights.ToSerialString());
            writer.WriteEndObject();
        }

        internal static SharedAccessSignatureAuthorizationRule DeserializeSharedAccessSignatureAuthorizationRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            IotHubSharedAccessRight rights = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rights"u8))
                {
                    rights = property.Value.GetString().ToIotHubSharedAccessRight();
                    continue;
                }
            }
            return new SharedAccessSignatureAuthorizationRule(keyName, primaryKey.Value, secondaryKey.Value, rights);
        }
    }
}
