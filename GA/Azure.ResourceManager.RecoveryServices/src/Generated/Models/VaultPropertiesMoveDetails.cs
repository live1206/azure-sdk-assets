// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The details of the latest move operation performed on the Azure Resource. </summary>
    public partial class VaultPropertiesMoveDetails
    {
        /// <summary> Initializes a new instance of VaultPropertiesMoveDetails. </summary>
        public VaultPropertiesMoveDetails()
        {
        }

        /// <summary> Initializes a new instance of VaultPropertiesMoveDetails. </summary>
        /// <param name="operationId"> OperationId of the Resource Move Operation. </param>
        /// <param name="startOn"> Start Time of the Resource Move Operation. </param>
        /// <param name="completedOn"> End Time of the Resource Move Operation. </param>
        /// <param name="sourceResourceId"> Source Resource of the Resource Move Operation. </param>
        /// <param name="targetResourceId"> Target Resource of the Resource Move Operation. </param>
        internal VaultPropertiesMoveDetails(string operationId, DateTimeOffset? startOn, DateTimeOffset? completedOn, ResourceIdentifier sourceResourceId, ResourceIdentifier targetResourceId)
        {
            OperationId = operationId;
            StartOn = startOn;
            CompletedOn = completedOn;
            SourceResourceId = sourceResourceId;
            TargetResourceId = targetResourceId;
        }

        /// <summary> OperationId of the Resource Move Operation. </summary>
        public string OperationId { get; }
        /// <summary> Start Time of the Resource Move Operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End Time of the Resource Move Operation. </summary>
        public DateTimeOffset? CompletedOn { get; }
        /// <summary> Source Resource of the Resource Move Operation. </summary>
        public ResourceIdentifier SourceResourceId { get; }
        /// <summary> Target Resource of the Resource Move Operation. </summary>
        public ResourceIdentifier TargetResourceId { get; }
    }
}
