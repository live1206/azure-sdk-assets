// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class QuotaCounterContract
    {
        internal static QuotaCounterContract DeserializeQuotaCounterContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string counterKey = default;
            string periodKey = default;
            DateTimeOffset periodStartTime = default;
            DateTimeOffset periodEndTime = default;
            Optional<QuotaCounterValueContractProperties> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counterKey"u8))
                {
                    counterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("periodKey"u8))
                {
                    periodKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("periodStartTime"u8))
                {
                    periodStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("periodEndTime"u8))
                {
                    periodEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = QuotaCounterValueContractProperties.DeserializeQuotaCounterValueContractProperties(property.Value);
                    continue;
                }
            }
            return new QuotaCounterContract(counterKey, periodKey, periodStartTime, periodEndTime, value.Value);
        }
    }
}