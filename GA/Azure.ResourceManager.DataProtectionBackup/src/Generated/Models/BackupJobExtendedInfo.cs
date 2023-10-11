// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Extended Information about the job. </summary>
    public partial class BackupJobExtendedInfo
    {
        /// <summary> Initializes a new instance of BackupJobExtendedInfo. </summary>
        internal BackupJobExtendedInfo()
        {
            AdditionalDetails = new ChangeTrackingDictionary<string, string>();
            SubTasks = new ChangeTrackingList<BackupJobSubTask>();
        }

        /// <summary> Initializes a new instance of BackupJobExtendedInfo. </summary>
        /// <param name="additionalDetails"> Job's Additional Details. </param>
        /// <param name="backupInstanceState"> State of the Backup Instance. </param>
        /// <param name="dataTransferredInBytes"> Number of bytes transferred. </param>
        /// <param name="recoveryDestination"> Destination where restore is done. </param>
        /// <param name="sourceRecoverPoint"> Details of the Source Recovery Point. </param>
        /// <param name="subTasks"> List of Sub Tasks of the job. </param>
        /// <param name="targetRecoverPoint"> Details of the Target Recovery Point. </param>
        internal BackupJobExtendedInfo(IReadOnlyDictionary<string, string> additionalDetails, string backupInstanceState, double? dataTransferredInBytes, string recoveryDestination, RestoreJobRecoveryPointDetails sourceRecoverPoint, IReadOnlyList<BackupJobSubTask> subTasks, RestoreJobRecoveryPointDetails targetRecoverPoint)
        {
            AdditionalDetails = additionalDetails;
            BackupInstanceState = backupInstanceState;
            DataTransferredInBytes = dataTransferredInBytes;
            RecoveryDestination = recoveryDestination;
            SourceRecoverPoint = sourceRecoverPoint;
            SubTasks = subTasks;
            TargetRecoverPoint = targetRecoverPoint;
        }

        /// <summary> Job's Additional Details. </summary>
        public IReadOnlyDictionary<string, string> AdditionalDetails { get; }
        /// <summary> State of the Backup Instance. </summary>
        public string BackupInstanceState { get; }
        /// <summary> Number of bytes transferred. </summary>
        public double? DataTransferredInBytes { get; }
        /// <summary> Destination where restore is done. </summary>
        public string RecoveryDestination { get; }
        /// <summary> Details of the Source Recovery Point. </summary>
        public RestoreJobRecoveryPointDetails SourceRecoverPoint { get; }
        /// <summary> List of Sub Tasks of the job. </summary>
        public IReadOnlyList<BackupJobSubTask> SubTasks { get; }
        /// <summary> Details of the Target Recovery Point. </summary>
        public RestoreJobRecoveryPointDetails TargetRecoverPoint { get; }
    }
}