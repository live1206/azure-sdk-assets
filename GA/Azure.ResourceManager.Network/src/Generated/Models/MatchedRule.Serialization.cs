// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class MatchedRule
    {
        internal static MatchedRule DeserializeMatchedRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ruleName = default;
            Optional<string> action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleName"u8))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
            }
            return new MatchedRule(ruleName.Value, action.Value);
        }
    }
}