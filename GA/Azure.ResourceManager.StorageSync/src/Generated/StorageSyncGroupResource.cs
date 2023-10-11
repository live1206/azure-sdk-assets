// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A Class representing a StorageSyncGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StorageSyncGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStorageSyncGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageSyncServiceResource" /> using the GetStorageSyncGroup method.
    /// </summary>
    public partial class StorageSyncGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageSyncGroupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string syncGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageSyncGroupSyncGroupsClientDiagnostics;
        private readonly SyncGroupsRestOperations _storageSyncGroupSyncGroupsRestClient;
        private readonly StorageSyncGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="StorageSyncGroupResource"/> class for mocking. </summary>
        protected StorageSyncGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StorageSyncGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageSyncGroupResource(ArmClient client, StorageSyncGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSyncGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageSyncGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSyncGroupSyncGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageSyncGroupSyncGroupsApiVersion);
            _storageSyncGroupSyncGroupsRestClient = new SyncGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSyncGroupSyncGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StorageSync/storageSyncServices/syncGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageSyncGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of CloudEndpointResources in the StorageSyncGroup. </summary>
        /// <returns> An object representing collection of CloudEndpointResources and their operations over a CloudEndpointResource. </returns>
        public virtual CloudEndpointCollection GetCloudEndpoints()
        {
            return GetCachedClient(Client => new CloudEndpointCollection(Client, Id));
        }

        /// <summary>
        /// Get a given CloudEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CloudEndpointResource>> GetCloudEndpointAsync(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            return await GetCloudEndpoints().GetAsync(cloudEndpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a given CloudEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<CloudEndpointResource> GetCloudEndpoint(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            return GetCloudEndpoints().Get(cloudEndpointName, cancellationToken);
        }

        /// <summary> Gets a collection of StorageSyncServerEndpointResources in the StorageSyncGroup. </summary>
        /// <returns> An object representing collection of StorageSyncServerEndpointResources and their operations over a StorageSyncServerEndpointResource. </returns>
        public virtual StorageSyncServerEndpointCollection GetStorageSyncServerEndpoints()
        {
            return GetCachedClient(Client => new StorageSyncServerEndpointCollection(Client, Id));
        }

        /// <summary>
        /// Get a ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StorageSyncServerEndpointResource>> GetStorageSyncServerEndpointAsync(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            return await GetStorageSyncServerEndpoints().GetAsync(serverEndpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a ServerEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/serverEndpoints/{serverEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverEndpointName"> Name of Server Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverEndpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<StorageSyncServerEndpointResource> GetStorageSyncServerEndpoint(string serverEndpointName, CancellationToken cancellationToken = default)
        {
            return GetStorageSyncServerEndpoints().Get(serverEndpointName, cancellationToken);
        }

        /// <summary>
        /// Get a given SyncGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageSyncGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncGroupSyncGroupsClientDiagnostics.CreateScope("StorageSyncGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _storageSyncGroupSyncGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given SyncGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageSyncGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncGroupSyncGroupsClientDiagnostics.CreateScope("StorageSyncGroupResource.Get");
            scope.Start();
            try
            {
                var response = _storageSyncGroupSyncGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a given SyncGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncGroupSyncGroupsClientDiagnostics.CreateScope("StorageSyncGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _storageSyncGroupSyncGroupsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a given SyncGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _storageSyncGroupSyncGroupsClientDiagnostics.CreateScope("StorageSyncGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _storageSyncGroupSyncGroupsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StorageSyncArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new SyncGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Sync Group Body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSyncGroupResource>> UpdateAsync(WaitUntil waitUntil, StorageSyncGroupCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncGroupSyncGroupsClientDiagnostics.CreateScope("StorageSyncGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _storageSyncGroupSyncGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<StorageSyncGroupResource>(Response.FromValue(new StorageSyncGroupResource(Client, response), response.GetRawResponse()));
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
        /// Create a new SyncGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Sync Group Body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StorageSyncGroupResource> Update(WaitUntil waitUntil, StorageSyncGroupCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageSyncGroupSyncGroupsClientDiagnostics.CreateScope("StorageSyncGroupResource.Update");
            scope.Start();
            try
            {
                var response = _storageSyncGroupSyncGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new StorageSyncArmOperation<StorageSyncGroupResource>(Response.FromValue(new StorageSyncGroupResource(Client, response), response.GetRawResponse()));
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
    }
}