// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Progress representation of the update run steps. </summary>
    public partial class HciUpdateStep
    {
        /// <summary> Initializes a new instance of HciUpdateStep. </summary>
        public HciUpdateStep()
        {
            Steps = new ChangeTrackingList<HciUpdateStep>();
        }

        /// <summary> Initializes a new instance of HciUpdateStep. </summary>
        /// <param name="name"> Name of the step. </param>
        /// <param name="description"> More detailed description of the step. </param>
        /// <param name="errorMessage"> Error message, specified if the step is in a failed state. </param>
        /// <param name="status"> Status of the step, bubbled up from the ECE action plan for installation attempts. Values are: 'Success', 'Error', 'InProgress', and 'Unknown status'. </param>
        /// <param name="startTimeUtc"> When the step started, or empty if it has not started executing. </param>
        /// <param name="endTimeUtc"> When the step reached a terminal state. </param>
        /// <param name="lastUpdatedTimeUtc"> Completion time of this step or the last completed sub-step. </param>
        /// <param name="steps"> Recursive model for child steps of this step. </param>
        internal HciUpdateStep(string name, string description, string errorMessage, string status, DateTimeOffset? startTimeUtc, DateTimeOffset? endTimeUtc, DateTimeOffset? lastUpdatedTimeUtc, IList<HciUpdateStep> steps)
        {
            Name = name;
            Description = description;
            ErrorMessage = errorMessage;
            Status = status;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            Steps = steps;
        }

        /// <summary> Name of the step. </summary>
        public string Name { get; set; }
        /// <summary> More detailed description of the step. </summary>
        public string Description { get; set; }
        /// <summary> Error message, specified if the step is in a failed state. </summary>
        public string ErrorMessage { get; set; }
        /// <summary> Status of the step, bubbled up from the ECE action plan for installation attempts. Values are: 'Success', 'Error', 'InProgress', and 'Unknown status'. </summary>
        public string Status { get; set; }
        /// <summary> When the step started, or empty if it has not started executing. </summary>
        public DateTimeOffset? StartTimeUtc { get; set; }
        /// <summary> When the step reached a terminal state. </summary>
        public DateTimeOffset? EndTimeUtc { get; set; }
        /// <summary> Completion time of this step or the last completed sub-step. </summary>
        public DateTimeOffset? LastUpdatedTimeUtc { get; set; }
        /// <summary> Recursive model for child steps of this step. </summary>
        public IList<HciUpdateStep> Steps { get; }
    }
}