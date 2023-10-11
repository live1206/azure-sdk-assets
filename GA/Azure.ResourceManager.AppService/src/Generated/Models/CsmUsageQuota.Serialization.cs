// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CsmUsageQuota
    {
        internal static CsmUsageQuota DeserializeCsmUsageQuota(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> unit = default;
            Optional<DateTimeOffset> nextResetTime = default;
            Optional<long> currentValue = default;
            Optional<long> limit = default;
            Optional<LocalizableString> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextResetTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = LocalizableString.DeserializeLocalizableString(property.Value);
                    continue;
                }
            }
            return new CsmUsageQuota(unit.Value, Optional.ToNullable(nextResetTime), Optional.ToNullable(currentValue), Optional.ToNullable(limit), name.Value);
        }
    }
}