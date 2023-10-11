// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> Class for CheckServiceProviderAvailabilityInput. </summary>
    public partial class CheckPeeringServiceProviderAvailabilityContent
    {
        /// <summary> Initializes a new instance of CheckPeeringServiceProviderAvailabilityContent. </summary>
        public CheckPeeringServiceProviderAvailabilityContent()
        {
        }

        /// <summary> Gets or sets the peering service location. </summary>
        public string PeeringServiceLocation { get; set; }
        /// <summary> Gets or sets the peering service provider. </summary>
        public string PeeringServiceProvider { get; set; }
    }
}