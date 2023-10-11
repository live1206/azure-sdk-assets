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
    /// A class representing a collection of <see cref="PublicIPPrefixResource" /> and their operations.
    /// Each <see cref="PublicIPPrefixResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PublicIPPrefixCollection" /> instance call the GetPublicIPPrefixes method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PublicIPPrefixCollection : ArmCollection, IEnumerable<PublicIPPrefixResource>, IAsyncEnumerable<PublicIPPrefixResource>
    {
        private readonly ClientDiagnostics _publicIPPrefixClientDiagnostics;
        private readonly PublicIPPrefixesRestOperations _publicIPPrefixRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublicIPPrefixCollection"/> class for mocking. </summary>
        protected PublicIPPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublicIPPrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublicIPPrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publicIPPrefixClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PublicIPPrefixResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublicIPPrefixResource.ResourceType, out string publicIPPrefixApiVersion);
            _publicIPPrefixRestClient = new PublicIPPrefixesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publicIPPrefixApiVersion);
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
        /// Creates or updates a static or dynamic public IP prefix.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIpPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicIPPrefixName"> The name of the public IP prefix. </param>
        /// <param name="data"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPPrefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PublicIPPrefixResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string publicIPPrefixName, PublicIPPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPPrefixName, nameof(publicIPPrefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _publicIPPrefixClientDiagnostics.CreateScope("PublicIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _publicIPPrefixRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PublicIPPrefixResource>(new PublicIPPrefixOperationSource(Client), _publicIPPrefixClientDiagnostics, Pipeline, _publicIPPrefixRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a static or dynamic public IP prefix.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIpPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicIPPrefixName"> The name of the public IP prefix. </param>
        /// <param name="data"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPPrefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PublicIPPrefixResource> CreateOrUpdate(WaitUntil waitUntil, string publicIPPrefixName, PublicIPPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPPrefixName, nameof(publicIPPrefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _publicIPPrefixClientDiagnostics.CreateScope("PublicIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _publicIPPrefixRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, data, cancellationToken);
                var operation = new NetworkArmOperation<PublicIPPrefixResource>(new PublicIPPrefixOperationSource(Client), _publicIPPrefixClientDiagnostics, Pipeline, _publicIPPrefixRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the specified public IP prefix in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIpPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPPrefixName"/> is null. </exception>
        public virtual async Task<Response<PublicIPPrefixResource>> GetAsync(string publicIPPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPPrefixName, nameof(publicIPPrefixName));

            using var scope = _publicIPPrefixClientDiagnostics.CreateScope("PublicIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _publicIPPrefixRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified public IP prefix in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIpPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPPrefixName"/> is null. </exception>
        public virtual Response<PublicIPPrefixResource> Get(string publicIPPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPPrefixName, nameof(publicIPPrefixName));

            using var scope = _publicIPPrefixClientDiagnostics.CreateScope("PublicIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _publicIPPrefixRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all public IP prefixes in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublicIPPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublicIPPrefixResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publicIPPrefixRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publicIPPrefixRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublicIPPrefixResource(Client, PublicIPPrefixData.DeserializePublicIPPrefixData(e)), _publicIPPrefixClientDiagnostics, Pipeline, "PublicIPPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all public IP prefixes in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublicIPPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublicIPPrefixResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publicIPPrefixRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publicIPPrefixRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublicIPPrefixResource(Client, PublicIPPrefixData.DeserializePublicIPPrefixData(e)), _publicIPPrefixClientDiagnostics, Pipeline, "PublicIPPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIpPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPPrefixName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publicIPPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPPrefixName, nameof(publicIPPrefixName));

            using var scope = _publicIPPrefixClientDiagnostics.CreateScope("PublicIPPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publicIPPrefixRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIpPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPPrefixName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicIPPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPPrefixName, nameof(publicIPPrefixName));

            using var scope = _publicIPPrefixClientDiagnostics.CreateScope("PublicIPPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = _publicIPPrefixRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIPPrefixName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublicIPPrefixResource> IEnumerable<PublicIPPrefixResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublicIPPrefixResource> IAsyncEnumerable<PublicIPPrefixResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}