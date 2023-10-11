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

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageSyncPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="StorageSyncPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="StorageSyncServiceResource" />.
    /// To get a <see cref="StorageSyncPrivateEndpointConnectionCollection" /> instance call the GetStorageSyncPrivateEndpointConnections method from an instance of <see cref="StorageSyncServiceResource" />.
    /// </summary>
    public partial class StorageSyncPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<StorageSyncPrivateEndpointConnectionResource>, IAsyncEnumerable<StorageSyncPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected StorageSyncPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageSyncPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", StorageSyncPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageSyncPrivateEndpointConnectionResource.ResourceType, out string storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageSyncServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageSyncServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update the state of specified private endpoint connection associated with the storage sync service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, StorageSyncPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("StorageSyncPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncPrivateEndpointConnectionResource>(new StorageSyncPrivateEndpointConnectionOperationSource(Client), _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the state of specified private endpoint connection associated with the storage sync service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageSyncPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, StorageSyncPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("StorageSyncPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncPrivateEndpointConnectionResource>(new StorageSyncPrivateEndpointConnectionOperationSource(Client), _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the specified private endpoint connection associated with the storage sync service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<StorageSyncPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("StorageSyncPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the storage sync service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<StorageSyncPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("StorageSyncPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PrivateEndpointConnection List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByStorageSyncService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSyncPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByStorageSyncServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new StorageSyncPrivateEndpointConnectionResource(Client, StorageSyncPrivateEndpointConnectionData.DeserializeStorageSyncPrivateEndpointConnectionData(e)), _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "StorageSyncPrivateEndpointConnectionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a PrivateEndpointConnection List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByStorageSyncService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSyncPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByStorageSyncServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new StorageSyncPrivateEndpointConnectionResource(Client, StorageSyncPrivateEndpointConnectionData.DeserializeStorageSyncPrivateEndpointConnectionData(e)), _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "StorageSyncPrivateEndpointConnectionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("StorageSyncPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("StorageSyncPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageSyncPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageSyncPrivateEndpointConnectionResource> IEnumerable<StorageSyncPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageSyncPrivateEndpointConnectionResource> IAsyncEnumerable<StorageSyncPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}