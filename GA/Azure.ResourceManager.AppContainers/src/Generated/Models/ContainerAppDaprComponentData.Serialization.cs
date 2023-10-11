// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppDaprComponentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ComponentType))
            {
                writer.WritePropertyName("componentType"u8);
                writer.WriteStringValue(ComponentType);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(IgnoreErrors))
            {
                writer.WritePropertyName("ignoreErrors"u8);
                writer.WriteBooleanValue(IgnoreErrors.Value);
            }
            if (Optional.IsDefined(InitTimeout))
            {
                writer.WritePropertyName("initTimeout"u8);
                writer.WriteStringValue(InitTimeout);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SecretStoreComponent))
            {
                writer.WritePropertyName("secretStoreComponent"u8);
                writer.WriteStringValue(SecretStoreComponent);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerAppDaprComponentData DeserializeContainerAppDaprComponentData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> componentType = default;
            Optional<string> version = default;
            Optional<bool> ignoreErrors = default;
            Optional<string> initTimeout = default;
            Optional<IList<ContainerAppWritableSecret>> secrets = default;
            Optional<string> secretStoreComponent = default;
            Optional<IList<ContainerAppDaprMetadata>> metadata = default;
            Optional<IList<string>> scopes = default;
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
                        if (property0.NameEquals("componentType"u8))
                        {
                            componentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ignoreErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreErrors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("initTimeout"u8))
                        {
                            initTimeout = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secrets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppWritableSecret> array = new List<ContainerAppWritableSecret>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppWritableSecret.DeserializeContainerAppWritableSecret(item));
                            }
                            secrets = array;
                            continue;
                        }
                        if (property0.NameEquals("secretStoreComponent"u8))
                        {
                            secretStoreComponent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppDaprMetadata> array = new List<ContainerAppDaprMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppDaprMetadata.DeserializeContainerAppDaprMetadata(item));
                            }
                            metadata = array;
                            continue;
                        }
                        if (property0.NameEquals("scopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            scopes = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerAppDaprComponentData(id, name, type, systemData.Value, componentType.Value, version.Value, Optional.ToNullable(ignoreErrors), initTimeout.Value, Optional.ToList(secrets), secretStoreComponent.Value, Optional.ToList(metadata), Optional.ToList(scopes));
        }
    }
}