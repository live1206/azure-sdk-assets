// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PlanNotificationDetails
    {
        internal static PlanNotificationDetails DeserializePlanNotificationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> planId = default;
            Optional<string> planDisplayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"u8))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
            }
            return new PlanNotificationDetails(planId.Value, planDisplayName.Value);
        }
    }
}