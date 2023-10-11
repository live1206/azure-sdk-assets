// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class AgentPoolUpgradeProfilePropertiesUpgradesItem
    {
        internal static AgentPoolUpgradeProfilePropertiesUpgradesItem DeserializeAgentPoolUpgradeProfilePropertiesUpgradesItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kubernetesVersion = default;
            Optional<bool> isPreview = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AgentPoolUpgradeProfilePropertiesUpgradesItem(kubernetesVersion.Value, Optional.ToNullable(isPreview));
        }
    }
}