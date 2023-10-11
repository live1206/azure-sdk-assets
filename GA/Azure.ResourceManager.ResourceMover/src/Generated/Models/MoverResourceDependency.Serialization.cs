// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceDependency
    {
        internal static MoverResourceDependency DeserializeMoverResourceDependency(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> resolutionStatus = default;
            Optional<MoverResourceResolutionType> resolutionType = default;
            Optional<MoverDependencyType> dependencyType = default;
            Optional<ManualResolutionProperties> manualResolution = default;
            Optional<AutomaticResolutionProperties> automaticResolution = default;
            Optional<bool> isOptional = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolutionStatus"u8))
                {
                    resolutionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolutionType = new MoverResourceResolutionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependencyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependencyType = new MoverDependencyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manualResolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manualResolution = ManualResolutionProperties.DeserializeManualResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("automaticResolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticResolution = AutomaticResolutionProperties.DeserializeAutomaticResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("isOptional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MoverResourceDependency(id.Value, resolutionStatus.Value, Optional.ToNullable(resolutionType), Optional.ToNullable(dependencyType), manualResolution.Value, automaticResolution.Value, Optional.ToNullable(isOptional));
        }
    }
}