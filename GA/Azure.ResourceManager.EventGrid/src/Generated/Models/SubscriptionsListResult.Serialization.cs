// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class SubscriptionsListResult
    {
        internal static SubscriptionsListResult DeserializeSubscriptionsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NamespaceTopicEventSubscriptionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NamespaceTopicEventSubscriptionData> array = new List<NamespaceTopicEventSubscriptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NamespaceTopicEventSubscriptionData.DeserializeNamespaceTopicEventSubscriptionData(item));
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
            return new SubscriptionsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}