// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An RefreshExternalGovernanceStatus operation result resource. </summary>
    public partial class RefreshExternalGovernanceStatusOperationResult : ResourceData
    {
        /// <summary> Initializes a new instance of RefreshExternalGovernanceStatusOperationResult. </summary>
        public RefreshExternalGovernanceStatusOperationResult()
        {
        }

        /// <summary> Initializes a new instance of RefreshExternalGovernanceStatusOperationResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="requestId"> Request Id. </param>
        /// <param name="requestType"> Request type. </param>
        /// <param name="queuedTime"> Queued time. </param>
        /// <param name="serverName"> Server name. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="errorMessage"> Error message. </param>
        internal RefreshExternalGovernanceStatusOperationResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? requestId, string requestType, string queuedTime, string serverName, string status, string errorMessage) : base(id, name, resourceType, systemData)
        {
            RequestId = requestId;
            RequestType = requestType;
            QueuedTime = queuedTime;
            ServerName = serverName;
            Status = status;
            ErrorMessage = errorMessage;
        }

        /// <summary> Request Id. </summary>
        public Guid? RequestId { get; }
        /// <summary> Request type. </summary>
        public string RequestType { get; }
        /// <summary> Queued time. </summary>
        public string QueuedTime { get; }
        /// <summary> Server name. </summary>
        public string ServerName { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> Error message. </summary>
        public string ErrorMessage { get; }
    }
}