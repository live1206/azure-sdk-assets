// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationKey
    {
        internal static AutomationKey DeserializeAutomationKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationKeyName> keyName = default;
            Optional<AutomationKeyPermission> permissions = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("KeyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyName = new AutomationKeyName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Permissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    permissions = new AutomationKeyPermission(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new AutomationKey(Optional.ToNullable(keyName), Optional.ToNullable(permissions), value.Value);
        }
    }
}