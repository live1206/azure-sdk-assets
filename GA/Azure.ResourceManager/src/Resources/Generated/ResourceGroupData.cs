// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ResourceGroup data model.
    /// Resource group information.
    /// </summary>
    public partial class ResourceGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ResourceGroupData. </summary>
        /// <param name="location"> The location. </param>
        public ResourceGroupData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ResourceGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource group properties. </param>
        /// <param name="managedBy"> The ID of the resource that manages this resource group. </param>
        internal ResourceGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceGroupProperties properties, string managedBy) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ManagedBy = managedBy;
        }

        /// <summary> The resource group properties. </summary>
        internal ResourceGroupProperties Properties { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ResourceGroupProvisioningState
        {
            get => Properties is null ? default : Properties.ProvisioningState;
        }

        /// <summary> The ID of the resource that manages this resource group. </summary>
        public string ManagedBy { get; set; }
    }
}