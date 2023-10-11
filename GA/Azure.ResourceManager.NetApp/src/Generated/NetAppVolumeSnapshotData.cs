// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing the NetAppVolumeSnapshot data model.
    /// Snapshot of a Volume
    /// </summary>
    public partial class NetAppVolumeSnapshotData : ResourceData
    {
        /// <summary> Initializes a new instance of NetAppVolumeSnapshotData. </summary>
        /// <param name="location"> Resource location. </param>
        public NetAppVolumeSnapshotData(AzureLocation location)
        {
            Location = location;
        }

        /// <summary> Initializes a new instance of NetAppVolumeSnapshotData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="snapshotId"> UUID v4 used to identify the Snapshot. </param>
        /// <param name="created"> The creation date of the snapshot. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        internal NetAppVolumeSnapshotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, string snapshotId, DateTimeOffset? created, string provisioningState) : base(id, name, resourceType, systemData)
        {
            Location = location;
            SnapshotId = snapshotId;
            Created = created;
            ProvisioningState = provisioningState;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> UUID v4 used to identify the Snapshot. </summary>
        public string SnapshotId { get; }
        /// <summary> The creation date of the snapshot. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
    }
}