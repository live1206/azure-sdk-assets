// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisEnvironment
    {
        internal static SynapseSsisEnvironment DeserializeSynapseSsisEnvironment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> folderId = default;
            Optional<IReadOnlyList<SynapseSsisVariable>> variables = default;
            SynapseSsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("variables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSsisVariable> array = new List<SynapseSsisVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisVariable.DeserializeSynapseSsisVariable(item));
                    }
                    variables = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SynapseSsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseSsisEnvironment(type, Optional.ToNullable(id), name.Value, description.Value, Optional.ToNullable(folderId), Optional.ToList(variables));
        }
    }
}