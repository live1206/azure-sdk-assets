// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager
{
    public partial class ArmResource
    {
        /// <summary> Gets a collection of PolicyAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of PolicyAssignmentResources and their operations over a PolicyAssignmentResource. </returns>
        public virtual PolicyAssignmentCollection GetPolicyAssignments()
        {
            return GetCachedClient(Client => new PolicyAssignmentCollection(Client, Id));
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PolicyAssignmentResource>> GetPolicyAssignmentAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            return await GetPolicyAssignments().GetAsync(policyAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PolicyAssignmentResource> GetPolicyAssignment(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            return GetPolicyAssignments().Get(policyAssignmentName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagementLockResources in the ArmResource. </summary>
        /// <returns> An object representing collection of ManagementLockResources and their operations over a ManagementLockResource. </returns>
        public virtual ManagementLockCollection GetManagementLocks()
        {
            return GetCachedClient(Client => new ManagementLockCollection(Client, Id));
        }

        /// <summary>
        /// Get a management lock by scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagementLockResource>> GetManagementLockAsync(string lockName, CancellationToken cancellationToken = default)
        {
            return await GetManagementLocks().GetAsync(lockName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a management lock by scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagementLockResource> GetManagementLock(string lockName, CancellationToken cancellationToken = default)
        {
            return GetManagementLocks().Get(lockName, cancellationToken);
        }
    }
}