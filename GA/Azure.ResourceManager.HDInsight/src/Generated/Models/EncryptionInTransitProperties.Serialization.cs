// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    internal partial class EncryptionInTransitProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEncryptionInTransitEnabled))
            {
                writer.WritePropertyName("isEncryptionInTransitEnabled"u8);
                writer.WriteBooleanValue(IsEncryptionInTransitEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionInTransitProperties DeserializeEncryptionInTransitProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isEncryptionInTransitEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEncryptionInTransitEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEncryptionInTransitEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EncryptionInTransitProperties(Optional.ToNullable(isEncryptionInTransitEnabled));
        }
    }
}