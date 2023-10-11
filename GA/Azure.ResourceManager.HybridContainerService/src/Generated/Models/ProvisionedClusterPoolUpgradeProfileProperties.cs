// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The upgrade properties. </summary>
    public partial class ProvisionedClusterPoolUpgradeProfileProperties
    {
        /// <summary> Initializes a new instance of ProvisionedClusterPoolUpgradeProfileProperties. </summary>
        public ProvisionedClusterPoolUpgradeProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of ProvisionedClusterPoolUpgradeProfileProperties. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="isPreview"> Whether the Kubernetes version is currently in preview. </param>
        internal ProvisionedClusterPoolUpgradeProfileProperties(string kubernetesVersion, bool? isPreview)
        {
            KubernetesVersion = kubernetesVersion;
            IsPreview = isPreview;
        }

        /// <summary> The Kubernetes version (major.minor.patch). </summary>
        public string KubernetesVersion { get; }
        /// <summary> Whether the Kubernetes version is currently in preview. </summary>
        public bool? IsPreview { get; }
    }
}