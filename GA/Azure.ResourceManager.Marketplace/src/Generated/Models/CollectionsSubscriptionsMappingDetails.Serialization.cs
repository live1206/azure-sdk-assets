// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class CollectionsSubscriptionsMappingDetails
    {
        internal static CollectionsSubscriptionsMappingDetails DeserializeCollectionsSubscriptionsMappingDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> collectionName = default;
            Optional<IReadOnlyList<string>> subscriptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collectionName"u8))
                {
                    collectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
            }
            return new CollectionsSubscriptionsMappingDetails(collectionName.Value, Optional.ToList(subscriptions));
        }
    }
}
