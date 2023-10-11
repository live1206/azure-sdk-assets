// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Defender for Databases GCP offering configurations. </summary>
    public partial class DefenderForDatabasesGcpOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of DefenderForDatabasesGcpOffering. </summary>
        public DefenderForDatabasesGcpOffering()
        {
            OfferingType = OfferingType.DefenderForDatabasesGcp;
        }

        /// <summary> Initializes a new instance of DefenderForDatabasesGcpOffering. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="arcAutoProvisioning"> The ARC autoprovisioning configuration. </param>
        /// <param name="defenderForDatabasesArcAutoProvisioning"> The native cloud connection configuration. </param>
        internal DefenderForDatabasesGcpOffering(OfferingType offeringType, string description, DefenderForDatabasesGcpOfferingArcAutoProvisioning arcAutoProvisioning, GcpDefenderForDatabasesArcAutoProvisioning defenderForDatabasesArcAutoProvisioning) : base(offeringType, description)
        {
            ArcAutoProvisioning = arcAutoProvisioning;
            DefenderForDatabasesArcAutoProvisioning = defenderForDatabasesArcAutoProvisioning;
            OfferingType = offeringType;
        }

        /// <summary> The ARC autoprovisioning configuration. </summary>
        internal DefenderForDatabasesGcpOfferingArcAutoProvisioning ArcAutoProvisioning { get; set; }
        /// <summary> Is arc auto provisioning enabled. </summary>
        public bool? IsEnabled
        {
            get => ArcAutoProvisioning is null ? default : ArcAutoProvisioning.IsEnabled;
            set
            {
                if (ArcAutoProvisioning is null)
                    ArcAutoProvisioning = new DefenderForDatabasesGcpOfferingArcAutoProvisioning();
                ArcAutoProvisioning.IsEnabled = value;
            }
        }

        /// <summary> The native cloud connection configuration. </summary>
        public GcpDefenderForDatabasesArcAutoProvisioning DefenderForDatabasesArcAutoProvisioning { get; set; }
    }
}