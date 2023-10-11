// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeExtension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUri))
            {
                writer.WritePropertyName("endpointUri"u8);
                writer.WriteStringValue(EndpointUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(ExtensionCategories))
            {
                writer.WritePropertyName("extensionCategories"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionCategories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static ResourceTypeExtension DeserializeResourceTypeExtension(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> endpointUri = default;
            Optional<IList<ResourceTypeExtensionCategory>> extensionCategories = default;
            Optional<TimeSpan> timeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extensionCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeExtensionCategory> array = new List<ResourceTypeExtensionCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ResourceTypeExtensionCategory(item.GetString()));
                    }
                    extensionCategories = array;
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new ResourceTypeExtension(endpointUri.Value, Optional.ToList(extensionCategories), Optional.ToNullable(timeout));
        }
    }
}
