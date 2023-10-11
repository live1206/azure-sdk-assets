// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class LinuxProfilePropertiesSshPublicKeysItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyData))
            {
                writer.WritePropertyName("keyData"u8);
                writer.WriteStringValue(KeyData);
            }
            writer.WriteEndObject();
        }

        internal static LinuxProfilePropertiesSshPublicKeysItem DeserializeLinuxProfilePropertiesSshPublicKeysItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyData"u8))
                {
                    keyData = property.Value.GetString();
                    continue;
                }
            }
            return new LinuxProfilePropertiesSshPublicKeysItem(keyData.Value);
        }
    }
}