// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ARC autoprovisioning configuration. </summary>
    public partial class DefenderForDatabasesAwsOfferingArcAutoProvisioning
    {
        /// <summary> Initializes a new instance of DefenderForDatabasesAwsOfferingArcAutoProvisioning. </summary>
        public DefenderForDatabasesAwsOfferingArcAutoProvisioning()
        {
        }

        /// <summary> Initializes a new instance of DefenderForDatabasesAwsOfferingArcAutoProvisioning. </summary>
        /// <param name="isEnabled"> Is arc auto provisioning enabled. </param>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        internal DefenderForDatabasesAwsOfferingArcAutoProvisioning(bool? isEnabled, string cloudRoleArn)
        {
            IsEnabled = isEnabled;
            CloudRoleArn = cloudRoleArn;
        }

        /// <summary> Is arc auto provisioning enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
    }
}