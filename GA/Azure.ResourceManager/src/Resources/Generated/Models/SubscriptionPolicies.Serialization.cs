// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class SubscriptionPolicies
    {
        internal static SubscriptionPolicies DeserializeSubscriptionPolicies(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> locationPlacementId = default;
            Optional<string> quotaId = default;
            Optional<SpendingLimit> spendingLimit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locationPlacementId"u8))
                {
                    locationPlacementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaId"u8))
                {
                    quotaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("spendingLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spendingLimit = property.Value.GetString().ToSpendingLimit();
                    continue;
                }
            }
            return new SubscriptionPolicies(locationPlacementId.Value, quotaId.Value, Optional.ToNullable(spendingLimit));
        }
    }
}