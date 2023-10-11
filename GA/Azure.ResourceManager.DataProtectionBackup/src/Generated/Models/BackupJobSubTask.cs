// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Details of Job's Sub Task. </summary>
    public partial class BackupJobSubTask
    {
        /// <summary> Initializes a new instance of BackupJobSubTask. </summary>
        /// <param name="taskId"> Task Id of the Sub Task. </param>
        /// <param name="taskName"> Name of the Sub Task. </param>
        /// <param name="taskStatus"> Status of the Sub Task. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="taskStatus"/> is null. </exception>
        internal BackupJobSubTask(int taskId, string taskName, string taskStatus)
        {
            Argument.AssertNotNull(taskName, nameof(taskName));
            Argument.AssertNotNull(taskStatus, nameof(taskStatus));

            AdditionalDetails = new ChangeTrackingDictionary<string, string>();
            TaskId = taskId;
            TaskName = taskName;
            TaskStatus = taskStatus;
        }

        /// <summary> Initializes a new instance of BackupJobSubTask. </summary>
        /// <param name="additionalDetails"> Additional details of Sub Tasks. </param>
        /// <param name="taskId"> Task Id of the Sub Task. </param>
        /// <param name="taskName"> Name of the Sub Task. </param>
        /// <param name="taskProgress"> Progress of the Sub Task. </param>
        /// <param name="taskStatus"> Status of the Sub Task. </param>
        internal BackupJobSubTask(IReadOnlyDictionary<string, string> additionalDetails, int taskId, string taskName, string taskProgress, string taskStatus)
        {
            AdditionalDetails = additionalDetails;
            TaskId = taskId;
            TaskName = taskName;
            TaskProgress = taskProgress;
            TaskStatus = taskStatus;
        }

        /// <summary> Additional details of Sub Tasks. </summary>
        public IReadOnlyDictionary<string, string> AdditionalDetails { get; }
        /// <summary> Task Id of the Sub Task. </summary>
        public int TaskId { get; }
        /// <summary> Name of the Sub Task. </summary>
        public string TaskName { get; }
        /// <summary> Progress of the Sub Task. </summary>
        public string TaskProgress { get; }
        /// <summary> Status of the Sub Task. </summary>
        public string TaskStatus { get; }
    }
}