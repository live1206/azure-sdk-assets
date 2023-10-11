// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class QuotaUsagesObject
    {
        internal static QuotaUsagesObject DeserializeQuotaUsagesObject(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            Optional<QuotaUsagesType> usagesType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usagesType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usagesType = new QuotaUsagesType(property.Value.GetString());
                    continue;
                }
            }
            return new QuotaUsagesObject(value, Optional.ToNullable(usagesType));
        }
    }
}