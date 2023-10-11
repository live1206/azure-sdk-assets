// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Defender for DevOps for Azure DevOps offering. </summary>
    public partial class DefenderForDevOpsAzureDevOpsOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of DefenderForDevOpsAzureDevOpsOffering. </summary>
        public DefenderForDevOpsAzureDevOpsOffering()
        {
            OfferingType = OfferingType.DefenderForDevOpsAzureDevOps;
        }

        /// <summary> Initializes a new instance of DefenderForDevOpsAzureDevOpsOffering. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        internal DefenderForDevOpsAzureDevOpsOffering(OfferingType offeringType, string description) : base(offeringType, description)
        {
            OfferingType = offeringType;
        }
    }
}
