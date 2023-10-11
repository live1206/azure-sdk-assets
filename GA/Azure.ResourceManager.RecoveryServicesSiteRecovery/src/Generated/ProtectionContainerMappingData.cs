// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the ProtectionContainerMapping data model.
    /// Protection container mapping object.
    /// </summary>
    public partial class ProtectionContainerMappingData : ResourceData
    {
        /// <summary> Initializes a new instance of ProtectionContainerMappingData. </summary>
        internal ProtectionContainerMappingData()
        {
        }

        /// <summary> Initializes a new instance of ProtectionContainerMappingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The custom data. </param>
        /// <param name="location"> Resource Location. </param>
        internal ProtectionContainerMappingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProtectionContainerMappingProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> The custom data. </summary>
        public ProtectionContainerMappingProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}