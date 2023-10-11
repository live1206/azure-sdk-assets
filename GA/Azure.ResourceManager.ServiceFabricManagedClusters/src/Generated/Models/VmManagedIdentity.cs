// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Identities for the virtual machine scale set under the node type. </summary>
    internal partial class VmManagedIdentity
    {
        /// <summary> Initializes a new instance of VmManagedIdentity. </summary>
        public VmManagedIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of VmManagedIdentity. </summary>
        /// <param name="userAssignedIdentities"> The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </param>
        internal VmManagedIdentity(IList<ResourceIdentifier> userAssignedIdentities)
        {
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </summary>
        public IList<ResourceIdentifier> UserAssignedIdentities { get; }
    }
}