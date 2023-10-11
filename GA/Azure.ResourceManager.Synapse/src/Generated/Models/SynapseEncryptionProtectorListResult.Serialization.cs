// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseEncryptionProtectorListResult
    {
        internal static SynapseEncryptionProtectorListResult DeserializeSynapseEncryptionProtectorListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseEncryptionProtectorData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseEncryptionProtectorData> array = new List<SynapseEncryptionProtectorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseEncryptionProtectorData.DeserializeSynapseEncryptionProtectorData(item));
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
            return new SynapseEncryptionProtectorListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}