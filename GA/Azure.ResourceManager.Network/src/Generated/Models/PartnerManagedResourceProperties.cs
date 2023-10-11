// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of the partner managed resource. </summary>
    public partial class PartnerManagedResourceProperties
    {
        /// <summary> Initializes a new instance of PartnerManagedResourceProperties. </summary>
        public PartnerManagedResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of PartnerManagedResourceProperties. </summary>
        /// <param name="id"> The partner managed resource id. </param>
        /// <param name="internalLoadBalancerId"> The partner managed ILB resource id. </param>
        /// <param name="standardLoadBalancerId"> The partner managed SLB resource id. </param>
        internal PartnerManagedResourceProperties(ResourceIdentifier id, ResourceIdentifier internalLoadBalancerId, ResourceIdentifier standardLoadBalancerId)
        {
            Id = id;
            InternalLoadBalancerId = internalLoadBalancerId;
            StandardLoadBalancerId = standardLoadBalancerId;
        }

        /// <summary> The partner managed resource id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The partner managed ILB resource id. </summary>
        public ResourceIdentifier InternalLoadBalancerId { get; }
        /// <summary> The partner managed SLB resource id. </summary>
        public ResourceIdentifier StandardLoadBalancerId { get; }
    }
}