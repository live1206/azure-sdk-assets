// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    internal partial class MySqlFirewallRuleListResult
    {
        internal static MySqlFirewallRuleListResult DeserializeMySqlFirewallRuleListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MySqlFirewallRuleData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFirewallRuleData> array = new List<MySqlFirewallRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFirewallRuleData.DeserializeMySqlFirewallRuleData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MySqlFirewallRuleListResult(Optional.ToList(value));
        }
    }
}