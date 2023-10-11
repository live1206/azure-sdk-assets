// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseSsisObjectMetadataListResult
    {
        internal static SynapseSsisObjectMetadataListResult DeserializeSynapseSsisObjectMetadataListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseSsisObjectMetadata>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSsisObjectMetadata> array = new List<SynapseSsisObjectMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisObjectMetadata.DeserializeSynapseSsisObjectMetadata(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseSsisObjectMetadataListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}