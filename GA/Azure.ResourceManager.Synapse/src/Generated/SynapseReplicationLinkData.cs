// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseReplicationLink data model.
    /// Represents a Sql pool replication link.
    /// </summary>
    public partial class SynapseReplicationLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseReplicationLinkData. </summary>
        public SynapseReplicationLinkData()
        {
        }

        /// <summary> Initializes a new instance of SynapseReplicationLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Location of the workspace that contains this firewall rule. </param>
        /// <param name="isTerminationAllowed"> Legacy value indicating whether termination is allowed.  Currently always returns true. </param>
        /// <param name="replicationMode"> Replication mode of this replication link. </param>
        /// <param name="partnerServer"> The name of the workspace hosting the partner Sql pool. </param>
        /// <param name="partnerDatabase"> The name of the partner Sql pool. </param>
        /// <param name="partnerLocation"> The Azure Region of the partner Sql pool. </param>
        /// <param name="role"> The role of the Sql pool in the replication link. </param>
        /// <param name="partnerRole"> The role of the partner Sql pool in the replication link. </param>
        /// <param name="startOn"> The start time for the replication link. </param>
        /// <param name="percentComplete"> The percentage of seeding complete for the replication link. </param>
        /// <param name="replicationState"> The replication state for the replication link. </param>
        internal SynapseReplicationLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, bool? isTerminationAllowed, string replicationMode, string partnerServer, string partnerDatabase, AzureLocation? partnerLocation, SynapseReplicationRole? role, SynapseReplicationRole? partnerRole, DateTimeOffset? startOn, int? percentComplete, SynapseReplicationState? replicationState) : base(id, name, resourceType, systemData)
        {
            Location = location;
            IsTerminationAllowed = isTerminationAllowed;
            ReplicationMode = replicationMode;
            PartnerServer = partnerServer;
            PartnerDatabase = partnerDatabase;
            PartnerLocation = partnerLocation;
            Role = role;
            PartnerRole = partnerRole;
            StartOn = startOn;
            PercentComplete = percentComplete;
            ReplicationState = replicationState;
        }

        /// <summary> Location of the workspace that contains this firewall rule. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Legacy value indicating whether termination is allowed.  Currently always returns true. </summary>
        public bool? IsTerminationAllowed { get; }
        /// <summary> Replication mode of this replication link. </summary>
        public string ReplicationMode { get; }
        /// <summary> The name of the workspace hosting the partner Sql pool. </summary>
        public string PartnerServer { get; }
        /// <summary> The name of the partner Sql pool. </summary>
        public string PartnerDatabase { get; }
        /// <summary> The Azure Region of the partner Sql pool. </summary>
        public AzureLocation? PartnerLocation { get; }
        /// <summary> The role of the Sql pool in the replication link. </summary>
        public SynapseReplicationRole? Role { get; }
        /// <summary> The role of the partner Sql pool in the replication link. </summary>
        public SynapseReplicationRole? PartnerRole { get; }
        /// <summary> The start time for the replication link. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The percentage of seeding complete for the replication link. </summary>
        public int? PercentComplete { get; }
        /// <summary> The replication state for the replication link. </summary>
        public SynapseReplicationState? ReplicationState { get; }
    }
}