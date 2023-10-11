// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    internal partial class GlobalRulestackListResult
    {
        internal static GlobalRulestackListResult DeserializeGlobalRulestackListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<GlobalRulestackData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<GlobalRulestackData> array = new List<GlobalRulestackData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GlobalRulestackData.DeserializeGlobalRulestackData(item));
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
            return new GlobalRulestackListResult(value, nextLink.Value);
        }
    }
}