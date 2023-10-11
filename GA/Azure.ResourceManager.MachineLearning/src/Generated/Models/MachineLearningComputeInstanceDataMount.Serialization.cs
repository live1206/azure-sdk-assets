// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceDataMount
    {
        internal static MachineLearningComputeInstanceDataMount DeserializeMachineLearningComputeInstanceDataMount(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> source = default;
            Optional<MachineLearningSourceType> sourceType = default;
            Optional<string> mountName = default;
            Optional<MachineLearningMountAction> mountAction = default;
            Optional<string> createdBy = default;
            Optional<string> mountPath = default;
            Optional<MachineLearningMountState> mountState = default;
            Optional<DateTimeOffset> mountedOn = default;
            Optional<string> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceType = new MachineLearningSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountName"u8))
                {
                    mountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountAction = new MachineLearningMountAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountState = new MachineLearningMountState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningComputeInstanceDataMount(source.Value, Optional.ToNullable(sourceType), mountName.Value, Optional.ToNullable(mountAction), createdBy.Value, mountPath.Value, Optional.ToNullable(mountState), Optional.ToNullable(mountedOn), error.Value);
        }
    }
}