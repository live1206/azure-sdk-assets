// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmWebPubSubModelFactory
    {
        /// <summary> Initializes a new instance of WebPubSubNameAvailability. </summary>
        /// <param name="nameAvailable"> Indicates whether the name is available or not. </param>
        /// <param name="reason"> The reason of the availability. Required if name is not available. </param>
        /// <param name="message"> The message of the operation. </param>
        /// <returns> A new <see cref="Models.WebPubSubNameAvailability"/> instance for mocking. </returns>
        public static WebPubSubNameAvailability WebPubSubNameAvailability(bool? nameAvailable = null, string reason = null, string message = null)
        {
            return new WebPubSubNameAvailability(nameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of SignalRServiceUsage. </summary>
        /// <param name="id"> Fully qualified ARM resource id. </param>
        /// <param name="currentValue"> Current value for the usage quota. </param>
        /// <param name="limit"> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </param>
        /// <param name="name"> Localizable String object containing the name and a localized value. </param>
        /// <param name="unit"> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </param>
        /// <returns> A new <see cref="Models.SignalRServiceUsage"/> instance for mocking. </returns>
        public static SignalRServiceUsage SignalRServiceUsage(ResourceIdentifier id = null, long? currentValue = null, long? limit = null, SignalRServiceUsageName name = null, string unit = null)
        {
            return new SignalRServiceUsage(id, currentValue, limit, name, unit);
        }

        /// <summary> Initializes a new instance of SignalRServiceUsageName. </summary>
        /// <param name="value"> The identifier of the usage. </param>
        /// <param name="localizedValue"> Localized name of the usage. </param>
        /// <returns> A new <see cref="Models.SignalRServiceUsageName"/> instance for mocking. </returns>
        public static SignalRServiceUsageName SignalRServiceUsageName(string value = null, string localizedValue = null)
        {
            return new SignalRServiceUsageName(value, localizedValue);
        }

        /// <summary> Initializes a new instance of WebPubSubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="identity"> A class represent managed identities used for request and response. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="externalIP"> The publicly accessible IP of the resource. </param>
        /// <param name="hostName"> FQDN of the service instance. </param>
        /// <param name="publicPort"> The publicly accessible port of the resource which is designed for browser/client side usage. </param>
        /// <param name="serverPort"> The publicly accessible port of the resource which is designed for customer server side usage. </param>
        /// <param name="version"> Version of the resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the resource. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources. </param>
        /// <param name="isClientCertEnabled"> TLS settings for the resource. </param>
        /// <param name="hostNamePrefix"> Deprecated. </param>
        /// <param name="liveTraceConfiguration"> Live trace configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="resourceLogCategories"> Resource log configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="networkAcls"> Network ACLs for the resource. </param>
        /// <param name="publicNetworkAccess">
        /// Enable or disable public network access. Default to "Enabled".
        /// When it's Enabled, network ACLs still apply.
        /// When it's Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </param>
        /// <param name="isLocalAuthDisabled">
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won't work.
        /// </param>
        /// <param name="isAadAuthDisabled">
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won't work.
        /// </param>
        /// <returns> A new <see cref="WebPubSub.WebPubSubData"/> instance for mocking. </returns>
        public static WebPubSubData WebPubSubData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, BillingInfoSku sku = null, ManagedServiceIdentity identity = null, WebPubSubProvisioningState? provisioningState = null, string externalIP = null, string hostName = null, int? publicPort = null, int? serverPort = null, string version = null, IEnumerable<WebPubSubPrivateEndpointConnectionData> privateEndpointConnections = null, IEnumerable<WebPubSubSharedPrivateLinkData> sharedPrivateLinkResources = null, bool? isClientCertEnabled = null, string hostNamePrefix = null, LiveTraceConfiguration liveTraceConfiguration = null, IEnumerable<ResourceLogCategory> resourceLogCategories = null, WebPubSubNetworkAcls networkAcls = null, string publicNetworkAccess = null, bool? isLocalAuthDisabled = null, bool? isAadAuthDisabled = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<WebPubSubPrivateEndpointConnectionData>();
            sharedPrivateLinkResources ??= new List<WebPubSubSharedPrivateLinkData>();
            resourceLogCategories ??= new List<ResourceLogCategory>();

            return new WebPubSubData(id, name, resourceType, systemData, tags, location, sku, identity, provisioningState, externalIP, hostName, publicPort, serverPort, version, privateEndpointConnections?.ToList(), sharedPrivateLinkResources?.ToList(), isClientCertEnabled != null ? new WebPubSubTlsSettings(isClientCertEnabled) : null, hostNamePrefix, liveTraceConfiguration, resourceLogCategories != null ? new ResourceLogConfiguration(resourceLogCategories?.ToList()) : null, networkAcls, publicNetworkAccess, isLocalAuthDisabled, isAadAuthDisabled);
        }

        /// <summary> Initializes a new instance of BillingInfoSku. </summary>
        /// <param name="name">
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </param>
        /// <param name="tier">
        /// Optional tier of this particular SKU. 'Standard' or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead.
        /// </param>
        /// <param name="size"> Not used. Retained for future use. </param>
        /// <param name="family"> Not used. Retained for future use. </param>
        /// <param name="capacity">
        /// Optional, integer. The unit count of the resource. 1 by default.
        ///
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </param>
        /// <returns> A new <see cref="Models.BillingInfoSku"/> instance for mocking. </returns>
        public static BillingInfoSku BillingInfoSku(string name = null, WebPubSubSkuTier? tier = null, string size = null, string family = null, int? capacity = null)
        {
            return new BillingInfoSku(name, tier, size, family, capacity);
        }

        /// <summary> Initializes a new instance of WebPubSubPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="privateEndpointId"> Private endpoint. </param>
        /// <param name="groupIds"> Group IDs. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <returns> A new <see cref="WebPubSub.WebPubSubPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static WebPubSubPrivateEndpointConnectionData WebPubSubPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, WebPubSubProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, IEnumerable<string> groupIds = null, WebPubSubPrivateLinkServiceConnectionState connectionState = null)
        {
            groupIds ??= new List<string>();

            return new WebPubSubPrivateEndpointConnectionData(id, name, resourceType, systemData, provisioningState, privateEndpointId != null ? new PrivateEndpoint(privateEndpointId) : null, groupIds?.ToList(), connectionState);
        }

        /// <summary> Initializes a new instance of WebPubSubSharedPrivateLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The group id from the provider of resource the shared private link resource is for. </param>
        /// <param name="privateLinkResourceId"> The resource id of the resource the shared private link resource is for. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="requestMessage"> The request message for requesting approval of the shared private link resource. </param>
        /// <param name="status"> Status of the shared private link resource. </param>
        /// <returns> A new <see cref="WebPubSub.WebPubSubSharedPrivateLinkData"/> instance for mocking. </returns>
        public static WebPubSubSharedPrivateLinkData WebPubSubSharedPrivateLinkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, ResourceIdentifier privateLinkResourceId = null, WebPubSubProvisioningState? provisioningState = null, string requestMessage = null, WebPubSubSharedPrivateLinkStatus? status = null)
        {
            return new WebPubSubSharedPrivateLinkData(id, name, resourceType, systemData, groupId, privateLinkResourceId, provisioningState, requestMessage, status);
        }

        /// <summary> Initializes a new instance of WebPubSubHubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of a hub. </param>
        /// <returns> A new <see cref="WebPubSub.WebPubSubHubData"/> instance for mocking. </returns>
        public static WebPubSubHubData WebPubSubHubData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, WebPubSubHubProperties properties = null)
        {
            return new WebPubSubHubData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of WebPubSubKeys. </summary>
        /// <param name="primaryKey"> The primary access key. </param>
        /// <param name="secondaryKey"> The secondary access key. </param>
        /// <param name="primaryConnectionString"> Connection string constructed via the primaryKey. </param>
        /// <param name="secondaryConnectionString"> Connection string constructed via the secondaryKey. </param>
        /// <returns> A new <see cref="Models.WebPubSubKeys"/> instance for mocking. </returns>
        public static WebPubSubKeys WebPubSubKeys(string primaryKey = null, string secondaryKey = null, string primaryConnectionString = null, string secondaryConnectionString = null)
        {
            return new WebPubSubKeys(primaryKey, secondaryKey, primaryConnectionString, secondaryConnectionString);
        }

        /// <summary> Initializes a new instance of WebPubSubPrivateLink. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> Group Id of the private link resource. </param>
        /// <param name="requiredMembers"> Required members of the private link resource. </param>
        /// <param name="requiredZoneNames"> Required private DNS zone names. </param>
        /// <param name="shareablePrivateLinkTypes"> The list of resources that are onboarded to private link service. </param>
        /// <returns> A new <see cref="Models.WebPubSubPrivateLink"/> instance for mocking. </returns>
        public static WebPubSubPrivateLink WebPubSubPrivateLink(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null, IEnumerable<ShareablePrivateLinkType> shareablePrivateLinkTypes = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();
            shareablePrivateLinkTypes ??= new List<ShareablePrivateLinkType>();

            return new WebPubSubPrivateLink(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), shareablePrivateLinkTypes?.ToList());
        }

        /// <summary> Initializes a new instance of WebPubSubSku. </summary>
        /// <param name="resourceType"> The resource type that this object applies to. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="capacity"> Describes scaling information of a sku. </param>
        /// <returns> A new <see cref="Models.WebPubSubSku"/> instance for mocking. </returns>
        public static WebPubSubSku WebPubSubSku(ResourceType? resourceType = null, BillingInfoSku sku = null, WebPubSubSkuCapacity capacity = null)
        {
            return new WebPubSubSku(resourceType, sku, capacity);
        }

        /// <summary> Initializes a new instance of WebPubSubSkuCapacity. </summary>
        /// <param name="minimum"> The lowest permitted capacity for this resource. </param>
        /// <param name="maximum"> The highest permitted capacity for this resource. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="allowedValues"> Allows capacity value list. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        /// <returns> A new <see cref="Models.WebPubSubSkuCapacity"/> instance for mocking. </returns>
        public static WebPubSubSkuCapacity WebPubSubSkuCapacity(int? minimum = null, int? maximum = null, int? @default = null, IEnumerable<int> allowedValues = null, WebPubSubScaleType? scaleType = null)
        {
            allowedValues ??= new List<int>();

            return new WebPubSubSkuCapacity(minimum, maximum, @default, allowedValues?.ToList(), scaleType);
        }
    }
}