// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The appliance package support URLs. </summary>
    public partial class ArmApplicationPackageSupportUris
    {
        /// <summary> Initializes a new instance of ArmApplicationPackageSupportUris. </summary>
        internal ArmApplicationPackageSupportUris()
        {
        }

        /// <summary> Initializes a new instance of ArmApplicationPackageSupportUris. </summary>
        /// <param name="azurePublicCloudUri"> The public azure support URL. </param>
        /// <param name="azureGovernmentUri"> The government cloud support URL. </param>
        internal ArmApplicationPackageSupportUris(Uri azurePublicCloudUri, Uri azureGovernmentUri)
        {
            AzurePublicCloudUri = azurePublicCloudUri;
            AzureGovernmentUri = azureGovernmentUri;
        }

        /// <summary> The public azure support URL. </summary>
        public Uri AzurePublicCloudUri { get; }
        /// <summary> The government cloud support URL. </summary>
        public Uri AzureGovernmentUri { get; }
    }
}