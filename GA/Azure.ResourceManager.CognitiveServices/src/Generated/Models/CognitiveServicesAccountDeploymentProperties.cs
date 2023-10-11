// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account deployment. </summary>
    public partial class CognitiveServicesAccountDeploymentProperties
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountDeploymentProperties. </summary>
        public CognitiveServicesAccountDeploymentProperties()
        {
            Capabilities = new ChangeTrackingDictionary<string, string>();
            RateLimits = new ChangeTrackingList<ServiceAccountThrottlingRule>();
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountDeploymentProperties. </summary>
        /// <param name="provisioningState"> Gets the status of the resource at the time the operation was called. </param>
        /// <param name="model"> Properties of Cognitive Services account deployment model. </param>
        /// <param name="scaleSettings"> Properties of Cognitive Services account deployment model. </param>
        /// <param name="capabilities"> The capabilities. </param>
        /// <param name="raiPolicyName"> The name of RAI policy. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        /// <param name="rateLimits"></param>
        /// <param name="versionUpgradeOption"> Deployment model version upgrade option. </param>
        internal CognitiveServicesAccountDeploymentProperties(CognitiveServicesAccountDeploymentProvisioningState? provisioningState, CognitiveServicesAccountDeploymentModel model, CognitiveServicesAccountDeploymentScaleSettings scaleSettings, IReadOnlyDictionary<string, string> capabilities, string raiPolicyName, ServiceAccountCallRateLimit callRateLimit, IReadOnlyList<ServiceAccountThrottlingRule> rateLimits, DeploymentModelVersionUpgradeOption? versionUpgradeOption)
        {
            ProvisioningState = provisioningState;
            Model = model;
            ScaleSettings = scaleSettings;
            Capabilities = capabilities;
            RaiPolicyName = raiPolicyName;
            CallRateLimit = callRateLimit;
            RateLimits = rateLimits;
            VersionUpgradeOption = versionUpgradeOption;
        }

        /// <summary> Gets the status of the resource at the time the operation was called. </summary>
        public CognitiveServicesAccountDeploymentProvisioningState? ProvisioningState { get; }
        /// <summary> Properties of Cognitive Services account deployment model. </summary>
        public CognitiveServicesAccountDeploymentModel Model { get; set; }
        /// <summary> Properties of Cognitive Services account deployment model. </summary>
        public CognitiveServicesAccountDeploymentScaleSettings ScaleSettings { get; set; }
        /// <summary> The capabilities. </summary>
        public IReadOnlyDictionary<string, string> Capabilities { get; }
        /// <summary> The name of RAI policy. </summary>
        public string RaiPolicyName { get; set; }
        /// <summary> The call rate limit Cognitive Services account. </summary>
        public ServiceAccountCallRateLimit CallRateLimit { get; }
        /// <summary> Gets the rate limits. </summary>
        public IReadOnlyList<ServiceAccountThrottlingRule> RateLimits { get; }
        /// <summary> Deployment model version upgrade option. </summary>
        public DeploymentModelVersionUpgradeOption? VersionUpgradeOption { get; set; }
    }
}