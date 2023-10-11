// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkVirtualAppliance data model.
    /// NetworkVirtualAppliance Resource.
    /// </summary>
    public partial class NetworkVirtualApplianceData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkVirtualApplianceData. </summary>
        public NetworkVirtualApplianceData()
        {
            BootStrapConfigurationBlobs = new ChangeTrackingList<string>();
            CloudInitConfigurationBlobs = new ChangeTrackingList<string>();
            VirtualApplianceNics = new ChangeTrackingList<VirtualApplianceNicProperties>();
            AdditionalNics = new ChangeTrackingList<VirtualApplianceAdditionalNicProperties>();
            VirtualApplianceSites = new ChangeTrackingList<WritableSubResource>();
            VirtualApplianceConnections = new ChangeTrackingList<WritableSubResource>();
            InboundSecurityRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of NetworkVirtualApplianceData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The service principal that has read access to cloud-init and config blob. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="nvaSku"> Network Virtual Appliance SKU. </param>
        /// <param name="addressPrefix"> Address Prefix. </param>
        /// <param name="bootStrapConfigurationBlobs"> BootStrapConfigurationBlobs storage URLs. </param>
        /// <param name="virtualHub"> The Virtual Hub where Network Virtual Appliance is being deployed. </param>
        /// <param name="cloudInitConfigurationBlobs"> CloudInitConfigurationBlob storage URLs. </param>
        /// <param name="cloudInitConfiguration"> CloudInitConfiguration string in plain text. </param>
        /// <param name="virtualApplianceAsn"> VirtualAppliance ASN. Microsoft private, public and IANA reserved ASN are not supported. </param>
        /// <param name="sshPublicKey"> Public key for SSH login. </param>
        /// <param name="virtualApplianceNics"> List of Virtual Appliance Network Interfaces. </param>
        /// <param name="additionalNics"> Details required for Additional Network Interface. </param>
        /// <param name="virtualApplianceSites"> List of references to VirtualApplianceSite. </param>
        /// <param name="virtualApplianceConnections"> List of references to VirtualApplianceConnections. </param>
        /// <param name="inboundSecurityRules"> List of references to InboundSecurityRules. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="deploymentType"> The deployment type. PartnerManaged for the SaaS NVA. </param>
        /// <param name="delegation"> The delegation for the Virtual Appliance. </param>
        /// <param name="partnerManagedResource"> The delegation for the Virtual Appliance. </param>
        internal NetworkVirtualApplianceData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ManagedServiceIdentity identity, ETag? etag, VirtualApplianceSkuProperties nvaSku, string addressPrefix, IList<string> bootStrapConfigurationBlobs, WritableSubResource virtualHub, IList<string> cloudInitConfigurationBlobs, string cloudInitConfiguration, long? virtualApplianceAsn, string sshPublicKey, IReadOnlyList<VirtualApplianceNicProperties> virtualApplianceNics, IList<VirtualApplianceAdditionalNicProperties> additionalNics, IReadOnlyList<WritableSubResource> virtualApplianceSites, IReadOnlyList<WritableSubResource> virtualApplianceConnections, IReadOnlyList<WritableSubResource> inboundSecurityRules, NetworkProvisioningState? provisioningState, string deploymentType, VirtualApplianceDelegationProperties delegation, PartnerManagedResourceProperties partnerManagedResource) : base(id, name, resourceType, location, tags)
        {
            Identity = identity;
            ETag = etag;
            NvaSku = nvaSku;
            AddressPrefix = addressPrefix;
            BootStrapConfigurationBlobs = bootStrapConfigurationBlobs;
            VirtualHub = virtualHub;
            CloudInitConfigurationBlobs = cloudInitConfigurationBlobs;
            CloudInitConfiguration = cloudInitConfiguration;
            VirtualApplianceAsn = virtualApplianceAsn;
            SshPublicKey = sshPublicKey;
            VirtualApplianceNics = virtualApplianceNics;
            AdditionalNics = additionalNics;
            VirtualApplianceSites = virtualApplianceSites;
            VirtualApplianceConnections = virtualApplianceConnections;
            InboundSecurityRules = inboundSecurityRules;
            ProvisioningState = provisioningState;
            DeploymentType = deploymentType;
            Delegation = delegation;
            PartnerManagedResource = partnerManagedResource;
        }

        /// <summary> The service principal that has read access to cloud-init and config blob. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Network Virtual Appliance SKU. </summary>
        public VirtualApplianceSkuProperties NvaSku { get; set; }
        /// <summary> Address Prefix. </summary>
        public string AddressPrefix { get; }
        /// <summary> BootStrapConfigurationBlobs storage URLs. </summary>
        public IList<string> BootStrapConfigurationBlobs { get; }
        /// <summary> The Virtual Hub where Network Virtual Appliance is being deployed. </summary>
        internal WritableSubResource VirtualHub { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualHubId
        {
            get => VirtualHub is null ? default : VirtualHub.Id;
            set
            {
                if (VirtualHub is null)
                    VirtualHub = new WritableSubResource();
                VirtualHub.Id = value;
            }
        }

        /// <summary> CloudInitConfigurationBlob storage URLs. </summary>
        public IList<string> CloudInitConfigurationBlobs { get; }
        /// <summary> CloudInitConfiguration string in plain text. </summary>
        public string CloudInitConfiguration { get; set; }
        /// <summary> VirtualAppliance ASN. Microsoft private, public and IANA reserved ASN are not supported. </summary>
        public long? VirtualApplianceAsn { get; set; }
        /// <summary> Public key for SSH login. </summary>
        public string SshPublicKey { get; set; }
        /// <summary> List of Virtual Appliance Network Interfaces. </summary>
        public IReadOnlyList<VirtualApplianceNicProperties> VirtualApplianceNics { get; }
        /// <summary> Details required for Additional Network Interface. </summary>
        public IList<VirtualApplianceAdditionalNicProperties> AdditionalNics { get; }
        /// <summary> List of references to VirtualApplianceSite. </summary>
        public IReadOnlyList<WritableSubResource> VirtualApplianceSites { get; }
        /// <summary> List of references to VirtualApplianceConnections. </summary>
        public IReadOnlyList<WritableSubResource> VirtualApplianceConnections { get; }
        /// <summary> List of references to InboundSecurityRules. </summary>
        public IReadOnlyList<WritableSubResource> InboundSecurityRules { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The deployment type. PartnerManaged for the SaaS NVA. </summary>
        public string DeploymentType { get; }
        /// <summary> The delegation for the Virtual Appliance. </summary>
        public VirtualApplianceDelegationProperties Delegation { get; set; }
        /// <summary> The delegation for the Virtual Appliance. </summary>
        public PartnerManagedResourceProperties PartnerManagedResource { get; set; }
    }
}