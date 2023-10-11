// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Defender for Databases AWS offering. </summary>
    public partial class DefenderForDatabasesAwsOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of DefenderForDatabasesAwsOffering. </summary>
        public DefenderForDatabasesAwsOffering()
        {
            OfferingType = OfferingType.DefenderForDatabasesAws;
        }

        /// <summary> Initializes a new instance of DefenderForDatabasesAwsOffering. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="arcAutoProvisioning"> The ARC autoprovisioning configuration. </param>
        /// <param name="rds"> The RDS configuration. </param>
        internal DefenderForDatabasesAwsOffering(OfferingType offeringType, string description, DefenderForDatabasesAwsOfferingArcAutoProvisioning arcAutoProvisioning, DefenderForDatabasesAwsOfferingRds rds) : base(offeringType, description)
        {
            ArcAutoProvisioning = arcAutoProvisioning;
            Rds = rds;
            OfferingType = offeringType;
        }

        /// <summary> The ARC autoprovisioning configuration. </summary>
        public DefenderForDatabasesAwsOfferingArcAutoProvisioning ArcAutoProvisioning { get; set; }
        /// <summary> The RDS configuration. </summary>
        public DefenderForDatabasesAwsOfferingRds Rds { get; set; }
    }
}