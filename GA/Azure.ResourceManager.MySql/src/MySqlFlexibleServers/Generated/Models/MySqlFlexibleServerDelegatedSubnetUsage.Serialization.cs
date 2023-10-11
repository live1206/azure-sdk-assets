// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerDelegatedSubnetUsage
    {
        internal static MySqlFlexibleServerDelegatedSubnetUsage DeserializeMySqlFlexibleServerDelegatedSubnetUsage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subnetName = default;
            Optional<long> usage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetName"u8))
                {
                    subnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = property.Value.GetInt64();
                    continue;
                }
            }
            return new MySqlFlexibleServerDelegatedSubnetUsage(subnetName.Value, Optional.ToNullable(usage));
        }
    }
}