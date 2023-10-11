// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSStorageStatus defines the observed state of HybridAKSStorage. </summary>
    internal partial class StorageSpacesPropertiesStatus
    {
        /// <summary> Initializes a new instance of StorageSpacesPropertiesStatus. </summary>
        public StorageSpacesPropertiesStatus()
        {
        }

        /// <summary> Initializes a new instance of StorageSpacesPropertiesStatus. </summary>
        /// <param name="provisioningStatus"> Contains Provisioning errors. </param>
        internal StorageSpacesPropertiesStatus(StorageSpacesPropertiesStatusProvisioningStatus provisioningStatus)
        {
            ProvisioningStatus = provisioningStatus;
        }

        /// <summary> Contains Provisioning errors. </summary>
        public StorageSpacesPropertiesStatusProvisioningStatus ProvisioningStatus { get; set; }
    }
}