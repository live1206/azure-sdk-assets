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
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageSyncRegisteredServerResource" /> and their operations.
    /// Each <see cref="StorageSyncRegisteredServerResource" /> in the collection will belong to the same instance of <see cref="StorageSyncServiceResource" />.
    /// To get a <see cref="StorageSyncRegisteredServerCollection" /> instance call the GetStorageSyncRegisteredServers method from an instance of <see cref="StorageSyncServiceResource" />.
    /// </summary>
    public partial class StorageSyncRegisteredServerCollection : ArmCollection, IEnumerable<StorageSyncRegisteredServerResource>, IAsyncEnumerable<StorageSyncRegisteredServerResource>
    {
        private readonly ClientDiagnostics _storageSyncRegisteredServerRegisteredServersClientDiagnostics;
        private readonly RegisteredServersRestOperations _storageSyncRegisteredServerRegisteredServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncRegisteredServerCollection"/> class for mocking. </summary>
        protected StorageSyncRegisteredServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncRegisteredServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageSyncRegisteredServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncRegisteredServerRegisteredServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", StorageSyncRegisteredServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageSyncRegisteredServerResource.ResourceType, out string storageSyncRegisteredServerRegisteredServersApiVersion);
            _storageSyncRegisteredServerRegisteredServersRestClient = new RegisteredServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncRegisteredServerRegisteredServersApiVersion);
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
        /// Add a new registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="content"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncRegisteredServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, Guid serverId, StorageSyncRegisteredServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncRegisteredServerResource>(new StorageSyncRegisteredServerOperationSource(Client), _storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Add a new registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="content"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StorageSyncRegisteredServerResource> CreateOrUpdate(WaitUntil waitUntil, Guid serverId, StorageSyncRegisteredServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncRegisteredServerResource>(new StorageSyncRegisteredServerOperationSource(Client), _storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, _storageSyncRegisteredServerRegisteredServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Get a given registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageSyncRegisteredServerResource>> GetAsync(Guid serverId, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncRegisteredServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given registered server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageSyncRegisteredServerResource> Get(Guid serverId, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerCollection.Get");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncRegisteredServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given registered server list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_ListByStorageSyncService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncRegisteredServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSyncRegisteredServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncRegisteredServerRegisteredServersRestClient.CreateListByStorageSyncServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new StorageSyncRegisteredServerResource(Client, StorageSyncRegisteredServerData.DeserializeStorageSyncRegisteredServerData(e)), _storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, "StorageSyncRegisteredServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a given registered server list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_ListByStorageSyncService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncRegisteredServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSyncRegisteredServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSyncRegisteredServerRegisteredServersRestClient.CreateListByStorageSyncServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new StorageSyncRegisteredServerResource(Client, StorageSyncRegisteredServerData.DeserializeStorageSyncRegisteredServerData(e)), _storageSyncRegisteredServerRegisteredServersClientDiagnostics, Pipeline, "StorageSyncRegisteredServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid serverId, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageSyncRegisteredServerRegisteredServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegisteredServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid serverId, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncRegisteredServerRegisteredServersClientDiagnostics.CreateScope("StorageSyncRegisteredServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageSyncRegisteredServerRegisteredServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageSyncRegisteredServerResource> IEnumerable<StorageSyncRegisteredServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageSyncRegisteredServerResource> IAsyncEnumerable<StorageSyncRegisteredServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}