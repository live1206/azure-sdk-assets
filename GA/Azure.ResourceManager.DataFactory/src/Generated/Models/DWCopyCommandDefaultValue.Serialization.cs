// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DWCopyCommandDefaultValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ColumnName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ColumnName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DefaultValue);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DefaultValue.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DWCopyCommandDefaultValue DeserializeDWCopyCommandDefaultValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> columnName = default;
            Optional<BinaryData> defaultValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new DWCopyCommandDefaultValue(columnName.Value, defaultValue.Value);
        }
    }
}