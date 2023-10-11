// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing the DataProtectionBackupRecoveryPoint data model.
    /// Azure backup recoveryPoint resource
    /// </summary>
    public partial class DataProtectionBackupRecoveryPointData : ResourceData
    {
        /// <summary> Initializes a new instance of DataProtectionBackupRecoveryPointData. </summary>
        public DataProtectionBackupRecoveryPointData()
        {
        }

        /// <summary> Initializes a new instance of DataProtectionBackupRecoveryPointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// AzureBackupRecoveryPointResource properties
        /// Please note <see cref="DataProtectionBackupRecoveryPointProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataProtectionBackupDiscreteRecoveryPointProperties"/>.
        /// </param>
        internal DataProtectionBackupRecoveryPointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataProtectionBackupRecoveryPointProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// AzureBackupRecoveryPointResource properties
        /// Please note <see cref="DataProtectionBackupRecoveryPointProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataProtectionBackupDiscreteRecoveryPointProperties"/>.
        /// </summary>
        public DataProtectionBackupRecoveryPointProperties Properties { get; set; }
    }
}