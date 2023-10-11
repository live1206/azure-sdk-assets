// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Location information. </summary>
    public partial class LocationExpanded
    {
        /// <summary> Initializes a new instance of LocationExpanded. </summary>
        internal LocationExpanded()
        {
            AvailabilityZoneMappings = new ChangeTrackingList<AvailabilityZoneMappings>();
        }

        /// <summary> The fully qualified ID of the location. For example, /subscriptions/8d65815f-a5b6-402f-9298-045155da7d74/locations/westus. </summary>
        public string Id { get; }
        /// <summary> The subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> The location name. </summary>
        public string Name { get; }
        /// <summary> The location type. </summary>
        public LocationType? LocationType { get; }
        /// <summary> The display name of the location. </summary>
        public string DisplayName { get; }
        /// <summary> The display name of the location and its region. </summary>
        public string RegionalDisplayName { get; }
        /// <summary> Metadata of the location, such as lat/long, paired region, and others. </summary>
        public LocationMetadata Metadata { get; }
        /// <summary> The availability zone mappings for this region. </summary>
        public IReadOnlyList<AvailabilityZoneMappings> AvailabilityZoneMappings { get; }
    }
}