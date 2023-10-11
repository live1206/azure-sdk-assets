// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ApiManagementSkuRestrictions
    {
        /// <summary> Initializes a new instance of ApiManagementSkuRestrictions. </summary>
        internal ApiManagementSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ApiManagementSkuRestrictions. </summary>
        /// <param name="restrictionsType"> The type of restrictions. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="restrictionInfo"> The information about the restriction where the SKU cannot be used. </param>
        /// <param name="reasonCode"> The reason for restriction. </param>
        internal ApiManagementSkuRestrictions(ApiManagementSkuRestrictionsType? restrictionsType, IReadOnlyList<string> values, ApiManagementSkuRestrictionInfo restrictionInfo, ApiManagementSkuRestrictionsReasonCode? reasonCode)
        {
            RestrictionsType = restrictionsType;
            Values = values;
            RestrictionInfo = restrictionInfo;
            ReasonCode = reasonCode;
        }

        /// <summary> The type of restrictions. </summary>
        public ApiManagementSkuRestrictionsType? RestrictionsType { get; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The information about the restriction where the SKU cannot be used. </summary>
        public ApiManagementSkuRestrictionInfo RestrictionInfo { get; }
        /// <summary> The reason for restriction. </summary>
        public ApiManagementSkuRestrictionsReasonCode? ReasonCode { get; }
    }
}