// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiTagDescriptionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ExternalDocsUri))
            {
                writer.WritePropertyName("externalDocsUrl"u8);
                writer.WriteStringValue(ExternalDocsUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ExternalDocsDescription))
            {
                writer.WritePropertyName("externalDocsDescription"u8);
                writer.WriteStringValue(ExternalDocsDescription);
            }
            if (Optional.IsDefined(TagId))
            {
                writer.WritePropertyName("tagId"u8);
                writer.WriteStringValue(TagId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiTagDescriptionData DeserializeApiTagDescriptionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<Uri> externalDocsUri = default;
            Optional<string> externalDocsDescription = default;
            Optional<string> tagId = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("externalDocsUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            externalDocsUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externalDocsDescription"u8))
                        {
                            externalDocsDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tagId"u8))
                        {
                            tagId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiTagDescriptionData(id, name, type, systemData.Value, description.Value, externalDocsUri.Value, externalDocsDescription.Value, tagId.Value, displayName.Value);
        }
    }
}