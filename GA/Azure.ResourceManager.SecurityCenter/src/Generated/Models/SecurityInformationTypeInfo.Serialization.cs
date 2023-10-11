// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityInformationTypeInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            if (Optional.IsDefined(RecommendedLabelId))
            {
                writer.WritePropertyName("recommendedLabelId"u8);
                writer.WriteStringValue(RecommendedLabelId.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Custom))
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteBooleanValue(Custom.Value);
            }
            if (Optional.IsCollectionDefined(Keywords))
            {
                writer.WritePropertyName("keywords"u8);
                writer.WriteStartArray();
                foreach (var item in Keywords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SecurityInformationTypeInfo DeserializeSecurityInformationTypeInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<int> order = default;
            Optional<Guid> recommendedLabelId = default;
            Optional<bool> enabled = default;
            Optional<bool> custom = default;
            Optional<IList<InformationProtectionKeyword>> keywords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recommendedLabelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedLabelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keywords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InformationProtectionKeyword> array = new List<InformationProtectionKeyword>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InformationProtectionKeyword.DeserializeInformationProtectionKeyword(item));
                    }
                    keywords = array;
                    continue;
                }
            }
            return new SecurityInformationTypeInfo(displayName.Value, description.Value, Optional.ToNullable(order), Optional.ToNullable(recommendedLabelId), Optional.ToNullable(enabled), Optional.ToNullable(custom), Optional.ToList(keywords));
        }
    }
}