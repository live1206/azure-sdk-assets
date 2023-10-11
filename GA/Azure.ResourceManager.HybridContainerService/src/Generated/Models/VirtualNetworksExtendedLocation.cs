// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The VirtualNetworksExtendedLocation. </summary>
    public partial class VirtualNetworksExtendedLocation
    {
        /// <summary> Initializes a new instance of VirtualNetworksExtendedLocation. </summary>
        public VirtualNetworksExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworksExtendedLocation. </summary>
        /// <param name="virtualNetworksExtendedLocationType"> The extended location type. </param>
        /// <param name="name"> The extended location name. </param>
        internal VirtualNetworksExtendedLocation(string virtualNetworksExtendedLocationType, string name)
        {
            VirtualNetworksExtendedLocationType = virtualNetworksExtendedLocationType;
            Name = name;
        }

        /// <summary> The extended location type. </summary>
        public string VirtualNetworksExtendedLocationType { get; set; }
        /// <summary> The extended location name. </summary>
        public string Name { get; set; }
    }
}