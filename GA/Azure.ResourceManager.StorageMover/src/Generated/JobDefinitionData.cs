// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A class representing the JobDefinition data model.
    /// The Job Definition resource.
    /// </summary>
    public partial class JobDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        /// <param name="copyMode"> Strategy to use for copy. </param>
        /// <param name="sourceName"> The name of the source Endpoint. </param>
        /// <param name="targetName"> The name of the target Endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> or <paramref name="targetName"/> is null. </exception>
        public JobDefinitionData(StorageMoverCopyMode copyMode, string sourceName, string targetName)
        {
            Argument.AssertNotNull(sourceName, nameof(sourceName));
            Argument.AssertNotNull(targetName, nameof(targetName));

            CopyMode = copyMode;
            SourceName = sourceName;
            TargetName = targetName;
        }

        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description for the Job Definition. </param>
        /// <param name="copyMode"> Strategy to use for copy. </param>
        /// <param name="sourceName"> The name of the source Endpoint. </param>
        /// <param name="sourceResourceId"> Fully qualified resource ID of the source Endpoint. </param>
        /// <param name="sourceSubpath"> The subpath to use when reading from the source Endpoint. </param>
        /// <param name="targetName"> The name of the target Endpoint. </param>
        /// <param name="targetResourceId"> Fully qualified resource ID of the target Endpoint. </param>
        /// <param name="targetSubpath"> The subpath to use when writing to the target Endpoint. </param>
        /// <param name="latestJobRunName"> The name of the Job Run in a non-terminal state, if exists. </param>
        /// <param name="latestJobRunResourceId"> The fully qualified resource ID of the Job Run in a non-terminal state, if exists. </param>
        /// <param name="latestJobRunStatus"> The current status of the Job Run in a non-terminal state, if exists. </param>
        /// <param name="agentName"> Name of the Agent to assign for new Job Runs of this Job Definition. </param>
        /// <param name="agentResourceId"> Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        internal JobDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, StorageMoverCopyMode copyMode, string sourceName, ResourceIdentifier sourceResourceId, string sourceSubpath, string targetName, ResourceIdentifier targetResourceId, string targetSubpath, string latestJobRunName, ResourceIdentifier latestJobRunResourceId, JobRunStatus? latestJobRunStatus, string agentName, ResourceIdentifier agentResourceId, StorageMoverProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Description = description;
            CopyMode = copyMode;
            SourceName = sourceName;
            SourceResourceId = sourceResourceId;
            SourceSubpath = sourceSubpath;
            TargetName = targetName;
            TargetResourceId = targetResourceId;
            TargetSubpath = targetSubpath;
            LatestJobRunName = latestJobRunName;
            LatestJobRunResourceId = latestJobRunResourceId;
            LatestJobRunStatus = latestJobRunStatus;
            AgentName = agentName;
            AgentResourceId = agentResourceId;
            ProvisioningState = provisioningState;
        }

        /// <summary> A description for the Job Definition. </summary>
        public string Description { get; set; }
        /// <summary> Strategy to use for copy. </summary>
        public StorageMoverCopyMode CopyMode { get; set; }
        /// <summary> The name of the source Endpoint. </summary>
        public string SourceName { get; set; }
        /// <summary> Fully qualified resource ID of the source Endpoint. </summary>
        public ResourceIdentifier SourceResourceId { get; }
        /// <summary> The subpath to use when reading from the source Endpoint. </summary>
        public string SourceSubpath { get; set; }
        /// <summary> The name of the target Endpoint. </summary>
        public string TargetName { get; set; }
        /// <summary> Fully qualified resource ID of the target Endpoint. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary> The subpath to use when writing to the target Endpoint. </summary>
        public string TargetSubpath { get; set; }
        /// <summary> The name of the Job Run in a non-terminal state, if exists. </summary>
        public string LatestJobRunName { get; }
        /// <summary> The fully qualified resource ID of the Job Run in a non-terminal state, if exists. </summary>
        public ResourceIdentifier LatestJobRunResourceId { get; }
        /// <summary> The current status of the Job Run in a non-terminal state, if exists. </summary>
        public JobRunStatus? LatestJobRunStatus { get; }
        /// <summary> Name of the Agent to assign for new Job Runs of this Job Definition. </summary>
        public string AgentName { get; set; }
        /// <summary> Fully qualified resource id of the Agent to assign for new Job Runs of this Job Definition. </summary>
        public ResourceIdentifier AgentResourceId { get; }
        /// <summary> The provisioning state of this resource. </summary>
        public StorageMoverProvisioningState? ProvisioningState { get; }
    }
}