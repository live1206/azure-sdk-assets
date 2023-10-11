// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupSchemaTableColumn : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName"u8);
                writer.WriteStringValue(QuotedName);
            }
            if (Optional.IsDefined(DataSize))
            {
                writer.WritePropertyName("dataSize"u8);
                writer.WriteStringValue(DataSize);
            }
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            writer.WriteEndObject();
        }

        internal static SyncGroupSchemaTableColumn DeserializeSyncGroupSchemaTableColumn(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> quotedName = default;
            Optional<string> dataSize = default;
            Optional<string> dataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quotedName"u8))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSize"u8))
                {
                    dataSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
            }
            return new SyncGroupSchemaTableColumn(quotedName.Value, dataSize.Value, dataType.Value);
        }
    }
}