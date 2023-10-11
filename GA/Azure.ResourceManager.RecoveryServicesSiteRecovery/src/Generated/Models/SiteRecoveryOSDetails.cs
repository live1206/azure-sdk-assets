// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk Details. </summary>
    public partial class SiteRecoveryOSDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryOSDetails. </summary>
        internal SiteRecoveryOSDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryOSDetails. </summary>
        /// <param name="osType"> VM Disk details. </param>
        /// <param name="productType"> Product type. </param>
        /// <param name="osEdition"> The OSEdition. </param>
        /// <param name="osVersion"> The OS Version. </param>
        /// <param name="osMajorVersion"> The OS Major Version. </param>
        /// <param name="osMinorVersion"> The OS Minor Version. </param>
        internal SiteRecoveryOSDetails(string osType, string productType, string osEdition, string osVersion, string osMajorVersion, string osMinorVersion)
        {
            OSType = osType;
            ProductType = productType;
            OSEdition = osEdition;
            OSVersion = osVersion;
            OSMajorVersion = osMajorVersion;
            OSMinorVersion = osMinorVersion;
        }

        /// <summary> VM Disk details. </summary>
        public string OSType { get; }
        /// <summary> Product type. </summary>
        public string ProductType { get; }
        /// <summary> The OSEdition. </summary>
        public string OSEdition { get; }
        /// <summary> The OS Version. </summary>
        public string OSVersion { get; }
        /// <summary> The OS Major Version. </summary>
        public string OSMajorVersion { get; }
        /// <summary> The OS Minor Version. </summary>
        public string OSMinorVersion { get; }
    }
}