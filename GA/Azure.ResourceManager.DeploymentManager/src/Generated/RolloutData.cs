// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeploymentManager.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager
{
    /// <summary>
    /// A class representing the Rollout data model.
    /// Defines the rollout.
    /// </summary>
    public partial class RolloutData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of RolloutData. </summary>
        /// <param name="location"> The location. </param>
        public RolloutData(AzureLocation location) : base(location)
        {
            StepGroups = new ChangeTrackingList<StepGroup>();
            Services = new ChangeTrackingList<Service>();
        }

        /// <summary> Initializes a new instance of RolloutData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="buildVersion"> The version of the build being deployed. </param>
        /// <param name="artifactSourceId"> The reference to the artifact source resource Id where the payload is located. </param>
        /// <param name="targetServiceTopologyId"> The resource Id of the service topology from which service units are being referenced in step groups to be deployed. </param>
        /// <param name="stepGroups"> The list of step groups that define the orchestration. </param>
        /// <param name="status"> The current status of the rollout. </param>
        /// <param name="totalRetryAttempts"> The cardinal count of total number of retries performed on the rollout at a given time. </param>
        /// <param name="operationInfo"> Operational information of the rollout. </param>
        /// <param name="services"> The detailed information on the services being deployed. </param>
        internal RolloutData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Identity identity, string buildVersion, string artifactSourceId, string targetServiceTopologyId, IList<StepGroup> stepGroups, string status, int? totalRetryAttempts, RolloutOperationInfo operationInfo, IReadOnlyList<Service> services) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            BuildVersion = buildVersion;
            ArtifactSourceId = artifactSourceId;
            TargetServiceTopologyId = targetServiceTopologyId;
            StepGroups = stepGroups;
            Status = status;
            TotalRetryAttempts = totalRetryAttempts;
            OperationInfo = operationInfo;
            Services = services;
        }

        /// <summary> Identity for the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> The version of the build being deployed. </summary>
        public string BuildVersion { get; set; }
        /// <summary> The reference to the artifact source resource Id where the payload is located. </summary>
        public string ArtifactSourceId { get; set; }
        /// <summary> The resource Id of the service topology from which service units are being referenced in step groups to be deployed. </summary>
        public string TargetServiceTopologyId { get; set; }
        /// <summary> The list of step groups that define the orchestration. </summary>
        public IList<StepGroup> StepGroups { get; }
        /// <summary> The current status of the rollout. </summary>
        public string Status { get; }
        /// <summary> The cardinal count of total number of retries performed on the rollout at a given time. </summary>
        public int? TotalRetryAttempts { get; }
        /// <summary> Operational information of the rollout. </summary>
        public RolloutOperationInfo OperationInfo { get; }
        /// <summary> The detailed information on the services being deployed. </summary>
        public IReadOnlyList<Service> Services { get; }
    }
}