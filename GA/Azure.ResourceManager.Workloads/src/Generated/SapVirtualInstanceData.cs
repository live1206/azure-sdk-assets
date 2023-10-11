// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing the SapVirtualInstance data model.
    /// Define the Virtual Instance for SAP solutions resource.
    /// </summary>
    public partial class SapVirtualInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SapVirtualInstanceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="environment"> Defines the environment type - Production/Non Production. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="configuration">
        /// Defines if the SAP system is being created using Azure Center for SAP solutions (ACSS) or if an existing SAP system is being registered with ACSS
        /// Please note <see cref="SapConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeploymentConfiguration"/>, <see cref="DeploymentWithOSConfiguration"/> and <see cref="DiscoveryConfiguration"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configuration"/> is null. </exception>
        public SapVirtualInstanceData(AzureLocation location, SapEnvironmentType environment, SapProductType sapProduct, SapConfiguration configuration) : base(location)
        {
            Argument.AssertNotNull(configuration, nameof(configuration));

            Environment = environment;
            SapProduct = sapProduct;
            Configuration = configuration;
        }

        /// <summary> Initializes a new instance of SapVirtualInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> A pre-created user assigned identity with appropriate roles assigned. To learn more on identity and roles required, visit the ACSS how-to-guide. </param>
        /// <param name="environment"> Defines the environment type - Production/Non Production. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="configuration">
        /// Defines if the SAP system is being created using Azure Center for SAP solutions (ACSS) or if an existing SAP system is being registered with ACSS
        /// Please note <see cref="SapConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeploymentConfiguration"/>, <see cref="DeploymentWithOSConfiguration"/> and <see cref="DiscoveryConfiguration"/>.
        /// </param>
        /// <param name="managedResourceGroupConfiguration"> Managed resource group configuration. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="state"> Defines the Virtual Instance for SAP state. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Indicates any errors on the Virtual Instance for SAP solutions resource. </param>
        internal SapVirtualInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, UserAssignedServiceIdentity identity, SapEnvironmentType environment, SapProductType sapProduct, SapConfiguration configuration, ManagedRGConfiguration managedResourceGroupConfiguration, SapVirtualInstanceStatus? status, SapHealthState? health, SapVirtualInstanceState? state, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Environment = environment;
            SapProduct = sapProduct;
            Configuration = configuration;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            Status = status;
            Health = health;
            State = state;
            ProvisioningState = provisioningState;
            Errors = errors;
        }

        /// <summary> A pre-created user assigned identity with appropriate roles assigned. To learn more on identity and roles required, visit the ACSS how-to-guide. </summary>
        public UserAssignedServiceIdentity Identity { get; set; }
        /// <summary> Defines the environment type - Production/Non Production. </summary>
        public SapEnvironmentType Environment { get; set; }
        /// <summary> Defines the SAP Product type. </summary>
        public SapProductType SapProduct { get; set; }
        /// <summary>
        /// Defines if the SAP system is being created using Azure Center for SAP solutions (ACSS) or if an existing SAP system is being registered with ACSS
        /// Please note <see cref="SapConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeploymentConfiguration"/>, <see cref="DeploymentWithOSConfiguration"/> and <see cref="DiscoveryConfiguration"/>.
        /// </summary>
        public SapConfiguration Configuration { get; set; }
        /// <summary> Managed resource group configuration. </summary>
        internal ManagedRGConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> Managed resource group name. </summary>
        public string ManagedResourceGroupName
        {
            get => ManagedResourceGroupConfiguration is null ? default : ManagedResourceGroupConfiguration.Name;
            set
            {
                if (ManagedResourceGroupConfiguration is null)
                    ManagedResourceGroupConfiguration = new ManagedRGConfiguration();
                ManagedResourceGroupConfiguration.Name = value;
            }
        }

        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
        /// <summary> Defines the Virtual Instance for SAP state. </summary>
        public SapVirtualInstanceState? State { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates any errors on the Virtual Instance for SAP solutions resource. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}