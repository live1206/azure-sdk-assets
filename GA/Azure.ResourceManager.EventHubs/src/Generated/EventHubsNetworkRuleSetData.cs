// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing the EventHubsNetworkRuleSet data model.
    /// Description of topic resource.
    /// </summary>
    public partial class EventHubsNetworkRuleSetData : ResourceData
    {
        /// <summary> Initializes a new instance of EventHubsNetworkRuleSetData. </summary>
        public EventHubsNetworkRuleSetData()
        {
            VirtualNetworkRules = new ChangeTrackingList<EventHubsNetworkRuleSetVirtualNetworkRules>();
            IPRules = new ChangeTrackingList<EventHubsNetworkRuleSetIPRules>();
        }

        /// <summary> Initializes a new instance of EventHubsNetworkRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="trustedServiceAccessEnabled"> Value that indicates whether Trusted Service Access is Enabled or not. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="virtualNetworkRules"> List VirtualNetwork Rules. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal EventHubsNetworkRuleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? trustedServiceAccessEnabled, EventHubsNetworkRuleSetDefaultAction? defaultAction, IList<EventHubsNetworkRuleSetVirtualNetworkRules> virtualNetworkRules, IList<EventHubsNetworkRuleSetIPRules> ipRules, EventHubsPublicNetworkAccessFlag? publicNetworkAccess, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            TrustedServiceAccessEnabled = trustedServiceAccessEnabled;
            DefaultAction = defaultAction;
            VirtualNetworkRules = virtualNetworkRules;
            IPRules = ipRules;
            PublicNetworkAccess = publicNetworkAccess;
            Location = location;
        }

        /// <summary> Value that indicates whether Trusted Service Access is Enabled or not. </summary>
        public bool? TrustedServiceAccessEnabled { get; set; }
        /// <summary> Default Action for Network Rule Set. </summary>
        public EventHubsNetworkRuleSetDefaultAction? DefaultAction { get; set; }
        /// <summary> List VirtualNetwork Rules. </summary>
        public IList<EventHubsNetworkRuleSetVirtualNetworkRules> VirtualNetworkRules { get; }
        /// <summary> List of IpRules. </summary>
        public IList<EventHubsNetworkRuleSetIPRules> IPRules { get; }
        /// <summary> This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules. </summary>
        public EventHubsPublicNetworkAccessFlag? PublicNetworkAccess { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}