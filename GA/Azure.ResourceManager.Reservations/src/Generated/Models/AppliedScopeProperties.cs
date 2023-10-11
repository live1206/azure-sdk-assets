// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId if AppliedScopeType is ManagementGroup. </summary>
    public partial class AppliedScopeProperties
    {
        /// <summary> Initializes a new instance of AppliedScopeProperties. </summary>
        public AppliedScopeProperties()
        {
        }

        /// <summary> Initializes a new instance of AppliedScopeProperties. </summary>
        /// <param name="tenantId"> Tenant ID where the savings plan should apply benefit. </param>
        /// <param name="managementGroupId"> Fully-qualified identifier of the management group where the benefit must be applied. </param>
        /// <param name="subscriptionId"> Fully-qualified identifier of the subscription. </param>
        /// <param name="resourceGroupId"> Fully-qualified identifier of the resource group. </param>
        /// <param name="displayName"> Display name. </param>
        internal AppliedScopeProperties(Guid? tenantId, ResourceIdentifier managementGroupId, ResourceIdentifier subscriptionId, ResourceIdentifier resourceGroupId, string displayName)
        {
            TenantId = tenantId;
            ManagementGroupId = managementGroupId;
            SubscriptionId = subscriptionId;
            ResourceGroupId = resourceGroupId;
            DisplayName = displayName;
        }

        /// <summary> Tenant ID where the savings plan should apply benefit. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Fully-qualified identifier of the management group where the benefit must be applied. </summary>
        public ResourceIdentifier ManagementGroupId { get; set; }
        /// <summary> Fully-qualified identifier of the subscription. </summary>
        public ResourceIdentifier SubscriptionId { get; set; }
        /// <summary> Fully-qualified identifier of the resource group. </summary>
        public ResourceIdentifier ResourceGroupId { get; set; }
        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
    }
}