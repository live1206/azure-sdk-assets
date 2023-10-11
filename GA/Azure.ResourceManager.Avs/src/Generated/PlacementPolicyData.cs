// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the PlacementPolicy data model.
    /// A vSphere Distributed Resource Scheduler (DRS) placement policy
    /// </summary>
    public partial class PlacementPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of PlacementPolicyData. </summary>
        public PlacementPolicyData()
        {
        }

        /// <summary> Initializes a new instance of PlacementPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// placement policy properties
        /// Please note <see cref="PlacementPolicyProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VmHostPlacementPolicyProperties"/> and <see cref="VmPlacementPolicyProperties"/>.
        /// </param>
        internal PlacementPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PlacementPolicyProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// placement policy properties
        /// Please note <see cref="PlacementPolicyProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VmHostPlacementPolicyProperties"/> and <see cref="VmPlacementPolicyProperties"/>.
        /// </summary>
        public PlacementPolicyProperties Properties { get; set; }
    }
}
