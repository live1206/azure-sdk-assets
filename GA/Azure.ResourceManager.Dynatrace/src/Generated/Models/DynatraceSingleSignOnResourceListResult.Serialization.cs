// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Dynatrace;

namespace Azure.ResourceManager.Dynatrace.Models
{
    internal partial class DynatraceSingleSignOnResourceListResult
    {
        internal static DynatraceSingleSignOnResourceListResult DeserializeDynatraceSingleSignOnResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DynatraceSingleSignOnData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DynatraceSingleSignOnData> array = new List<DynatraceSingleSignOnData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DynatraceSingleSignOnData.DeserializeDynatraceSingleSignOnData(item));
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
            return new DynatraceSingleSignOnResourceListResult(value, nextLink.Value);
        }
    }
}