// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ContainerRegistryRun data model.
    /// Run resource properties
    /// </summary>
    public partial class ContainerRegistryRunData : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerRegistryRunData. </summary>
        public ContainerRegistryRunData()
        {
            OutputImages = new ChangeTrackingList<ContainerRegistryImageDescriptor>();
            CustomRegistries = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryRunData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="runId"> The unique identifier for the run. </param>
        /// <param name="status"> The current status of the run. </param>
        /// <param name="lastUpdatedOn"> The last updated time for the run. </param>
        /// <param name="runType"> The type of run. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="createdOn"> The time the run was scheduled. </param>
        /// <param name="startOn"> The time the run started. </param>
        /// <param name="finishOn"> The time the run finished. </param>
        /// <param name="outputImages"> The list of all images that were generated from the run. This is applicable if the run generates base image dependencies. </param>
        /// <param name="task"> The task against which run was scheduled. </param>
        /// <param name="imageUpdateTrigger"> The image update trigger that caused the run. This is applicable if the task has base image trigger configured. </param>
        /// <param name="sourceTrigger"> The source trigger that caused the run. </param>
        /// <param name="timerTrigger"> The timer trigger that caused the run. </param>
        /// <param name="platform"> The platform properties against which the run will happen. </param>
        /// <param name="agentConfiguration"> The machine configuration of the run agent. </param>
        /// <param name="sourceRegistryAuth"> The scope of the credentials that were used to login to the source registry during this run. </param>
        /// <param name="customRegistries"> The list of custom registries that were logged in during this run. </param>
        /// <param name="runErrorMessage"> The error message received from backend systems after the run is scheduled. </param>
        /// <param name="updateTriggerToken"> The update trigger token passed for the Run. </param>
        /// <param name="logArtifact"> The image description for the log artifact. </param>
        /// <param name="provisioningState"> The provisioning state of a run. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled or not. </param>
        internal ContainerRegistryRunData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string runId, ContainerRegistryRunStatus? status, DateTimeOffset? lastUpdatedOn, ContainerRegistryRunType? runType, string agentPoolName, DateTimeOffset? createdOn, DateTimeOffset? startOn, DateTimeOffset? finishOn, IList<ContainerRegistryImageDescriptor> outputImages, string task, ContainerRegistryImageUpdateTrigger imageUpdateTrigger, ContainerRegistrySourceTriggerDescriptor sourceTrigger, ContainerRegistryTimerTriggerDescriptor timerTrigger, ContainerRegistryPlatformProperties platform, ContainerRegistryAgentProperties agentConfiguration, string sourceRegistryAuth, IList<string> customRegistries, string runErrorMessage, string updateTriggerToken, ContainerRegistryImageDescriptor logArtifact, ContainerRegistryProvisioningState? provisioningState, bool? isArchiveEnabled) : base(id, name, resourceType, systemData)
        {
            RunId = runId;
            Status = status;
            LastUpdatedOn = lastUpdatedOn;
            RunType = runType;
            AgentPoolName = agentPoolName;
            CreatedOn = createdOn;
            StartOn = startOn;
            FinishOn = finishOn;
            OutputImages = outputImages;
            Task = task;
            ImageUpdateTrigger = imageUpdateTrigger;
            SourceTrigger = sourceTrigger;
            TimerTrigger = timerTrigger;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            SourceRegistryAuth = sourceRegistryAuth;
            CustomRegistries = customRegistries;
            RunErrorMessage = runErrorMessage;
            UpdateTriggerToken = updateTriggerToken;
            LogArtifact = logArtifact;
            ProvisioningState = provisioningState;
            IsArchiveEnabled = isArchiveEnabled;
        }

        /// <summary> The unique identifier for the run. </summary>
        public string RunId { get; set; }
        /// <summary> The current status of the run. </summary>
        public ContainerRegistryRunStatus? Status { get; set; }
        /// <summary> The last updated time for the run. </summary>
        public DateTimeOffset? LastUpdatedOn { get; set; }
        /// <summary> The type of run. </summary>
        public ContainerRegistryRunType? RunType { get; set; }
        /// <summary> The dedicated agent pool for the run. </summary>
        public string AgentPoolName { get; set; }
        /// <summary> The time the run was scheduled. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The time the run started. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The time the run finished. </summary>
        public DateTimeOffset? FinishOn { get; set; }
        /// <summary> The list of all images that were generated from the run. This is applicable if the run generates base image dependencies. </summary>
        public IList<ContainerRegistryImageDescriptor> OutputImages { get; }
        /// <summary> The task against which run was scheduled. </summary>
        public string Task { get; set; }
        /// <summary> The image update trigger that caused the run. This is applicable if the task has base image trigger configured. </summary>
        public ContainerRegistryImageUpdateTrigger ImageUpdateTrigger { get; set; }
        /// <summary> The source trigger that caused the run. </summary>
        public ContainerRegistrySourceTriggerDescriptor SourceTrigger { get; set; }
        /// <summary> The timer trigger that caused the run. </summary>
        public ContainerRegistryTimerTriggerDescriptor TimerTrigger { get; set; }
        /// <summary> The platform properties against which the run will happen. </summary>
        public ContainerRegistryPlatformProperties Platform { get; set; }
        /// <summary> The machine configuration of the run agent. </summary>
        internal ContainerRegistryAgentProperties AgentConfiguration { get; set; }
        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        public int? AgentCpu
        {
            get => AgentConfiguration is null ? default : AgentConfiguration.Cpu;
            set
            {
                if (AgentConfiguration is null)
                    AgentConfiguration = new ContainerRegistryAgentProperties();
                AgentConfiguration.Cpu = value;
            }
        }

        /// <summary> The scope of the credentials that were used to login to the source registry during this run. </summary>
        public string SourceRegistryAuth { get; set; }
        /// <summary> The list of custom registries that were logged in during this run. </summary>
        public IList<string> CustomRegistries { get; }
        /// <summary> The error message received from backend systems after the run is scheduled. </summary>
        public string RunErrorMessage { get; }
        /// <summary> The update trigger token passed for the Run. </summary>
        public string UpdateTriggerToken { get; set; }
        /// <summary> The image description for the log artifact. </summary>
        public ContainerRegistryImageDescriptor LogArtifact { get; }
        /// <summary> The provisioning state of a run. </summary>
        public ContainerRegistryProvisioningState? ProvisioningState { get; set; }
        /// <summary> The value that indicates whether archiving is enabled or not. </summary>
        public bool? IsArchiveEnabled { get; set; }
    }
}