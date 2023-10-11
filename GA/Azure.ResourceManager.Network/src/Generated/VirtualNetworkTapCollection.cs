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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkTapResource" /> and their operations.
    /// Each <see cref="VirtualNetworkTapResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VirtualNetworkTapCollection" /> instance call the GetVirtualNetworkTaps method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VirtualNetworkTapCollection : ArmCollection, IEnumerable<VirtualNetworkTapResource>, IAsyncEnumerable<VirtualNetworkTapResource>
    {
        private readonly ClientDiagnostics _virtualNetworkTapClientDiagnostics;
        private readonly VirtualNetworkTapsRestOperations _virtualNetworkTapRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkTapCollection"/> class for mocking. </summary>
        protected VirtualNetworkTapCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkTapCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkTapCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkTapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkTapResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkTapResource.ResourceType, out string virtualNetworkTapApiVersion);
            _virtualNetworkTapRestClient = new VirtualNetworkTapsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkTapApiVersion);
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
        /// Creates or updates a Virtual Network Tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps/{tapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkTapResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tapName, VirtualNetworkTapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapName, nameof(tapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkTapClientDiagnostics.CreateScope("VirtualNetworkTapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkTapRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, tapName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualNetworkTapResource>(new VirtualNetworkTapOperationSource(Client), _virtualNetworkTapClientDiagnostics, Pipeline, _virtualNetworkTapRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, tapName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Virtual Network Tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps/{tapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkTapResource> CreateOrUpdate(WaitUntil waitUntil, string tapName, VirtualNetworkTapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapName, nameof(tapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkTapClientDiagnostics.CreateScope("VirtualNetworkTapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkTapRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, tapName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualNetworkTapResource>(new VirtualNetworkTapOperationSource(Client), _virtualNetworkTapClientDiagnostics, Pipeline, _virtualNetworkTapRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, tapName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified virtual network tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps/{tapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkTapResource>> GetAsync(string tapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapName, nameof(tapName));

            using var scope = _virtualNetworkTapClientDiagnostics.CreateScope("VirtualNetworkTapCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkTapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, tapName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkTapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified virtual network tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps/{tapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual Response<VirtualNetworkTapResource> Get(string tapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapName, nameof(tapName));

            using var scope = _virtualNetworkTapClientDiagnostics.CreateScope("VirtualNetworkTapCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkTapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, tapName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkTapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the VirtualNetworkTaps in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkTapResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkTapResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkTapRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkTapRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkTapResource(Client, VirtualNetworkTapData.DeserializeVirtualNetworkTapData(e)), _virtualNetworkTapClientDiagnostics, Pipeline, "VirtualNetworkTapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the VirtualNetworkTaps in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkTapResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkTapResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkTapRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkTapRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkTapResource(Client, VirtualNetworkTapData.DeserializeVirtualNetworkTapData(e)), _virtualNetworkTapClientDiagnostics, Pipeline, "VirtualNetworkTapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps/{tapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapName, nameof(tapName));

            using var scope = _virtualNetworkTapClientDiagnostics.CreateScope("VirtualNetworkTapCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkTapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, tapName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkTaps/{tapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual Response<bool> Exists(string tapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapName, nameof(tapName));

            using var scope = _virtualNetworkTapClientDiagnostics.CreateScope("VirtualNetworkTapCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualNetworkTapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, tapName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkTapResource> IEnumerable<VirtualNetworkTapResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkTapResource> IAsyncEnumerable<VirtualNetworkTapResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}