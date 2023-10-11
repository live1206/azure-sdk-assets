// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentQuotaStatus
    {
        internal static ApplicationInsightsComponentQuotaStatus DeserializeApplicationInsightsComponentQuotaStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appId = default;
            Optional<bool> shouldBeThrottled = default;
            Optional<string> expirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("AppId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ShouldBeThrottled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldBeThrottled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ExpirationTime"u8))
                {
                    expirationTime = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationInsightsComponentQuotaStatus(appId.Value, Optional.ToNullable(shouldBeThrottled), expirationTime.Value);
        }
    }
}