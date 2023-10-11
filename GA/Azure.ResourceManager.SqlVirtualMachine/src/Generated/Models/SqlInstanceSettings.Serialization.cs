// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlInstanceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxDop))
            {
                writer.WritePropertyName("maxDop"u8);
                writer.WriteNumberValue(MaxDop.Value);
            }
            if (Optional.IsDefined(IsOptimizeForAdHocWorkloadsEnabled))
            {
                writer.WritePropertyName("isOptimizeForAdHocWorkloadsEnabled"u8);
                writer.WriteBooleanValue(IsOptimizeForAdHocWorkloadsEnabled.Value);
            }
            if (Optional.IsDefined(MinServerMemoryInMB))
            {
                writer.WritePropertyName("minServerMemoryMB"u8);
                writer.WriteNumberValue(MinServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(MaxServerMemoryInMB))
            {
                writer.WritePropertyName("maxServerMemoryMB"u8);
                writer.WriteNumberValue(MaxServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(IsLpimEnabled))
            {
                writer.WritePropertyName("isLpimEnabled"u8);
                writer.WriteBooleanValue(IsLpimEnabled.Value);
            }
            if (Optional.IsDefined(IsIfiEnabled))
            {
                writer.WritePropertyName("isIfiEnabled"u8);
                writer.WriteBooleanValue(IsIfiEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlInstanceSettings DeserializeSqlInstanceSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> collation = default;
            Optional<int> maxDop = default;
            Optional<bool> isOptimizeForAdHocWorkloadsEnabled = default;
            Optional<int> minServerMemoryMB = default;
            Optional<int> maxServerMemoryMB = default;
            Optional<bool> isLpimEnabled = default;
            Optional<bool> isIfiEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collation"u8))
                {
                    collation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDop = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isOptimizeForAdHocWorkloadsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptimizeForAdHocWorkloadsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minServerMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxServerMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isLpimEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLpimEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isIfiEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isIfiEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SqlInstanceSettings(collation.Value, Optional.ToNullable(maxDop), Optional.ToNullable(isOptimizeForAdHocWorkloadsEnabled), Optional.ToNullable(minServerMemoryMB), Optional.ToNullable(maxServerMemoryMB), Optional.ToNullable(isLpimEnabled), Optional.ToNullable(isIfiEnabled));
        }
    }
}