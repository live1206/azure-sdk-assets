// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterPoolUpgradeProfile
    {
        internal static ManagedClusterPoolUpgradeProfile DeserializeManagedClusterPoolUpgradeProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kubernetesVersion = default;
            Optional<string> name = default;
            ContainerServiceOSType osType = default;
            Optional<IReadOnlyList<ManagedClusterPoolUpgradeProfileUpgradesItem>> upgrades = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new ContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("upgrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedClusterPoolUpgradeProfileUpgradesItem> array = new List<ManagedClusterPoolUpgradeProfileUpgradesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedClusterPoolUpgradeProfileUpgradesItem.DeserializeManagedClusterPoolUpgradeProfileUpgradesItem(item));
                    }
                    upgrades = array;
                    continue;
                }
            }
            return new ManagedClusterPoolUpgradeProfile(kubernetesVersion, name.Value, osType, Optional.ToList(upgrades));
        }
    }
}