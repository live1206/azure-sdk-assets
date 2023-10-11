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

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmVirtualNetworkResource" /> and their operations.
    /// Each <see cref="ScVmmVirtualNetworkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ScVmmVirtualNetworkCollection" /> instance call the GetScVmmVirtualNetworks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ScVmmVirtualNetworkCollection : ArmCollection, IEnumerable<ScVmmVirtualNetworkResource>, IAsyncEnumerable<ScVmmVirtualNetworkResource>
    {
        private readonly ClientDiagnostics _scVmmVirtualNetworkVirtualNetworksClientDiagnostics;
        private readonly VirtualNetworksRestOperations _scVmmVirtualNetworkVirtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmVirtualNetworkCollection"/> class for mocking. </summary>
        protected ScVmmVirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmVirtualNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmVirtualNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmVirtualNetworkVirtualNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", ScVmmVirtualNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmVirtualNetworkResource.ResourceType, out string scVmmVirtualNetworkVirtualNetworksApiVersion);
            _scVmmVirtualNetworkVirtualNetworksRestClient = new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmVirtualNetworkVirtualNetworksApiVersion);
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
        /// Onboards the ScVmm virtual network as an Azure virtual network resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmVirtualNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkName, ScVmmVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("ScVmmVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualNetworkVirtualNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ArcScVmmArmOperation<ScVmmVirtualNetworkResource>(new ScVmmVirtualNetworkOperationSource(Client), _scVmmVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, _scVmmVirtualNetworkVirtualNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Onboards the ScVmm virtual network as an Azure virtual network resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmVirtualNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkName, ScVmmVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("ScVmmVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmVirtualNetworkVirtualNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data, cancellationToken);
                var operation = new ArcScVmmArmOperation<ScVmmVirtualNetworkResource>(new ScVmmVirtualNetworkOperationSource(Client), _scVmmVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, _scVmmVirtualNetworkVirtualNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements VirtualNetwork GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<ScVmmVirtualNetworkResource>> GetAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _scVmmVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("ScVmmVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualNetworkVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements VirtualNetwork GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<ScVmmVirtualNetworkResource> Get(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _scVmmVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("ScVmmVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmVirtualNetworkVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of VirtualNetworks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmVirtualNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScVmmVirtualNetworkResource(Client, ScVmmVirtualNetworkData.DeserializeScVmmVirtualNetworkData(e)), _scVmmVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, "ScVmmVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of VirtualNetworks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmVirtualNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmVirtualNetworkVirtualNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScVmmVirtualNetworkResource(Client, ScVmmVirtualNetworkData.DeserializeScVmmVirtualNetworkData(e)), _scVmmVirtualNetworkVirtualNetworksClientDiagnostics, Pipeline, "ScVmmVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _scVmmVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("ScVmmVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualNetworkVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _scVmmVirtualNetworkVirtualNetworksClientDiagnostics.CreateScope("ScVmmVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmVirtualNetworkVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmVirtualNetworkResource> IEnumerable<ScVmmVirtualNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmVirtualNetworkResource> IAsyncEnumerable<ScVmmVirtualNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}