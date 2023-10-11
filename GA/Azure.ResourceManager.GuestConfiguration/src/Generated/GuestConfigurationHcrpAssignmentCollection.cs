// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="GuestConfigurationHcrpAssignmentResource" /> and their operations.
    /// Each <see cref="GuestConfigurationHcrpAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="GuestConfigurationHcrpAssignmentCollection" /> instance call the GetGuestConfigurationHcrpAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class GuestConfigurationHcrpAssignmentCollection : ArmCollection, IEnumerable<GuestConfigurationHcrpAssignmentResource>, IAsyncEnumerable<GuestConfigurationHcrpAssignmentResource>
    {
        private readonly ClientDiagnostics _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics;
        private readonly GuestConfigurationHcrpAssignmentsRestOperations _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationHcrpAssignmentCollection"/> class for mocking. </summary>
        protected GuestConfigurationHcrpAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationHcrpAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GuestConfigurationHcrpAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", GuestConfigurationHcrpAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GuestConfigurationHcrpAssignmentResource.ResourceType, out string guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsApiVersion);
            _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient = new GuestConfigurationHcrpAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.HybridCompute/machines")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.HybridCompute/machines"), nameof(id));
        }

        /// <summary>
        /// Creates an association between a ARC machine and guest configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="guestConfigurationAssignmentName"> Name of the guest configuration assignment. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GuestConfigurationHcrpAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string guestConfigurationAssignmentName, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, guestConfigurationAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationHcrpAssignmentResource>(Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an association between a ARC machine and guest configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="guestConfigurationAssignmentName"> Name of the guest configuration assignment. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GuestConfigurationHcrpAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string guestConfigurationAssignmentName, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, guestConfigurationAssignmentName, data, cancellationToken);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationHcrpAssignmentResource>(Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual async Task<Response<GuestConfigurationHcrpAssignmentResource>> GetAsync(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, guestConfigurationAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual Response<GuestConfigurationHcrpAssignmentResource> Get(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, guestConfigurationAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationHcrpAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all guest configuration assignments for an ARC machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationHcrpAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationHcrpAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new GuestConfigurationHcrpAssignmentResource(Client, GuestConfigurationAssignmentData.DeserializeGuestConfigurationAssignmentData(e)), _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics, Pipeline, "GuestConfigurationHcrpAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for an ARC machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationHcrpAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationHcrpAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new GuestConfigurationHcrpAssignmentResource(Client, GuestConfigurationAssignmentData.DeserializeGuestConfigurationAssignmentData(e)), _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics, Pipeline, "GuestConfigurationHcrpAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, guestConfigurationAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationHCRPAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsClientDiagnostics.CreateScope("GuestConfigurationHcrpAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _guestConfigurationHcrpAssignmentGuestConfigurationHcrpAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, guestConfigurationAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GuestConfigurationHcrpAssignmentResource> IEnumerable<GuestConfigurationHcrpAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GuestConfigurationHcrpAssignmentResource> IAsyncEnumerable<GuestConfigurationHcrpAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}