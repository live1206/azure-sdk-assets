// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Monitoring Settings. </summary>
    internal partial class MonitoringSettings
    {
        /// <summary> Initializes a new instance of MonitoringSettings. </summary>
        public MonitoringSettings()
        {
        }

        /// <summary> Initializes a new instance of MonitoringSettings. </summary>
        /// <param name="azureMonitorAlertSettings"> Settings for Azure Monitor based alerts. </param>
        internal MonitoringSettings(AzureMonitorAlertSettings azureMonitorAlertSettings)
        {
            AzureMonitorAlertSettings = azureMonitorAlertSettings;
        }

        /// <summary> Settings for Azure Monitor based alerts. </summary>
        internal AzureMonitorAlertSettings AzureMonitorAlertSettings { get; set; }
        /// <summary> Gets or sets the alert settings for all job failures. </summary>
        public AzureMonitorAlertsState? AlertSettingsForAllJobFailures
        {
            get => AzureMonitorAlertSettings is null ? default : AzureMonitorAlertSettings.AlertSettingsForAllJobFailures;
            set
            {
                if (AzureMonitorAlertSettings is null)
                    AzureMonitorAlertSettings = new AzureMonitorAlertSettings();
                AzureMonitorAlertSettings.AlertSettingsForAllJobFailures = value;
            }
        }
    }
}
