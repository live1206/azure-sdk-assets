// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal static partial class ElasticSanVirtualNetworkRuleStateExtensions
    {
        public static string ToSerialString(this ElasticSanVirtualNetworkRuleState value) => value switch
        {
            ElasticSanVirtualNetworkRuleState.Provisioning => "provisioning",
            ElasticSanVirtualNetworkRuleState.Deprovisioning => "deprovisioning",
            ElasticSanVirtualNetworkRuleState.Succeeded => "succeeded",
            ElasticSanVirtualNetworkRuleState.Failed => "failed",
            ElasticSanVirtualNetworkRuleState.NetworkSourceDeleted => "networkSourceDeleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ElasticSanVirtualNetworkRuleState value.")
        };

        public static ElasticSanVirtualNetworkRuleState ToElasticSanVirtualNetworkRuleState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "provisioning")) return ElasticSanVirtualNetworkRuleState.Provisioning;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "deprovisioning")) return ElasticSanVirtualNetworkRuleState.Deprovisioning;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "succeeded")) return ElasticSanVirtualNetworkRuleState.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "failed")) return ElasticSanVirtualNetworkRuleState.Failed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "networkSourceDeleted")) return ElasticSanVirtualNetworkRuleState.NetworkSourceDeleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ElasticSanVirtualNetworkRuleState value.");
        }
    }
}