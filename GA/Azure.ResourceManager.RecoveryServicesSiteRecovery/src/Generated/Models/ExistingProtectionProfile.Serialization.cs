// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExistingProtectionProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("protectionProfileId"u8);
            writer.WriteStringValue(ProtectionProfileId);
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static ExistingProtectionProfile DeserializeExistingProtectionProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string protectionProfileId = default;
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionProfileId"u8))
                {
                    protectionProfileId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new ExistingProtectionProfile(resourceType, protectionProfileId);
        }
    }
}