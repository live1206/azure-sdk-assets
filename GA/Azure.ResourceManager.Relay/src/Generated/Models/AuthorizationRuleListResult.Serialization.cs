// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    internal partial class AuthorizationRuleListResult
    {
        internal static AuthorizationRuleListResult DeserializeAuthorizationRuleListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RelayAuthorizationRuleData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RelayAuthorizationRuleData> array = new List<RelayAuthorizationRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RelayAuthorizationRuleData.DeserializeRelayAuthorizationRuleData(item));
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
            return new AuthorizationRuleListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}