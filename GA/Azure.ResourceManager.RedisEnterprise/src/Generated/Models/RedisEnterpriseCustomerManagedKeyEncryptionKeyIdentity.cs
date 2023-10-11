// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </summary>
    public partial class RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity
    {
        /// <summary> Initializes a new instance of RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity. </summary>
        public RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity()
        {
        }

        /// <summary> Initializes a new instance of RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity. </summary>
        /// <param name="userAssignedIdentityResourceId"> User assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/&lt;sub uuid&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. </param>
        /// <param name="identityType"> Only userAssignedIdentity is supported in this API version; other types may be supported in the future. </param>
        internal RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(ResourceIdentifier userAssignedIdentityResourceId, RedisEnterpriseCustomerManagedKeyIdentityType? identityType)
        {
            UserAssignedIdentityResourceId = userAssignedIdentityResourceId;
            IdentityType = identityType;
        }

        /// <summary> User assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/&lt;sub uuid&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. </summary>
        public ResourceIdentifier UserAssignedIdentityResourceId { get; set; }
        /// <summary> Only userAssignedIdentity is supported in this API version; other types may be supported in the future. </summary>
        public RedisEnterpriseCustomerManagedKeyIdentityType? IdentityType { get; set; }
    }
}