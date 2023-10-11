// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class AutomationModuleFieldListResult
    {
        internal static AutomationModuleFieldListResult DeserializeAutomationModuleFieldListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AutomationModuleField>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationModuleField> array = new List<AutomationModuleField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationModuleField.DeserializeAutomationModuleField(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AutomationModuleFieldListResult(Optional.ToList(value));
        }
    }
}