// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPrivateDnsModelFactory
    {
        /// <summary> Initializes a new instance of PrivateDnsZoneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The ETag of the zone. </param>
        /// <param name="maxNumberOfRecords"> The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfRecords"> The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfVirtualNetworkLinks"> The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfVirtualNetworkLinks"> The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfVirtualNetworkLinksWithRegistration"> The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfVirtualNetworkLinksWithRegistration"> The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="privateDnsProvisioningState"> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="internalId"> Private zone internal Id. </param>
        /// <returns> A new <see cref="PrivateDns.PrivateDnsZoneData"/> instance for mocking. </returns>
        public static PrivateDnsZoneData PrivateDnsZoneData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, long? maxNumberOfRecords = null, long? numberOfRecords = null, long? maxNumberOfVirtualNetworkLinks = null, long? numberOfVirtualNetworkLinks = null, long? maxNumberOfVirtualNetworkLinksWithRegistration = null, long? numberOfVirtualNetworkLinksWithRegistration = null, PrivateDnsProvisioningState? privateDnsProvisioningState = null, string internalId = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PrivateDnsZoneData(id, name, resourceType, systemData, tags, location, etag, maxNumberOfRecords, numberOfRecords, maxNumberOfVirtualNetworkLinks, numberOfVirtualNetworkLinks, maxNumberOfVirtualNetworkLinksWithRegistration, numberOfVirtualNetworkLinksWithRegistration, privateDnsProvisioningState, internalId);
        }

        /// <summary> Initializes a new instance of VirtualNetworkLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The ETag of the virtual network link. </param>
        /// <param name="virtualNetworkId"> The reference of the virtual network. </param>
        /// <param name="registrationEnabled"> Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?. </param>
        /// <param name="virtualNetworkLinkState"> The status of the virtual network link to the Private DNS zone. Possible values are 'InProgress' and 'Done'. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="privateDnsProvisioningState"> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <returns> A new <see cref="PrivateDns.VirtualNetworkLinkData"/> instance for mocking. </returns>
        public static VirtualNetworkLinkData VirtualNetworkLinkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, ResourceIdentifier virtualNetworkId = null, bool? registrationEnabled = null, VirtualNetworkLinkState? virtualNetworkLinkState = null, PrivateDnsProvisioningState? privateDnsProvisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new VirtualNetworkLinkData(id, name, resourceType, systemData, tags, location, etag, virtualNetworkId != null ? ResourceManagerModelFactory.WritableSubResource(virtualNetworkId) : null, registrationEnabled, virtualNetworkLinkState, privateDnsProvisioningState);
        }
    }
}