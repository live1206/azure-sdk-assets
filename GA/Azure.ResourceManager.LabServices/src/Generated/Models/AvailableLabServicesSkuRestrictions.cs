// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The restriction details. </summary>
    public partial class AvailableLabServicesSkuRestrictions
    {
        /// <summary> Initializes a new instance of AvailableLabServicesSkuRestrictions. </summary>
        internal AvailableLabServicesSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AvailableLabServicesSkuRestrictions. </summary>
        /// <param name="labServicesSkuRestrictionType"> The type of restriction. </param>
        /// <param name="values"> The values of the restriction. </param>
        /// <param name="reasonCode"> The reason for the restriction. </param>
        internal AvailableLabServicesSkuRestrictions(LabServicesSkuRestrictionType? labServicesSkuRestrictionType, IReadOnlyList<string> values, LabServicesSkuRestrictionReasonCode? reasonCode)
        {
            LabServicesSkuRestrictionType = labServicesSkuRestrictionType;
            Values = values;
            ReasonCode = reasonCode;
        }

        /// <summary> The type of restriction. </summary>
        public LabServicesSkuRestrictionType? LabServicesSkuRestrictionType { get; }
        /// <summary> The values of the restriction. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The reason for the restriction. </summary>
        public LabServicesSkuRestrictionReasonCode? ReasonCode { get; }
    }
}