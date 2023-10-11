// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing the MonitorWorkspaceResource data model.
    /// An Azure Monitor Workspace definition
    /// </summary>
    public partial class MonitorWorkspaceResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MonitorWorkspaceResourceData. </summary>
        /// <param name="location"> The location. </param>
        public MonitorWorkspaceResourceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<MonitorWorkspacePrivateEndpointConnection>();
        }

        /// <summary> Initializes a new instance of MonitorWorkspaceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Resource entity tag (ETag). </param>
        /// <param name="accountId"> The immutable ID of the Azure Monitor workspace. This property is read-only. </param>
        /// <param name="metrics"> Information about metrics for the Azure Monitor workspace. </param>
        /// <param name="provisioningState"> The provisioning state of the Azure Monitor workspace. Set to Succeeded if everything is healthy. </param>
        /// <param name="defaultIngestionSettings"> The Data Collection Rule and Endpoint used for ingestion by default. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="publicNetworkAccess"> Gets or sets allow or disallow public network access to workspace. </param>
        internal MonitorWorkspaceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, string accountId, MonitorWorkspaceMetrics metrics, MonitorProvisioningState? provisioningState, MonitorWorkspaceDefaultIngestionSettings defaultIngestionSettings, IReadOnlyList<MonitorWorkspacePrivateEndpointConnection> privateEndpointConnections, MonitorWorkspacePublicNetworkAccess? publicNetworkAccess) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            AccountId = accountId;
            Metrics = metrics;
            ProvisioningState = provisioningState;
            DefaultIngestionSettings = defaultIngestionSettings;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> Resource entity tag (ETag). </summary>
        public ETag? ETag { get; }
        /// <summary> The immutable ID of the Azure Monitor workspace. This property is read-only. </summary>
        public string AccountId { get; }
        /// <summary> Information about metrics for the Azure Monitor workspace. </summary>
        public MonitorWorkspaceMetrics Metrics { get; }
        /// <summary> The provisioning state of the Azure Monitor workspace. Set to Succeeded if everything is healthy. </summary>
        public MonitorProvisioningState? ProvisioningState { get; }
        /// <summary> The Data Collection Rule and Endpoint used for ingestion by default. </summary>
        public MonitorWorkspaceDefaultIngestionSettings DefaultIngestionSettings { get; }
        /// <summary> List of private endpoint connections. </summary>
        public IReadOnlyList<MonitorWorkspacePrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> Gets or sets allow or disallow public network access to workspace. </summary>
        public MonitorWorkspacePublicNetworkAccess? PublicNetworkAccess { get; }
    }
}