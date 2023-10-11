// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Patchable properties of the Cloud HSM Cluster. </summary>
    public partial class CloudHsmClusterPatch
    {
        /// <summary> Initializes a new instance of CloudHsmClusterPatch. </summary>
        public CloudHsmClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Cloud HSM Cluster's tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> SKU details. </summary>
        public CloudHsmClusterSku Sku { get; set; }
    }
}