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

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsResolverResource" /> and their operations.
    /// Each <see cref="DnsResolverResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DnsResolverCollection" /> instance call the GetDnsResolvers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DnsResolverCollection : ArmCollection, IEnumerable<DnsResolverResource>, IAsyncEnumerable<DnsResolverResource>
    {
        private readonly ClientDiagnostics _dnsResolverClientDiagnostics;
        private readonly DnsResolversRestOperations _dnsResolverRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsResolverCollection"/> class for mocking. </summary>
        protected DnsResolverCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsResolverCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsResolverCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsResolverClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsResolverResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsResolverResource.ResourceType, out string dnsResolverApiVersion);
            _dnsResolverRestClient = new DnsResolversRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsResolverApiVersion);
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
        /// Creates or updates a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsResolverName"> The name of the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsResolverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsResolverResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dnsResolverName, DnsResolverData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsResolverName, nameof(dnsResolverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverClientDiagnostics.CreateScope("DnsResolverCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsResolverRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsResolverResource>(new DnsResolverOperationSource(Client), _dnsResolverClientDiagnostics, Pipeline, _dnsResolverRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsResolverName"> The name of the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsResolverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsResolverResource> CreateOrUpdate(WaitUntil waitUntil, string dnsResolverName, DnsResolverData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsResolverName, nameof(dnsResolverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverClientDiagnostics.CreateScope("DnsResolverCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsResolverRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsResolverResource>(new DnsResolverOperationSource(Client), _dnsResolverClientDiagnostics, Pipeline, _dnsResolverRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsResolverName"> The name of the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsResolverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverName"/> is null. </exception>
        public virtual async Task<Response<DnsResolverResource>> GetAsync(string dnsResolverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsResolverName, nameof(dnsResolverName));

            using var scope = _dnsResolverClientDiagnostics.CreateScope("DnsResolverCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsResolverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a DNS resolver.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsResolverName"> The name of the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsResolverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverName"/> is null. </exception>
        public virtual Response<DnsResolverResource> Get(string dnsResolverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsResolverName, nameof(dnsResolverName));

            using var scope = _dnsResolverClientDiagnostics.CreateScope("DnsResolverCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsResolverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists DNS resolvers within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsResolverResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsResolverResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsResolverResource(Client, DnsResolverData.DeserializeDnsResolverData(e)), _dnsResolverClientDiagnostics, Pipeline, "DnsResolverCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS resolvers within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsResolverResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsResolverResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsResolverResource(Client, DnsResolverData.DeserializeDnsResolverData(e)), _dnsResolverClientDiagnostics, Pipeline, "DnsResolverCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsResolverName"> The name of the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsResolverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dnsResolverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsResolverName, nameof(dnsResolverName));

            using var scope = _dnsResolverClientDiagnostics.CreateScope("DnsResolverCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsResolverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsResolverName"> The name of the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsResolverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverName"/> is null. </exception>
        public virtual Response<bool> Exists(string dnsResolverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsResolverName, nameof(dnsResolverName));

            using var scope = _dnsResolverClientDiagnostics.CreateScope("DnsResolverCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsResolverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dnsResolverName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsResolverResource> IEnumerable<DnsResolverResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsResolverResource> IAsyncEnumerable<DnsResolverResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}