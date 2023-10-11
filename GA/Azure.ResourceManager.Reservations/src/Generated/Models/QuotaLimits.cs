// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Quota limits. </summary>
    internal partial class QuotaLimits
    {
        /// <summary> Initializes a new instance of QuotaLimits. </summary>
        internal QuotaLimits()
        {
            Value = new ChangeTrackingList<ReservationQuotaData>();
        }

        /// <summary> Initializes a new instance of QuotaLimits. </summary>
        /// <param name="value"> List of quotas (service limits). </param>
        /// <param name="nextLink"> The URI for fetching the next page of quotas (service limits). When no more pages exist, the value is null. </param>
        internal QuotaLimits(IReadOnlyList<ReservationQuotaData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of quotas (service limits). </summary>
        public IReadOnlyList<ReservationQuotaData> Value { get; }
        /// <summary> The URI for fetching the next page of quotas (service limits). When no more pages exist, the value is null. </summary>
        public string NextLink { get; }
    }
}