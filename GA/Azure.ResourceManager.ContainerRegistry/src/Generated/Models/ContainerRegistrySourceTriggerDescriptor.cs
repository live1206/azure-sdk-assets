// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The source trigger that caused a run. </summary>
    public partial class ContainerRegistrySourceTriggerDescriptor
    {
        /// <summary> Initializes a new instance of ContainerRegistrySourceTriggerDescriptor. </summary>
        public ContainerRegistrySourceTriggerDescriptor()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistrySourceTriggerDescriptor. </summary>
        /// <param name="id"> The unique ID of the trigger. </param>
        /// <param name="eventType"> The event type of the trigger. </param>
        /// <param name="commitId"> The unique ID that identifies a commit. </param>
        /// <param name="pullRequestId"> The unique ID that identifies pull request. </param>
        /// <param name="repositoryUri"> The repository URL. </param>
        /// <param name="branchName"> The branch name in the repository. </param>
        /// <param name="providerType"> The source control provider type. </param>
        internal ContainerRegistrySourceTriggerDescriptor(Guid? id, string eventType, string commitId, string pullRequestId, Uri repositoryUri, string branchName, string providerType)
        {
            Id = id;
            EventType = eventType;
            CommitId = commitId;
            PullRequestId = pullRequestId;
            RepositoryUri = repositoryUri;
            BranchName = branchName;
            ProviderType = providerType;
        }

        /// <summary> The unique ID of the trigger. </summary>
        public Guid? Id { get; set; }
        /// <summary> The event type of the trigger. </summary>
        public string EventType { get; set; }
        /// <summary> The unique ID that identifies a commit. </summary>
        public string CommitId { get; set; }
        /// <summary> The unique ID that identifies pull request. </summary>
        public string PullRequestId { get; set; }
        /// <summary> The repository URL. </summary>
        public Uri RepositoryUri { get; set; }
        /// <summary> The branch name in the repository. </summary>
        public string BranchName { get; set; }
        /// <summary> The source control provider type. </summary>
        public string ProviderType { get; set; }
    }
}