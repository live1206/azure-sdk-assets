// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Maintenance;

namespace Azure.ResourceManager.Maintenance.Models
{
    internal partial class MaintenanceConfigurationListResult
    {
        internal static MaintenanceConfigurationListResult DeserializeMaintenanceConfigurationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MaintenanceConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceConfigurationData> array = new List<MaintenanceConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceConfigurationData.DeserializeMaintenanceConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MaintenanceConfigurationListResult(Optional.ToList(value));
        }
    }
}