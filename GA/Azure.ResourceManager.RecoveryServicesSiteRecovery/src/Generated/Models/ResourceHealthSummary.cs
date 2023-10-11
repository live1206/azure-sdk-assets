// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Base class to define the health summary of the resources contained under an Arm resource. </summary>
    public partial class ResourceHealthSummary
    {
        /// <summary> Initializes a new instance of ResourceHealthSummary. </summary>
        internal ResourceHealthSummary()
        {
            Issues = new ChangeTrackingList<HealthErrorSummary>();
            CategorizedResourceCounts = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of ResourceHealthSummary. </summary>
        /// <param name="resourceCount"> The count of total resources under the container. </param>
        /// <param name="issues"> The list of summary of health errors across the resources under the container. </param>
        /// <param name="categorizedResourceCounts"> The categorized resource counts. </param>
        internal ResourceHealthSummary(int? resourceCount, IReadOnlyList<HealthErrorSummary> issues, IReadOnlyDictionary<string, int> categorizedResourceCounts)
        {
            ResourceCount = resourceCount;
            Issues = issues;
            CategorizedResourceCounts = categorizedResourceCounts;
        }

        /// <summary> The count of total resources under the container. </summary>
        public int? ResourceCount { get; }
        /// <summary> The list of summary of health errors across the resources under the container. </summary>
        public IReadOnlyList<HealthErrorSummary> Issues { get; }
        /// <summary> The categorized resource counts. </summary>
        public IReadOnlyDictionary<string, int> CategorizedResourceCounts { get; }
    }
}