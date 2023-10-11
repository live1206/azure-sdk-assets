// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class ResourceOperation
    {
        internal static ResourceOperation DeserializeResourceOperation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceOperationDisplay> display = default;
            Optional<string> origin = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    display = ResourceOperationDisplay.DeserializeResourceOperationDisplay(property.Value);
                    continue;
                }
                if (property.NameEquals("origin"u8))
                {
                    origin = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceOperation(name.Value, display.Value, origin.Value);
        }
    }
}