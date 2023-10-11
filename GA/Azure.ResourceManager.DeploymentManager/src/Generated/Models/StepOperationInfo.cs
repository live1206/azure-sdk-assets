// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Detailed information of a specific step run. </summary>
    public partial class StepOperationInfo
    {
        /// <summary> Initializes a new instance of StepOperationInfo. </summary>
        internal StepOperationInfo()
        {
        }

        /// <summary> Initializes a new instance of StepOperationInfo. </summary>
        /// <param name="deploymentName"> The name of the ARM deployment initiated as part of the step. </param>
        /// <param name="correlationId"> Unique identifier to track the request for ARM-based resources. </param>
        /// <param name="startOn"> Start time of the action in UTC. </param>
        /// <param name="endOn"> End time of the action in UTC. </param>
        /// <param name="lastUpdatedOn"> Last time in UTC this operation was updated. </param>
        /// <param name="error"> The errors, if any, for the action. </param>
        internal StepOperationInfo(string deploymentName, string correlationId, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? lastUpdatedOn, ResponseError error)
        {
            DeploymentName = deploymentName;
            CorrelationId = correlationId;
            StartOn = startOn;
            EndOn = endOn;
            LastUpdatedOn = lastUpdatedOn;
            Error = error;
        }

        /// <summary> The name of the ARM deployment initiated as part of the step. </summary>
        public string DeploymentName { get; }
        /// <summary> Unique identifier to track the request for ARM-based resources. </summary>
        public string CorrelationId { get; }
        /// <summary> Start time of the action in UTC. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of the action in UTC. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Last time in UTC this operation was updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The errors, if any, for the action. </summary>
        public ResponseError Error { get; }
    }
}