// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryBaseImageDependency
    {
        internal static ContainerRegistryBaseImageDependency DeserializeContainerRegistryBaseImageDependency(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerRegistryBaseImageDependencyType> type = default;
            Optional<string> registry = default;
            Optional<string> repository = default;
            Optional<string> tag = default;
            Optional<string> digest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ContainerRegistryBaseImageDependencyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registry"u8))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repository"u8))
                {
                    repository = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryBaseImageDependency(Optional.ToNullable(type), registry.Value, repository.Value, tag.Value, digest.Value);
        }
    }
}