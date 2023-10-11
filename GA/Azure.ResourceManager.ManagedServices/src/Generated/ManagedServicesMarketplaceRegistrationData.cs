// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagedServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary> A class representing the ManagedServicesMarketplaceRegistration data model. </summary>
    public partial class ManagedServicesMarketplaceRegistrationData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedServicesMarketplaceRegistrationData. </summary>
        internal ManagedServicesMarketplaceRegistrationData()
        {
        }

        /// <summary> Initializes a new instance of ManagedServicesMarketplaceRegistrationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of the marketplace registration definition. </param>
        /// <param name="plan"> The details for the Managed Services offer’s plan in Azure Marketplace. </param>
        internal ManagedServicesMarketplaceRegistrationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServicesMarketplaceRegistrationProperties properties, ManagedServicesPlan plan) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Plan = plan;
        }

        /// <summary> The properties of the marketplace registration definition. </summary>
        public ManagedServicesMarketplaceRegistrationProperties Properties { get; }
        /// <summary> The details for the Managed Services offer’s plan in Azure Marketplace. </summary>
        public ManagedServicesPlan Plan { get; }
    }
}