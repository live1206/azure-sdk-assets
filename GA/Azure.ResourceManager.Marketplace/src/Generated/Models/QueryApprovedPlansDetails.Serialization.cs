// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class QueryApprovedPlansDetails
    {
        internal static QueryApprovedPlansDetails DeserializeQueryApprovedPlansDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> planId = default;
            Optional<IReadOnlyList<string>> subscriptionIds = default;
            Optional<bool> allSubscriptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subscriptionIds = array;
                    continue;
                }
                if (property.NameEquals("allSubscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allSubscriptions = property.Value.GetBoolean();
                    continue;
                }
            }
            return new QueryApprovedPlansDetails(planId.Value, Optional.ToList(subscriptionIds), Optional.ToNullable(allSubscriptions));
        }
    }
}