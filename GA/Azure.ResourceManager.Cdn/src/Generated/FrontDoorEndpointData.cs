// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the FrontDoorEndpoint data model.
    /// CDN endpoint is the entity within a CDN profile containing configuration information such as origin, protocol, content caching and delivery behavior. The AzureFrontDoor endpoint uses the URL format &lt;endpointname&gt;.azureedge.net.
    /// </summary>
    public partial class FrontDoorEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of FrontDoorEndpointData. </summary>
        /// <param name="location"> The location. </param>
        public FrontDoorEndpointData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FrontDoorEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="profileName"> The name of the profile which holds the endpoint. </param>
        /// <param name="enabledState"> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="hostName"> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> Indicates the endpoint name reuse scope. The default value is TenantReuse. </param>
        internal FrontDoorEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string profileName, EnabledState? enabledState, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus, string hostName, DomainNameLabelScope? autoGeneratedDomainNameLabelScope) : base(id, name, resourceType, systemData, tags, location)
        {
            ProfileName = profileName;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            HostName = hostName;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
        }

        /// <summary> The name of the profile which holds the endpoint. </summary>
        public string ProfileName { get; }
        /// <summary> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </summary>
        public EnabledState? EnabledState { get; set; }
        /// <summary> Provisioning status. </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
        /// <summary> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </summary>
        public string HostName { get; }
        /// <summary> Indicates the endpoint name reuse scope. The default value is TenantReuse. </summary>
        public DomainNameLabelScope? AutoGeneratedDomainNameLabelScope { get; set; }
    }
}