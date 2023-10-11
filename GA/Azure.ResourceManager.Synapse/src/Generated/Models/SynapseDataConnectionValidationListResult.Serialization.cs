// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataConnectionValidationListResult
    {
        internal static SynapseDataConnectionValidationListResult DeserializeSynapseDataConnectionValidationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseDataConnectionValidationResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseDataConnectionValidationResult> array = new List<SynapseDataConnectionValidationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseDataConnectionValidationResult.DeserializeSynapseDataConnectionValidationResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SynapseDataConnectionValidationListResult(Optional.ToList(value));
        }
    }
}