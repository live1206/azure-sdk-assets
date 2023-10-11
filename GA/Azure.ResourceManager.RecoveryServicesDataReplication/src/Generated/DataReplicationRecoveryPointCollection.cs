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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationRecoveryPointResource" /> and their operations.
    /// Each <see cref="DataReplicationRecoveryPointResource" /> in the collection will belong to the same instance of <see cref="DataReplicationProtectedItemResource" />.
    /// To get a <see cref="DataReplicationRecoveryPointCollection" /> instance call the GetDataReplicationRecoveryPoints method from an instance of <see cref="DataReplicationProtectedItemResource" />.
    /// </summary>
    public partial class DataReplicationRecoveryPointCollection : ArmCollection, IEnumerable<DataReplicationRecoveryPointResource>, IAsyncEnumerable<DataReplicationRecoveryPointResource>
    {
        private readonly ClientDiagnostics _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics;
        private readonly RecoveryPointsRestOperations _dataReplicationRecoveryPointRecoveryPointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationRecoveryPointCollection"/> class for mocking. </summary>
        protected DataReplicationRecoveryPointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationRecoveryPointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationRecoveryPointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationRecoveryPointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationRecoveryPointResource.ResourceType, out string dataReplicationRecoveryPointRecoveryPointsApiVersion);
            _dataReplicationRecoveryPointRecoveryPointsRestClient = new RecoveryPointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationRecoveryPointRecoveryPointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataReplicationProtectedItemResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataReplicationProtectedItemResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of the recovery point of a protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointName"> The recovery point name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationRecoveryPointResource>> GetAsync(string recoveryPointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointName, nameof(recoveryPointName));

            using var scope = _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataReplicationRecoveryPointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the recovery point of a protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointName"> The recovery point name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointName"/> is null. </exception>
        public virtual Response<DataReplicationRecoveryPointResource> Get(string recoveryPointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointName, nameof(recoveryPointName));

            using var scope = _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataReplicationRecoveryPointCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of recovery points of the given protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}/recoveryPoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationRecoveryPointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationRecoveryPointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationRecoveryPointRecoveryPointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationRecoveryPointRecoveryPointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataReplicationRecoveryPointResource(Client, DataReplicationRecoveryPointData.DeserializeDataReplicationRecoveryPointData(e)), _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics, Pipeline, "DataReplicationRecoveryPointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of recovery points of the given protected item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}/recoveryPoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationRecoveryPointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationRecoveryPointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationRecoveryPointRecoveryPointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationRecoveryPointRecoveryPointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataReplicationRecoveryPointResource(Client, DataReplicationRecoveryPointData.DeserializeDataReplicationRecoveryPointData(e)), _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics, Pipeline, "DataReplicationRecoveryPointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointName"> The recovery point name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recoveryPointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointName, nameof(recoveryPointName));

            using var scope = _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataReplicationRecoveryPointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointName"> The recovery point name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointName"/> is null. </exception>
        public virtual Response<bool> Exists(string recoveryPointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointName, nameof(recoveryPointName));

            using var scope = _dataReplicationRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("DataReplicationRecoveryPointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recoveryPointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationRecoveryPointResource> IEnumerable<DataReplicationRecoveryPointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationRecoveryPointResource> IAsyncEnumerable<DataReplicationRecoveryPointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}