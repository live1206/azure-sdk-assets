// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class SoftwareUpdateConfigurationMachineRunListResult
    {
        internal static SoftwareUpdateConfigurationMachineRunListResult DeserializeSoftwareUpdateConfigurationMachineRunListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SoftwareUpdateConfigurationMachineRun>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SoftwareUpdateConfigurationMachineRun> array = new List<SoftwareUpdateConfigurationMachineRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SoftwareUpdateConfigurationMachineRun.DeserializeSoftwareUpdateConfigurationMachineRun(item));
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
            return new SoftwareUpdateConfigurationMachineRunListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
