// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Microsoft Defender settings for the security profile. </summary>
    public partial class ManagedClusterSecurityProfileDefender
    {
        /// <summary> Initializes a new instance of ManagedClusterSecurityProfileDefender. </summary>
        public ManagedClusterSecurityProfileDefender()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterSecurityProfileDefender. </summary>
        /// <param name="logAnalyticsWorkspaceResourceId"> Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field empty. </param>
        /// <param name="securityMonitoring"> Microsoft Defender threat detection for Cloud settings for the security profile. </param>
        internal ManagedClusterSecurityProfileDefender(ResourceIdentifier logAnalyticsWorkspaceResourceId, ManagedClusterSecurityProfileDefenderSecurityMonitoring securityMonitoring)
        {
            LogAnalyticsWorkspaceResourceId = logAnalyticsWorkspaceResourceId;
            SecurityMonitoring = securityMonitoring;
        }

        /// <summary> Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field empty. </summary>
        public ResourceIdentifier LogAnalyticsWorkspaceResourceId { get; set; }
        /// <summary> Microsoft Defender threat detection for Cloud settings for the security profile. </summary>
        internal ManagedClusterSecurityProfileDefenderSecurityMonitoring SecurityMonitoring { get; set; }
        /// <summary> Whether to enable Defender threat detection. </summary>
        public bool? IsSecurityMonitoringEnabled
        {
            get => SecurityMonitoring is null ? default : SecurityMonitoring.IsSecurityMonitoringEnabled;
            set
            {
                if (SecurityMonitoring is null)
                    SecurityMonitoring = new ManagedClusterSecurityProfileDefenderSecurityMonitoring();
                SecurityMonitoring.IsSecurityMonitoringEnabled = value;
            }
        }
    }
}