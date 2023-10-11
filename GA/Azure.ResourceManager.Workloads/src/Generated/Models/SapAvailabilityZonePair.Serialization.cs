// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapAvailabilityZonePair
    {
        internal static SapAvailabilityZonePair DeserializeSapAvailabilityZonePair(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> zoneA = default;
            Optional<long> zoneB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zoneA"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneA = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("zoneB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneB = property.Value.GetInt64();
                    continue;
                }
            }
            return new SapAvailabilityZonePair(Optional.ToNullable(zoneA), Optional.ToNullable(zoneB));
        }
    }
}