// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleAssignmentScheduleResource" /> and their operations.
    /// Each <see cref="RoleAssignmentScheduleResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleAssignmentScheduleCollection" /> instance call the GetRoleAssignmentSchedules method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleAssignmentScheduleCollection : ArmCollection, IEnumerable<RoleAssignmentScheduleResource>, IAsyncEnumerable<RoleAssignmentScheduleResource>
    {
        private readonly ClientDiagnostics _roleAssignmentScheduleClientDiagnostics;
        private readonly RoleAssignmentSchedulesRestOperations _roleAssignmentScheduleRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleCollection"/> class for mocking. </summary>
        protected RoleAssignmentScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleAssignmentScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleAssignmentScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleAssignmentScheduleResource.ResourceType, out string roleAssignmentScheduleApiVersion);
            _roleAssignmentScheduleRestClient = new RoleAssignmentSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentScheduleApiVersion);
        }

        /// <summary>
        /// Get the specified role assignment schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleName"> The name (guid) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleName"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentScheduleResource>> GetAsync(string roleAssignmentScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleName, nameof(roleAssignmentScheduleName));

            using var scope = _roleAssignmentScheduleClientDiagnostics.CreateScope("RoleAssignmentScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRestClient.GetAsync(Id, roleAssignmentScheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleName"> The name (guid) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleName"/> is null. </exception>
        public virtual Response<RoleAssignmentScheduleResource> Get(string roleAssignmentScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleName, nameof(roleAssignmentScheduleName));

            using var scope = _roleAssignmentScheduleClientDiagnostics.CreateScope("RoleAssignmentScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRestClient.Get(Id, roleAssignmentScheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role assignment schedules for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo('{userId}') to return all role assignment schedules for the current user. Use $filter=asTarget() to return all role assignment schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentScheduleResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleAssignmentScheduleRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleAssignmentScheduleRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoleAssignmentScheduleResource(Client, RoleAssignmentScheduleData.DeserializeRoleAssignmentScheduleData(e)), _roleAssignmentScheduleClientDiagnostics, Pipeline, "RoleAssignmentScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role assignment schedules for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedules at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedules at, above or below the scope for the specified principal. Use $filter=assignedTo('{userId}') to return all role assignment schedules for the current user. Use $filter=asTarget() to return all role assignment schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentScheduleResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleAssignmentScheduleRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleAssignmentScheduleRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoleAssignmentScheduleResource(Client, RoleAssignmentScheduleData.DeserializeRoleAssignmentScheduleData(e)), _roleAssignmentScheduleClientDiagnostics, Pipeline, "RoleAssignmentScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleName"> The name (guid) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleName, nameof(roleAssignmentScheduleName));

            using var scope = _roleAssignmentScheduleClientDiagnostics.CreateScope("RoleAssignmentScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRestClient.GetAsync(Id, roleAssignmentScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleName"> The name (guid) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentScheduleName, nameof(roleAssignmentScheduleName));

            using var scope = _roleAssignmentScheduleClientDiagnostics.CreateScope("RoleAssignmentScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRestClient.Get(Id, roleAssignmentScheduleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleAssignmentScheduleResource> IEnumerable<RoleAssignmentScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentScheduleResource> IAsyncEnumerable<RoleAssignmentScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}