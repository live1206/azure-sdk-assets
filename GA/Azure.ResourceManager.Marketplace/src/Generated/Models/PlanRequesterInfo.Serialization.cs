// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PlanRequesterInfo
    {
        internal static PlanRequesterInfo DeserializePlanRequesterInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> user = default;
            Optional<string> date = default;
            Optional<string> justification = default;
            Optional<string> subscriptionId = default;
            Optional<string> subscriptionName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("date"u8))
                {
                    date = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
            }
            return new PlanRequesterInfo(user.Value, date.Value, justification.Value, subscriptionId.Value, subscriptionName.Value);
        }
    }
}