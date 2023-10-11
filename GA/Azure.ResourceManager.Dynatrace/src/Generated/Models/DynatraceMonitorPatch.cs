// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> The updatable properties of the MonitorResource. </summary>
    public partial class DynatraceMonitorPatch
    {
        /// <summary> Initializes a new instance of DynatraceMonitorPatch. </summary>
        public DynatraceMonitorPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Status of the monitor. </summary>
        public DynatraceMonitoringStatus? MonitoringStatus { get; set; }
        /// <summary> Marketplace subscription status. </summary>
        public DynatraceMonitorMarketplaceSubscriptionStatus? MarketplaceSubscriptionStatus { get; set; }
        /// <summary> Properties of the Dynatrace environment. </summary>
        public DynatraceEnvironmentProperties DynatraceEnvironmentProperties { get; set; }
        /// <summary> User info. </summary>
        public DynatraceMonitorUserInfo UserInfo { get; set; }
        /// <summary> Billing plan information. </summary>
        public DynatraceBillingPlanInfo PlanData { get; set; }
    }
}