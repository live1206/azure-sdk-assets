// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Settings for Azure Monitor based alerts. </summary>
    internal partial class AzureMonitorAlertSettings
    {
        /// <summary> Initializes a new instance of AzureMonitorAlertSettings. </summary>
        public AzureMonitorAlertSettings()
        {
        }

        /// <summary> Initializes a new instance of AzureMonitorAlertSettings. </summary>
        /// <param name="alertsForAllJobFailures"></param>
        internal AzureMonitorAlertSettings(RecoveryServicesAlertsState? alertsForAllJobFailures)
        {
            AlertsForAllJobFailures = alertsForAllJobFailures;
        }

        /// <summary> Gets or sets the alerts for all job failures. </summary>
        public RecoveryServicesAlertsState? AlertsForAllJobFailures { get; set; }
    }
}