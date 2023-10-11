// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the DscpConfiguration data model.
    /// Differentiated Services Code Point configuration for any given network interface
    /// </summary>
    public partial class DscpConfigurationData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of DscpConfigurationData. </summary>
        public DscpConfigurationData()
        {
            Markings = new ChangeTrackingList<int>();
            SourceIPRanges = new ChangeTrackingList<QosIPRange>();
            DestinationIPRanges = new ChangeTrackingList<QosIPRange>();
            SourcePortRanges = new ChangeTrackingList<QosPortRange>();
            DestinationPortRanges = new ChangeTrackingList<QosPortRange>();
            QosDefinitionCollection = new ChangeTrackingList<DscpQosDefinition>();
            AssociatedNetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
        }

        /// <summary> Initializes a new instance of DscpConfigurationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="markings"> List of markings to be used in the configuration. </param>
        /// <param name="sourceIPRanges"> Source IP ranges. </param>
        /// <param name="destinationIPRanges"> Destination IP ranges. </param>
        /// <param name="sourcePortRanges"> Sources port ranges. </param>
        /// <param name="destinationPortRanges"> Destination port ranges. </param>
        /// <param name="protocol"> RNM supported protocol types. </param>
        /// <param name="qosDefinitionCollection"> QoS object definitions. </param>
        /// <param name="qosCollectionId"> Qos Collection ID generated by RNM. </param>
        /// <param name="associatedNetworkInterfaces"> Associated Network Interfaces to the DSCP Configuration. </param>
        /// <param name="resourceGuid"> The resource GUID property of the DSCP Configuration resource. </param>
        /// <param name="provisioningState"> The provisioning state of the DSCP Configuration resource. </param>
        internal DscpConfigurationData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, IList<int> markings, IList<QosIPRange> sourceIPRanges, IList<QosIPRange> destinationIPRanges, IList<QosPortRange> sourcePortRanges, IList<QosPortRange> destinationPortRanges, ProtocolType? protocol, IList<DscpQosDefinition> qosDefinitionCollection, string qosCollectionId, IReadOnlyList<NetworkInterfaceData> associatedNetworkInterfaces, Guid? resourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            Markings = markings;
            SourceIPRanges = sourceIPRanges;
            DestinationIPRanges = destinationIPRanges;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Protocol = protocol;
            QosDefinitionCollection = qosDefinitionCollection;
            QosCollectionId = qosCollectionId;
            AssociatedNetworkInterfaces = associatedNetworkInterfaces;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> List of markings to be used in the configuration. </summary>
        public IList<int> Markings { get; }
        /// <summary> Source IP ranges. </summary>
        public IList<QosIPRange> SourceIPRanges { get; }
        /// <summary> Destination IP ranges. </summary>
        public IList<QosIPRange> DestinationIPRanges { get; }
        /// <summary> Sources port ranges. </summary>
        public IList<QosPortRange> SourcePortRanges { get; }
        /// <summary> Destination port ranges. </summary>
        public IList<QosPortRange> DestinationPortRanges { get; }
        /// <summary> RNM supported protocol types. </summary>
        public ProtocolType? Protocol { get; set; }
        /// <summary> QoS object definitions. </summary>
        public IList<DscpQosDefinition> QosDefinitionCollection { get; }
        /// <summary> Qos Collection ID generated by RNM. </summary>
        public string QosCollectionId { get; }
        /// <summary> Associated Network Interfaces to the DSCP Configuration. </summary>
        public IReadOnlyList<NetworkInterfaceData> AssociatedNetworkInterfaces { get; }
        /// <summary> The resource GUID property of the DSCP Configuration resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the DSCP Configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
