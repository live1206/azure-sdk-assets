// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the FrontDoorRuleSet data model.
    /// Friendly RuleSet name mapping to the any RuleSet or secret related information.
    /// </summary>
    public partial class FrontDoorRuleSetData : ResourceData
    {
        /// <summary> Initializes a new instance of FrontDoorRuleSetData. </summary>
        public FrontDoorRuleSetData()
        {
        }

        /// <summary> Initializes a new instance of FrontDoorRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="profileName"> The name of the profile which holds the rule set. </param>
        internal FrontDoorRuleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, FrontDoorProvisioningState? provisioningState, FrontDoorDeploymentStatus? deploymentStatus, string profileName) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            ProfileName = profileName;
        }

        /// <summary> Provisioning status. </summary>
        public FrontDoorProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public FrontDoorDeploymentStatus? DeploymentStatus { get; }
        /// <summary> The name of the profile which holds the rule set. </summary>
        public string ProfileName { get; }
    }
}