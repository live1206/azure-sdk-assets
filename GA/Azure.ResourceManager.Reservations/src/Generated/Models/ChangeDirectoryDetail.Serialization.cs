// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ChangeDirectoryDetail
    {
        internal static ChangeDirectoryDetail DeserializeChangeDirectoryDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ChangeDirectoryResult> reservationOrder = default;
            Optional<IReadOnlyList<ChangeDirectoryResult>> reservations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservationOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationOrder = ChangeDirectoryResult.DeserializeChangeDirectoryResult(property.Value);
                    continue;
                }
                if (property.NameEquals("reservations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChangeDirectoryResult> array = new List<ChangeDirectoryResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChangeDirectoryResult.DeserializeChangeDirectoryResult(item));
                    }
                    reservations = array;
                    continue;
                }
            }
            return new ChangeDirectoryDetail(reservationOrder.Value, Optional.ToList(reservations));
        }
    }
}