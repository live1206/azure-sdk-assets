// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class AcceptOwnershipStatus
    {
        internal static AcceptOwnershipStatus DeserializeAcceptOwnershipStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subscriptionId = default;
            Optional<AcceptOwnershipState> acceptOwnershipState = default;
            Optional<AcceptOwnershipProvisioningState> provisioningState = default;
            Optional<string> billingOwner = default;
            Optional<Guid> subscriptionTenantId = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceptOwnershipState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceptOwnershipState = new AcceptOwnershipState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AcceptOwnershipProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingOwner"u8))
                {
                    billingOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new AcceptOwnershipStatus(subscriptionId.Value, Optional.ToNullable(acceptOwnershipState), Optional.ToNullable(provisioningState), billingOwner.Value, Optional.ToNullable(subscriptionTenantId), displayName.Value, Optional.ToDictionary(tags));
        }
    }
}