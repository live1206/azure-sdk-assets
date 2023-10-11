// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Request routing rule of an application gateway. </summary>
    public partial class ApplicationGatewayRequestRoutingRule : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayRequestRoutingRule. </summary>
        public ApplicationGatewayRequestRoutingRule()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayRequestRoutingRule. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ruleType"> Rule type. </param>
        /// <param name="priority"> Priority of the request routing rule. </param>
        /// <param name="backendAddressPool"> Backend address pool resource of the application gateway. </param>
        /// <param name="backendHttpSettings"> Backend http settings resource of the application gateway. </param>
        /// <param name="httpListener"> Http listener resource of the application gateway. </param>
        /// <param name="urlPathMap"> URL path map resource of the application gateway. </param>
        /// <param name="rewriteRuleSet"> Rewrite Rule Set resource in Basic rule of the application gateway. </param>
        /// <param name="redirectConfiguration"> Redirect configuration resource of the application gateway. </param>
        /// <param name="loadDistributionPolicy"> Load Distribution Policy resource of the application gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the request routing rule resource. </param>
        internal ApplicationGatewayRequestRoutingRule(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ApplicationGatewayRequestRoutingRuleType? ruleType, int? priority, WritableSubResource backendAddressPool, WritableSubResource backendHttpSettings, WritableSubResource httpListener, WritableSubResource urlPathMap, WritableSubResource rewriteRuleSet, WritableSubResource redirectConfiguration, WritableSubResource loadDistributionPolicy, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            RuleType = ruleType;
            Priority = priority;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            RewriteRuleSet = rewriteRuleSet;
            RedirectConfiguration = redirectConfiguration;
            LoadDistributionPolicy = loadDistributionPolicy;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Rule type. </summary>
        public ApplicationGatewayRequestRoutingRuleType? RuleType { get; set; }
        /// <summary> Priority of the request routing rule. </summary>
        public int? Priority { get; set; }
        /// <summary> Backend address pool resource of the application gateway. </summary>
        internal WritableSubResource BackendAddressPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendAddressPoolId
        {
            get => BackendAddressPool is null ? default : BackendAddressPool.Id;
            set
            {
                if (BackendAddressPool is null)
                    BackendAddressPool = new WritableSubResource();
                BackendAddressPool.Id = value;
            }
        }

        /// <summary> Backend http settings resource of the application gateway. </summary>
        internal WritableSubResource BackendHttpSettings { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendHttpSettingsId
        {
            get => BackendHttpSettings is null ? default : BackendHttpSettings.Id;
            set
            {
                if (BackendHttpSettings is null)
                    BackendHttpSettings = new WritableSubResource();
                BackendHttpSettings.Id = value;
            }
        }

        /// <summary> Http listener resource of the application gateway. </summary>
        internal WritableSubResource HttpListener { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HttpListenerId
        {
            get => HttpListener is null ? default : HttpListener.Id;
            set
            {
                if (HttpListener is null)
                    HttpListener = new WritableSubResource();
                HttpListener.Id = value;
            }
        }

        /// <summary> URL path map resource of the application gateway. </summary>
        internal WritableSubResource UrlPathMap { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier UrlPathMapId
        {
            get => UrlPathMap is null ? default : UrlPathMap.Id;
            set
            {
                if (UrlPathMap is null)
                    UrlPathMap = new WritableSubResource();
                UrlPathMap.Id = value;
            }
        }

        /// <summary> Rewrite Rule Set resource in Basic rule of the application gateway. </summary>
        internal WritableSubResource RewriteRuleSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RewriteRuleSetId
        {
            get => RewriteRuleSet is null ? default : RewriteRuleSet.Id;
            set
            {
                if (RewriteRuleSet is null)
                    RewriteRuleSet = new WritableSubResource();
                RewriteRuleSet.Id = value;
            }
        }

        /// <summary> Redirect configuration resource of the application gateway. </summary>
        internal WritableSubResource RedirectConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RedirectConfigurationId
        {
            get => RedirectConfiguration is null ? default : RedirectConfiguration.Id;
            set
            {
                if (RedirectConfiguration is null)
                    RedirectConfiguration = new WritableSubResource();
                RedirectConfiguration.Id = value;
            }
        }

        /// <summary> Load Distribution Policy resource of the application gateway. </summary>
        internal WritableSubResource LoadDistributionPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier LoadDistributionPolicyId
        {
            get => LoadDistributionPolicy is null ? default : LoadDistributionPolicy.Id;
            set
            {
                if (LoadDistributionPolicy is null)
                    LoadDistributionPolicy = new WritableSubResource();
                LoadDistributionPolicy.Id = value;
            }
        }

        /// <summary> The provisioning state of the request routing rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}