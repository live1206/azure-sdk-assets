// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Savings plan utilization. </summary>
    public partial class BillingBenefitsSavingsPlanUtilization
    {
        /// <summary> Initializes a new instance of BillingBenefitsSavingsPlanUtilization. </summary>
        internal BillingBenefitsSavingsPlanUtilization()
        {
            Aggregates = new ChangeTrackingList<BillingBenefitsSavingsPlanUtilizationAggregate>();
        }

        /// <summary> Initializes a new instance of BillingBenefitsSavingsPlanUtilization. </summary>
        /// <param name="trend"> The number of days trend for a savings plan. </param>
        /// <param name="aggregates"> The array of aggregates of a savings plan's utilization. </param>
        internal BillingBenefitsSavingsPlanUtilization(string trend, IReadOnlyList<BillingBenefitsSavingsPlanUtilizationAggregate> aggregates)
        {
            Trend = trend;
            Aggregates = aggregates;
        }

        /// <summary> The number of days trend for a savings plan. </summary>
        public string Trend { get; }
        /// <summary> The array of aggregates of a savings plan's utilization. </summary>
        public IReadOnlyList<BillingBenefitsSavingsPlanUtilizationAggregate> Aggregates { get; }
    }
}