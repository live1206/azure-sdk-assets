// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeShare data model.
    /// Represents a share on the  Data Box Edge/Gateway device.
    /// </summary>
    public partial class DataBoxEdgeShareData : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeShareData. </summary>
        /// <param name="shareStatus"> Current status of the share. </param>
        /// <param name="monitoringStatus"> Current monitoring status of the share. </param>
        /// <param name="accessProtocol"> Access protocol to be used by the share. </param>
        public DataBoxEdgeShareData(ShareStatus shareStatus, DataBoxEdgeShareMonitoringStatus monitoringStatus, ShareAccessProtocol accessProtocol)
        {
            ShareStatus = shareStatus;
            MonitoringStatus = monitoringStatus;
            AccessProtocol = accessProtocol;
            UserAccessRights = new ChangeTrackingList<UserAccessRight>();
            ClientAccessRights = new ChangeTrackingList<ClientAccessRight>();
            ShareMappings = new ChangeTrackingList<DataBoxEdgeMountPointMap>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeShareData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description for the share. </param>
        /// <param name="shareStatus"> Current status of the share. </param>
        /// <param name="monitoringStatus"> Current monitoring status of the share. </param>
        /// <param name="azureContainerInfo"> Azure container mapping for the share. </param>
        /// <param name="accessProtocol"> Access protocol to be used by the share. </param>
        /// <param name="userAccessRights"> Mapping of users and corresponding access rights on the share (required for SMB protocol). </param>
        /// <param name="clientAccessRights"> List of IP addresses and corresponding access rights on the share(required for NFS protocol). </param>
        /// <param name="refreshDetails"> Details of the refresh job on this share. </param>
        /// <param name="shareMappings"> Share mount point to the role. </param>
        /// <param name="dataPolicy"> Data policy of the share. </param>
        internal DataBoxEdgeShareData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, ShareStatus shareStatus, DataBoxEdgeShareMonitoringStatus monitoringStatus, DataBoxEdgeStorageContainerInfo azureContainerInfo, ShareAccessProtocol accessProtocol, IList<UserAccessRight> userAccessRights, IList<ClientAccessRight> clientAccessRights, DataBoxEdgeRefreshDetails refreshDetails, IReadOnlyList<DataBoxEdgeMountPointMap> shareMappings, DataBoxEdgeDataPolicy? dataPolicy) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ShareStatus = shareStatus;
            MonitoringStatus = monitoringStatus;
            AzureContainerInfo = azureContainerInfo;
            AccessProtocol = accessProtocol;
            UserAccessRights = userAccessRights;
            ClientAccessRights = clientAccessRights;
            RefreshDetails = refreshDetails;
            ShareMappings = shareMappings;
            DataPolicy = dataPolicy;
        }

        /// <summary> Description for the share. </summary>
        public string Description { get; set; }
        /// <summary> Current status of the share. </summary>
        public ShareStatus ShareStatus { get; set; }
        /// <summary> Current monitoring status of the share. </summary>
        public DataBoxEdgeShareMonitoringStatus MonitoringStatus { get; set; }
        /// <summary> Azure container mapping for the share. </summary>
        public DataBoxEdgeStorageContainerInfo AzureContainerInfo { get; set; }
        /// <summary> Access protocol to be used by the share. </summary>
        public ShareAccessProtocol AccessProtocol { get; set; }
        /// <summary> Mapping of users and corresponding access rights on the share (required for SMB protocol). </summary>
        public IList<UserAccessRight> UserAccessRights { get; }
        /// <summary> List of IP addresses and corresponding access rights on the share(required for NFS protocol). </summary>
        public IList<ClientAccessRight> ClientAccessRights { get; }
        /// <summary> Details of the refresh job on this share. </summary>
        public DataBoxEdgeRefreshDetails RefreshDetails { get; set; }
        /// <summary> Share mount point to the role. </summary>
        public IReadOnlyList<DataBoxEdgeMountPointMap> ShareMappings { get; }
        /// <summary> Data policy of the share. </summary>
        public DataBoxEdgeDataPolicy? DataPolicy { get; set; }
    }
}