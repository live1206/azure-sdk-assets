// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> Payload to get and set the default account in the given scope. </summary>
    public partial class DefaultPurviewAccountPayload
    {
        /// <summary> Initializes a new instance of DefaultPurviewAccountPayload. </summary>
        public DefaultPurviewAccountPayload()
        {
        }

        /// <summary> Initializes a new instance of DefaultPurviewAccountPayload. </summary>
        /// <param name="accountName"> The name of the account that is set as the default. </param>
        /// <param name="resourceGroupName"> The resource group name of the account that is set as the default. </param>
        /// <param name="scope"> The scope object ID. For example, sub ID or tenant ID. </param>
        /// <param name="scopeTenantId"> The scope tenant in which the default account is set. </param>
        /// <param name="scopeType"> The scope where the default account is set. </param>
        /// <param name="subscriptionId"> The subscription ID of the account that is set as the default. </param>
        internal DefaultPurviewAccountPayload(string accountName, string resourceGroupName, string scope, Guid? scopeTenantId, PurviewAccountScopeType? scopeType, string subscriptionId)
        {
            AccountName = accountName;
            ResourceGroupName = resourceGroupName;
            Scope = scope;
            ScopeTenantId = scopeTenantId;
            ScopeType = scopeType;
            SubscriptionId = subscriptionId;
        }

        /// <summary> The name of the account that is set as the default. </summary>
        public string AccountName { get; set; }
        /// <summary> The resource group name of the account that is set as the default. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> The scope object ID. For example, sub ID or tenant ID. </summary>
        public string Scope { get; set; }
        /// <summary> The scope tenant in which the default account is set. </summary>
        public Guid? ScopeTenantId { get; set; }
        /// <summary> The scope where the default account is set. </summary>
        public PurviewAccountScopeType? ScopeType { get; set; }
        /// <summary> The subscription ID of the account that is set as the default. </summary>
        public string SubscriptionId { get; set; }
    }
}