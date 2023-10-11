// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Backup Vault Contract for Patch Backup Vault API. </summary>
    public partial class DataProtectionBackupVaultPatchProperties
    {
        /// <summary> Initializes a new instance of DataProtectionBackupVaultPatchProperties. </summary>
        public DataProtectionBackupVaultPatchProperties()
        {
        }

        /// <summary> Monitoring Settings. </summary>
        internal MonitoringSettings MonitoringSettings { get; set; }
        /// <summary> Gets or sets the alert settings for all job failures. </summary>
        public AzureMonitorAlertsState? AlertSettingsForAllJobFailures
        {
            get => MonitoringSettings is null ? default : MonitoringSettings.AlertSettingsForAllJobFailures;
            set
            {
                if (MonitoringSettings is null)
                    MonitoringSettings = new MonitoringSettings();
                MonitoringSettings.AlertSettingsForAllJobFailures = value;
            }
        }

        /// <summary> Security Settings. </summary>
        public BackupVaultSecuritySettings SecuritySettings { get; set; }
        /// <summary> Feature Settings. </summary>
        public BackupVaultFeatureSettings FeatureSettings { get; set; }
    }
}