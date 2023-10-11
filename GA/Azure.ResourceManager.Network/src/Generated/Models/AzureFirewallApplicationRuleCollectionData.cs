// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application rule collection resource. </summary>
    public partial class AzureFirewallApplicationRuleCollectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of AzureFirewallApplicationRuleCollectionData. </summary>
        public AzureFirewallApplicationRuleCollectionData()
        {
            Rules = new ChangeTrackingList<AzureFirewallApplicationRule>();
        }

        /// <summary> Initializes a new instance of AzureFirewallApplicationRuleCollectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the application rule collection resource. </param>
        /// <param name="action"> The action type of a rule collection. </param>
        /// <param name="rules"> Collection of rules used by a application rule collection. </param>
        /// <param name="provisioningState"> The provisioning state of the application rule collection resource. </param>
        internal AzureFirewallApplicationRuleCollectionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, int? priority, AzureFirewallRCAction action, IList<AzureFirewallApplicationRule> rules, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            Priority = priority;
            Action = action;
            Rules = rules;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Priority of the application rule collection resource. </summary>
        public int? Priority { get; set; }
        /// <summary> The action type of a rule collection. </summary>
        internal AzureFirewallRCAction Action { get; set; }
        /// <summary> The type of action. </summary>
        public AzureFirewallRCActionType? ActionType
        {
            get => Action is null ? default : Action.ActionType;
            set
            {
                if (Action is null)
                    Action = new AzureFirewallRCAction();
                Action.ActionType = value;
            }
        }

        /// <summary> Collection of rules used by a application rule collection. </summary>
        public IList<AzureFirewallApplicationRule> Rules { get; }
        /// <summary> The provisioning state of the application rule collection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}