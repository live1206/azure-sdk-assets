// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The RDS configuration. </summary>
    public partial class DefenderForDatabasesAwsOfferingRds
    {
        /// <summary> Initializes a new instance of DefenderForDatabasesAwsOfferingRds. </summary>
        public DefenderForDatabasesAwsOfferingRds()
        {
        }

        /// <summary> Initializes a new instance of DefenderForDatabasesAwsOfferingRds. </summary>
        /// <param name="isEnabled"> Is RDS protection enabled. </param>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        internal DefenderForDatabasesAwsOfferingRds(bool? isEnabled, string cloudRoleArn)
        {
            IsEnabled = isEnabled;
            CloudRoleArn = cloudRoleArn;
        }

        /// <summary> Is RDS protection enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
    }
}