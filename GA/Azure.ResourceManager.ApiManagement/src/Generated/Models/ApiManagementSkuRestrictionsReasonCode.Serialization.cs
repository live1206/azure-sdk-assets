// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class ApiManagementSkuRestrictionsReasonCodeExtensions
    {
        public static string ToSerialString(this ApiManagementSkuRestrictionsReasonCode value) => value switch
        {
            ApiManagementSkuRestrictionsReasonCode.QuotaId => "QuotaId",
            ApiManagementSkuRestrictionsReasonCode.NotAvailableForSubscription => "NotAvailableForSubscription",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApiManagementSkuRestrictionsReasonCode value.")
        };

        public static ApiManagementSkuRestrictionsReasonCode ToApiManagementSkuRestrictionsReasonCode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "QuotaId")) return ApiManagementSkuRestrictionsReasonCode.QuotaId;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotAvailableForSubscription")) return ApiManagementSkuRestrictionsReasonCode.NotAvailableForSubscription;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApiManagementSkuRestrictionsReasonCode value.");
        }
    }
}
