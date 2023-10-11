// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Encryption-at-rest configuration for the cluster. </summary>
    internal partial class ClusterPropertiesEncryption
    {
        /// <summary> Initializes a new instance of ClusterPropertiesEncryption. </summary>
        public ClusterPropertiesEncryption()
        {
        }

        /// <summary> Initializes a new instance of ClusterPropertiesEncryption. </summary>
        /// <param name="customerManagedKeyEncryption"> All Customer-managed key encryption properties for the resource. Set this to an empty object to use Microsoft-managed key encryption. </param>
        internal ClusterPropertiesEncryption(RedisEnterpriseCustomerManagedKeyEncryption customerManagedKeyEncryption)
        {
            CustomerManagedKeyEncryption = customerManagedKeyEncryption;
        }

        /// <summary> All Customer-managed key encryption properties for the resource. Set this to an empty object to use Microsoft-managed key encryption. </summary>
        public RedisEnterpriseCustomerManagedKeyEncryption CustomerManagedKeyEncryption { get; set; }
    }
}
