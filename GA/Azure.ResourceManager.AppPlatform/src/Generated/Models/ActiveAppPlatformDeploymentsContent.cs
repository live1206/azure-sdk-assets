// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Deployment resource name and set them as active. </summary>
    public partial class ActiveAppPlatformDeploymentsContent
    {
        /// <summary> Initializes a new instance of ActiveAppPlatformDeploymentsContent. </summary>
        public ActiveAppPlatformDeploymentsContent()
        {
            ActiveDeploymentNames = new ChangeTrackingList<string>();
        }

        /// <summary> Collection of Deployment name. </summary>
        public IList<string> ActiveDeploymentNames { get; }
    }
}