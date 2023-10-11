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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRoutePortAuthorizationResource" /> and their operations.
    /// Each <see cref="ExpressRoutePortAuthorizationResource" /> in the collection will belong to the same instance of <see cref="ExpressRoutePortResource" />.
    /// To get an <see cref="ExpressRoutePortAuthorizationCollection" /> instance call the GetExpressRoutePortAuthorizations method from an instance of <see cref="ExpressRoutePortResource" />.
    /// </summary>
    public partial class ExpressRoutePortAuthorizationCollection : ArmCollection, IEnumerable<ExpressRoutePortAuthorizationResource>, IAsyncEnumerable<ExpressRoutePortAuthorizationResource>
    {
        private readonly ClientDiagnostics _expressRoutePortAuthorizationClientDiagnostics;
        private readonly ExpressRoutePortAuthorizationsRestOperations _expressRoutePortAuthorizationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortAuthorizationCollection"/> class for mocking. </summary>
        protected ExpressRoutePortAuthorizationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortAuthorizationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRoutePortAuthorizationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRoutePortAuthorizationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRoutePortAuthorizationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRoutePortAuthorizationResource.ResourceType, out string expressRoutePortAuthorizationApiVersion);
            _expressRoutePortAuthorizationRestClient = new ExpressRoutePortAuthorizationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRoutePortAuthorizationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRoutePortResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRoutePortResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an authorization in the specified express route port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="data"> Parameters supplied to the create or update express route port authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRoutePortAuthorizationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationName, ExpressRoutePortAuthorizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRoutePortAuthorizationClientDiagnostics.CreateScope("ExpressRoutePortAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRoutePortAuthorizationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRoutePortAuthorizationResource>(new ExpressRoutePortAuthorizationOperationSource(Client), _expressRoutePortAuthorizationClientDiagnostics, Pipeline, _expressRoutePortAuthorizationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an authorization in the specified express route port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="data"> Parameters supplied to the create or update express route port authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRoutePortAuthorizationResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationName, ExpressRoutePortAuthorizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRoutePortAuthorizationClientDiagnostics.CreateScope("ExpressRoutePortAuthorizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRoutePortAuthorizationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRoutePortAuthorizationResource>(new ExpressRoutePortAuthorizationOperationSource(Client), _expressRoutePortAuthorizationClientDiagnostics, Pipeline, _expressRoutePortAuthorizationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified authorization from the specified express route port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<ExpressRoutePortAuthorizationResource>> GetAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRoutePortAuthorizationClientDiagnostics.CreateScope("ExpressRoutePortAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRoutePortAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified authorization from the specified express route port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<ExpressRoutePortAuthorizationResource> Get(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRoutePortAuthorizationClientDiagnostics.CreateScope("ExpressRoutePortAuthorizationCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRoutePortAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortAuthorizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all authorizations in an express route port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRoutePortAuthorizationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRoutePortAuthorizationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRoutePortAuthorizationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRoutePortAuthorizationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRoutePortAuthorizationResource(Client, ExpressRoutePortAuthorizationData.DeserializeExpressRoutePortAuthorizationData(e)), _expressRoutePortAuthorizationClientDiagnostics, Pipeline, "ExpressRoutePortAuthorizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all authorizations in an express route port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRoutePortAuthorizationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRoutePortAuthorizationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRoutePortAuthorizationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRoutePortAuthorizationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRoutePortAuthorizationResource(Client, ExpressRoutePortAuthorizationData.DeserializeExpressRoutePortAuthorizationData(e)), _expressRoutePortAuthorizationClientDiagnostics, Pipeline, "ExpressRoutePortAuthorizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRoutePortAuthorizationClientDiagnostics.CreateScope("ExpressRoutePortAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRoutePortAuthorizationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRoutePorts/{expressRoutePortName}/authorizations/{authorizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortAuthorizations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var scope = _expressRoutePortAuthorizationClientDiagnostics.CreateScope("ExpressRoutePortAuthorizationCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRoutePortAuthorizationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRoutePortAuthorizationResource> IEnumerable<ExpressRoutePortAuthorizationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRoutePortAuthorizationResource> IAsyncEnumerable<ExpressRoutePortAuthorizationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}