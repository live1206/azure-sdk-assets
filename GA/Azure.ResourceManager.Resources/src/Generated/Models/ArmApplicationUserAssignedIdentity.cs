// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Represents the user assigned identity that is contained within the UserAssignedIdentities dictionary on ResourceIdentity. </summary>
    public partial class ArmApplicationUserAssignedIdentity
    {
        /// <summary> Initializes a new instance of ArmApplicationUserAssignedIdentity. </summary>
        public ArmApplicationUserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of ArmApplicationUserAssignedIdentity. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="tenantId"> The tenant id of user assigned identity. </param>
        internal ArmApplicationUserAssignedIdentity(Guid? principalId, Guid? tenantId)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The tenant id of user assigned identity. </summary>
        public Guid? TenantId { get; }
    }
}
