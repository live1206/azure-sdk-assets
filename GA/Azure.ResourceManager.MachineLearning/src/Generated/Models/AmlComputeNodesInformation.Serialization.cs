// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class AmlComputeNodesInformation
    {
        internal static AmlComputeNodesInformation DeserializeAmlComputeNodesInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AmlComputeNodeInformation>> nodes = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AmlComputeNodeInformation> array = new List<AmlComputeNodeInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AmlComputeNodeInformation.DeserializeAmlComputeNodeInformation(item));
                    }
                    nodes = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AmlComputeNodesInformation(Optional.ToList(nodes), nextLink.Value);
        }
    }
}