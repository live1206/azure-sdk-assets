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
    public partial class PlanExtension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteStringValue(IsEnabled.ToString());
            if (Optional.IsCollectionDefined(AdditionalExtensionProperties))
            {
                writer.WritePropertyName("additionalExtensionProperties"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalExtensionProperties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static PlanExtension DeserializePlanExtension(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IsExtensionEnabled isEnabled = default;
            Optional<IDictionary<string, BinaryData>> additionalExtensionProperties = default;
            Optional<ExtensionOperationStatus> operationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = new IsExtensionEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("additionalExtensionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    additionalExtensionProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("operationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationStatus = ExtensionOperationStatus.DeserializeExtensionOperationStatus(property.Value);
                    continue;
                }
            }
            return new PlanExtension(name, isEnabled, Optional.ToDictionary(additionalExtensionProperties), operationStatus.Value);
        }
    }
}