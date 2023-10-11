// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Details for upgrading vault. </summary>
    public partial class VaultUpgradeDetails
    {
        /// <summary> Initializes a new instance of VaultUpgradeDetails. </summary>
        public VaultUpgradeDetails()
        {
        }

        /// <summary> Initializes a new instance of VaultUpgradeDetails. </summary>
        /// <param name="operationId"> ID of the vault upgrade operation. </param>
        /// <param name="startOn"> UTC time at which the upgrade operation has started. </param>
        /// <param name="lastUpdatedOn"> UTC time at which the upgrade operation status was last updated. </param>
        /// <param name="endOn"> UTC time at which the upgrade operation has ended. </param>
        /// <param name="status"> Status of the vault upgrade operation. </param>
        /// <param name="message"> Message to the user containing information about the upgrade operation. </param>
        /// <param name="triggerType"> The way the vault upgrade was triggered. </param>
        /// <param name="upgradedResourceId"> Resource ID of the upgraded vault. </param>
        /// <param name="previousResourceId"> Resource ID of the vault before the upgrade. </param>
        internal VaultUpgradeDetails(string operationId, DateTimeOffset? startOn, DateTimeOffset? lastUpdatedOn, DateTimeOffset? endOn, VaultUpgradeState? status, string message, VaultUpgradeTriggerType? triggerType, ResourceIdentifier upgradedResourceId, ResourceIdentifier previousResourceId)
        {
            OperationId = operationId;
            StartOn = startOn;
            LastUpdatedOn = lastUpdatedOn;
            EndOn = endOn;
            Status = status;
            Message = message;
            TriggerType = triggerType;
            UpgradedResourceId = upgradedResourceId;
            PreviousResourceId = previousResourceId;
        }

        /// <summary> ID of the vault upgrade operation. </summary>
        public string OperationId { get; }
        /// <summary> UTC time at which the upgrade operation has started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> UTC time at which the upgrade operation status was last updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> UTC time at which the upgrade operation has ended. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Status of the vault upgrade operation. </summary>
        public VaultUpgradeState? Status { get; }
        /// <summary> Message to the user containing information about the upgrade operation. </summary>
        public string Message { get; }
        /// <summary> The way the vault upgrade was triggered. </summary>
        public VaultUpgradeTriggerType? TriggerType { get; }
        /// <summary> Resource ID of the upgraded vault. </summary>
        public ResourceIdentifier UpgradedResourceId { get; }
        /// <summary> Resource ID of the vault before the upgrade. </summary>
        public ResourceIdentifier PreviousResourceId { get; }
    }
}
