// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> An annotation describing a change in the availabilityState to Available from Unavailable with a reasonType of type Unplanned. </summary>
    public partial class ResourceHealthAvailabilityStateRecentlyResolved
    {
        /// <summary> Initializes a new instance of ResourceHealthAvailabilityStateRecentlyResolved. </summary>
        internal ResourceHealthAvailabilityStateRecentlyResolved()
        {
        }

        /// <summary> Initializes a new instance of ResourceHealthAvailabilityStateRecentlyResolved. </summary>
        /// <param name="unavailableOccuredOn"> Timestamp for when the availabilityState changed to Unavailable. </param>
        /// <param name="resolvedOn"> Timestamp when the availabilityState changes to Available. </param>
        /// <param name="unavailableSummary"> Brief description of cause of the resource becoming unavailable. </param>
        internal ResourceHealthAvailabilityStateRecentlyResolved(DateTimeOffset? unavailableOccuredOn, DateTimeOffset? resolvedOn, string unavailableSummary)
        {
            UnavailableOccuredOn = unavailableOccuredOn;
            ResolvedOn = resolvedOn;
            UnavailableSummary = unavailableSummary;
        }

        /// <summary> Timestamp for when the availabilityState changed to Unavailable. </summary>
        public DateTimeOffset? UnavailableOccuredOn { get; }
        /// <summary> Timestamp when the availabilityState changes to Available. </summary>
        public DateTimeOffset? ResolvedOn { get; }
        /// <summary> Brief description of cause of the resource becoming unavailable. </summary>
        public string UnavailableSummary { get; }
    }
}
