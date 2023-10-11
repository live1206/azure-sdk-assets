// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class DataPolicyManifestData
    {
        internal static DataPolicyManifestData DeserializeDataPolicyManifestData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<string>> namespaces = default;
            Optional<string> policyMode = default;
            Optional<bool> isBuiltInOnly = default;
            Optional<IReadOnlyList<ResourceTypeAliases>> resourceTypeAliases = default;
            Optional<IReadOnlyList<DataPolicyManifestEffect>> effects = default;
            Optional<IReadOnlyList<string>> fieldValues = default;
            Optional<IReadOnlyList<string>> standard = default;
            Optional<IReadOnlyList<DataManifestCustomResourceFunctionDefinition>> custom = default;
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
                        if (property0.NameEquals("namespaces"u8))
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
                            namespaces = array;
                            continue;
                        }
                        if (property0.NameEquals("policyMode"u8))
                        {
                            policyMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isBuiltInOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isBuiltInOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("resourceTypeAliases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceTypeAliases> array = new List<ResourceTypeAliases>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ResourceTypeAliases.DeserializeResourceTypeAliases(item));
                            }
                            resourceTypeAliases = array;
                            continue;
                        }
                        if (property0.NameEquals("effects"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataPolicyManifestEffect> array = new List<DataPolicyManifestEffect>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataPolicyManifestEffect.DeserializeDataPolicyManifestEffect(item));
                            }
                            effects = array;
                            continue;
                        }
                        if (property0.NameEquals("fieldValues"u8))
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
                            fieldValues = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceFunctions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("standard"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<string> array = new List<string>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(item.GetString());
                                    }
                                    standard = array;
                                    continue;
                                }
                                if (property1.NameEquals("custom"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<DataManifestCustomResourceFunctionDefinition> array = new List<DataManifestCustomResourceFunctionDefinition>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(DataManifestCustomResourceFunctionDefinition.DeserializeDataManifestCustomResourceFunctionDefinition(item));
                                    }
                                    custom = array;
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataPolicyManifestData(id, name, type, systemData.Value, Optional.ToList(namespaces), policyMode.Value, Optional.ToNullable(isBuiltInOnly), Optional.ToList(resourceTypeAliases), Optional.ToList(effects), Optional.ToList(fieldValues), Optional.ToList(standard), Optional.ToList(custom));
        }
    }
}