// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FluidRelay.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FluidRelay
{
    /// <summary>
    /// A class representing the FluidRelayServer data model.
    /// A FluidRelay Server.
    /// </summary>
    public partial class FluidRelayServerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of FluidRelayServerData. </summary>
        /// <param name="location"> The location. </param>
        public FluidRelayServerData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FluidRelayServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="frsTenantId"> The Fluid tenantId for this server. </param>
        /// <param name="fluidRelayEndpoints"> The Fluid Relay Service endpoints for this server. </param>
        /// <param name="provisioningState"> Provision states for FluidRelay RP. </param>
        /// <param name="encryption"> All encryption configuration for a resource. </param>
        /// <param name="storageSku"> Sku of the storage associated with the resource. </param>
        internal FluidRelayServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, Guid? frsTenantId, FluidRelayEndpoints fluidRelayEndpoints, FluidRelayProvisioningState? provisioningState, Models.EncryptionProperties encryption, FluidRelayStorageSku? storageSku) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            FrsTenantId = frsTenantId;
            FluidRelayEndpoints = fluidRelayEndpoints;
            ProvisioningState = provisioningState;
            Encryption = encryption;
            StorageSku = storageSku;
        }

        /// <summary> The type of identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Fluid tenantId for this server. </summary>
        public Guid? FrsTenantId { get; }
        /// <summary> The Fluid Relay Service endpoints for this server. </summary>
        public FluidRelayEndpoints FluidRelayEndpoints { get; }
        /// <summary> Provision states for FluidRelay RP. </summary>
        public FluidRelayProvisioningState? ProvisioningState { get; set; }
        /// <summary> All encryption configuration for a resource. </summary>
        internal Models.EncryptionProperties Encryption { get; set; }
        /// <summary> All Customer-managed key encryption properties for the resource. </summary>
        public CmkEncryptionProperties CustomerManagedKeyEncryption
        {
            get => Encryption is null ? default : Encryption.CustomerManagedKeyEncryption;
            set
            {
                if (Encryption is null)
                    Encryption = new Models.EncryptionProperties();
                Encryption.CustomerManagedKeyEncryption = value;
            }
        }

        /// <summary> Sku of the storage associated with the resource. </summary>
        public FluidRelayStorageSku? StorageSku { get; set; }
    }
}