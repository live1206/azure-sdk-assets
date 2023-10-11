// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class AvailabilityZoneMapping
    {
        internal static AvailabilityZoneMapping DeserializeAvailabilityZoneMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> availabilityZone = default;
            Optional<bool> isAvailable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityZone"u8))
                {
                    availabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAvailable = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AvailabilityZoneMapping(availabilityZone.Value, Optional.ToNullable(isAvailable));
        }
    }
}