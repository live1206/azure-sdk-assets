// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SqlVirtualMachine;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    internal partial class AvailabilityGroupListenerListResult
    {
        internal static AvailabilityGroupListenerListResult DeserializeAvailabilityGroupListenerListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AvailabilityGroupListenerData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailabilityGroupListenerData> array = new List<AvailabilityGroupListenerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(item));
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
            return new AvailabilityGroupListenerListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}