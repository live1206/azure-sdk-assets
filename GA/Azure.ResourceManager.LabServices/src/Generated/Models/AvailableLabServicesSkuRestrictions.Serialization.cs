// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSkuRestrictions
    {
        internal static AvailableLabServicesSkuRestrictions DeserializeAvailableLabServicesSkuRestrictions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LabServicesSkuRestrictionType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<LabServicesSkuRestrictionReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new LabServicesSkuRestrictionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = new LabServicesSkuRestrictionReasonCode(property.Value.GetString());
                    continue;
                }
            }
            return new AvailableLabServicesSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), Optional.ToNullable(reasonCode));
        }
    }
}
