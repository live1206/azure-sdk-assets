// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerJobExecution data model.
    /// An execution of a job
    /// </summary>
    public partial class SqlServerJobExecutionData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlServerJobExecutionData. </summary>
        public SqlServerJobExecutionData()
        {
        }

        /// <summary> Initializes a new instance of SqlServerJobExecutionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="jobVersion"> The job version number. </param>
        /// <param name="stepName"> The job step name. </param>
        /// <param name="stepId"> The job step id. </param>
        /// <param name="jobExecutionId"> The unique identifier of the job execution. </param>
        /// <param name="lifecycle"> The detailed state of the job execution. </param>
        /// <param name="provisioningState"> The ARM provisioning state of the job execution. </param>
        /// <param name="createOn"> The time that the job execution was created. </param>
        /// <param name="startOn"> The time that the job execution started. </param>
        /// <param name="endOn"> The time that the job execution completed. </param>
        /// <param name="currentAttempts"> Number of times the job execution has been attempted. </param>
        /// <param name="currentAttemptStartOn"> Start time of the current attempt. </param>
        /// <param name="lastMessage"> The last status or error message. </param>
        /// <param name="target"> The target that this execution is executed on. </param>
        internal SqlServerJobExecutionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? jobVersion, string stepName, int? stepId, Guid? jobExecutionId, JobExecutionLifecycle? lifecycle, JobExecutionProvisioningState? provisioningState, DateTimeOffset? createOn, DateTimeOffset? startOn, DateTimeOffset? endOn, int? currentAttempts, DateTimeOffset? currentAttemptStartOn, string lastMessage, JobExecutionTarget target) : base(id, name, resourceType, systemData)
        {
            JobVersion = jobVersion;
            StepName = stepName;
            StepId = stepId;
            JobExecutionId = jobExecutionId;
            Lifecycle = lifecycle;
            ProvisioningState = provisioningState;
            CreateOn = createOn;
            StartOn = startOn;
            EndOn = endOn;
            CurrentAttempts = currentAttempts;
            CurrentAttemptStartOn = currentAttemptStartOn;
            LastMessage = lastMessage;
            Target = target;
        }

        /// <summary> The job version number. </summary>
        public int? JobVersion { get; }
        /// <summary> The job step name. </summary>
        public string StepName { get; }
        /// <summary> The job step id. </summary>
        public int? StepId { get; }
        /// <summary> The unique identifier of the job execution. </summary>
        public Guid? JobExecutionId { get; }
        /// <summary> The detailed state of the job execution. </summary>
        public JobExecutionLifecycle? Lifecycle { get; }
        /// <summary> The ARM provisioning state of the job execution. </summary>
        public JobExecutionProvisioningState? ProvisioningState { get; }
        /// <summary> The time that the job execution was created. </summary>
        public DateTimeOffset? CreateOn { get; }
        /// <summary> The time that the job execution started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The time that the job execution completed. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Number of times the job execution has been attempted. </summary>
        public int? CurrentAttempts { get; set; }
        /// <summary> Start time of the current attempt. </summary>
        public DateTimeOffset? CurrentAttemptStartOn { get; }
        /// <summary> The last status or error message. </summary>
        public string LastMessage { get; }
        /// <summary> The target that this execution is executed on. </summary>
        public JobExecutionTarget Target { get; }
    }
}