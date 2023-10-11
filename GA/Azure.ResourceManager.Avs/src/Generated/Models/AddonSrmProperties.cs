// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of a Site Recovery Manager (SRM) addon. </summary>
    public partial class AddonSrmProperties : AvsPrivateCloudAddonProperties
    {
        /// <summary> Initializes a new instance of AddonSrmProperties. </summary>
        public AddonSrmProperties()
        {
            AddonType = AddonType.SRM;
        }

        /// <summary> Initializes a new instance of AddonSrmProperties. </summary>
        /// <param name="addonType"> The type of private cloud addon. </param>
        /// <param name="provisioningState"> The state of the addon provisioning. </param>
        /// <param name="licenseKey"> The Site Recovery Manager (SRM) license. </param>
        internal AddonSrmProperties(AddonType addonType, AddonProvisioningState? provisioningState, string licenseKey) : base(addonType, provisioningState)
        {
            LicenseKey = licenseKey;
            AddonType = addonType;
        }

        /// <summary> The Site Recovery Manager (SRM) license. </summary>
        public string LicenseKey { get; set; }
    }
}