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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkPacketBrokerResource" /> and their operations.
    /// Each <see cref="NetworkPacketBrokerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkPacketBrokerCollection" /> instance call the GetNetworkPacketBrokers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkPacketBrokerCollection : ArmCollection, IEnumerable<NetworkPacketBrokerResource>, IAsyncEnumerable<NetworkPacketBrokerResource>
    {
        private readonly ClientDiagnostics _networkPacketBrokerClientDiagnostics;
        private readonly NetworkPacketBrokersRestOperations _networkPacketBrokerRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkPacketBrokerCollection"/> class for mocking. </summary>
        protected NetworkPacketBrokerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkPacketBrokerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkPacketBrokerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkPacketBrokerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkPacketBrokerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkPacketBrokerResource.ResourceType, out string networkPacketBrokerApiVersion);
            _networkPacketBrokerRestClient = new NetworkPacketBrokersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkPacketBrokerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Network Packet Broker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers/{networkPacketBrokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkPacketBrokerName"> Name of the Network Packet Broker. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkPacketBrokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkPacketBrokerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkPacketBrokerName, NetworkPacketBrokerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkPacketBrokerName, nameof(networkPacketBrokerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkPacketBrokerClientDiagnostics.CreateScope("NetworkPacketBrokerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkPacketBrokerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkPacketBrokerResource>(new NetworkPacketBrokerOperationSource(Client), _networkPacketBrokerClientDiagnostics, Pipeline, _networkPacketBrokerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a Network Packet Broker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers/{networkPacketBrokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkPacketBrokerName"> Name of the Network Packet Broker. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkPacketBrokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkPacketBrokerResource> CreateOrUpdate(WaitUntil waitUntil, string networkPacketBrokerName, NetworkPacketBrokerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkPacketBrokerName, nameof(networkPacketBrokerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkPacketBrokerClientDiagnostics.CreateScope("NetworkPacketBrokerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkPacketBrokerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkPacketBrokerResource>(new NetworkPacketBrokerOperationSource(Client), _networkPacketBrokerClientDiagnostics, Pipeline, _networkPacketBrokerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves details of this Network Packet Broker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers/{networkPacketBrokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkPacketBrokerName"> Name of the Network Packet Broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkPacketBrokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerName"/> is null. </exception>
        public virtual async Task<Response<NetworkPacketBrokerResource>> GetAsync(string networkPacketBrokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkPacketBrokerName, nameof(networkPacketBrokerName));

            using var scope = _networkPacketBrokerClientDiagnostics.CreateScope("NetworkPacketBrokerCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkPacketBrokerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkPacketBrokerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves details of this Network Packet Broker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers/{networkPacketBrokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkPacketBrokerName"> Name of the Network Packet Broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkPacketBrokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerName"/> is null. </exception>
        public virtual Response<NetworkPacketBrokerResource> Get(string networkPacketBrokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkPacketBrokerName, nameof(networkPacketBrokerName));

            using var scope = _networkPacketBrokerClientDiagnostics.CreateScope("NetworkPacketBrokerCollection.Get");
            scope.Start();
            try
            {
                var response = _networkPacketBrokerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkPacketBrokerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays NetworkPacketBrokers list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkPacketBrokerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkPacketBrokerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkPacketBrokerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkPacketBrokerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkPacketBrokerResource(Client, NetworkPacketBrokerData.DeserializeNetworkPacketBrokerData(e)), _networkPacketBrokerClientDiagnostics, Pipeline, "NetworkPacketBrokerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays NetworkPacketBrokers list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkPacketBrokerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkPacketBrokerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkPacketBrokerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkPacketBrokerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkPacketBrokerResource(Client, NetworkPacketBrokerData.DeserializeNetworkPacketBrokerData(e)), _networkPacketBrokerClientDiagnostics, Pipeline, "NetworkPacketBrokerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers/{networkPacketBrokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkPacketBrokerName"> Name of the Network Packet Broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkPacketBrokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkPacketBrokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkPacketBrokerName, nameof(networkPacketBrokerName));

            using var scope = _networkPacketBrokerClientDiagnostics.CreateScope("NetworkPacketBrokerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkPacketBrokerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkPacketBrokers/{networkPacketBrokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkPacketBrokers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkPacketBrokerName"> Name of the Network Packet Broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkPacketBrokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkPacketBrokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkPacketBrokerName, nameof(networkPacketBrokerName));

            using var scope = _networkPacketBrokerClientDiagnostics.CreateScope("NetworkPacketBrokerCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkPacketBrokerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkPacketBrokerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkPacketBrokerResource> IEnumerable<NetworkPacketBrokerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkPacketBrokerResource> IAsyncEnumerable<NetworkPacketBrokerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}