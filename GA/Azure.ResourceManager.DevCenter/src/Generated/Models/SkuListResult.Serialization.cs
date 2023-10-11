// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal partial class SkuListResult
    {
        internal static SkuListResult DeserializeSkuListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DevCenterSkuDetails>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevCenterSkuDetails> array = new List<DevCenterSkuDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevCenterSkuDetails.DeserializeDevCenterSkuDetails(item));
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
            return new SkuListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}