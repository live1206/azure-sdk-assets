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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementBackendResource" /> and their operations.
    /// Each <see cref="ApiManagementBackendResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementBackendCollection" /> instance call the GetApiManagementBackends method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementBackendCollection : ArmCollection, IEnumerable<ApiManagementBackendResource>, IAsyncEnumerable<ApiManagementBackendResource>
    {
        private readonly ClientDiagnostics _apiManagementBackendBackendClientDiagnostics;
        private readonly BackendRestOperations _apiManagementBackendBackendRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementBackendCollection"/> class for mocking. </summary>
        protected ApiManagementBackendCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementBackendCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementBackendCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementBackendBackendClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementBackendResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementBackendResource.ResourceType, out string apiManagementBackendBackendApiVersion);
            _apiManagementBackendBackendRestClient = new BackendRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementBackendBackendApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backendId"> Identifier of the Backend entity. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementBackendResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backendId, ApiManagementBackendData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendId, nameof(backendId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementBackendBackendClientDiagnostics.CreateScope("ApiManagementBackendCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementBackendBackendRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementBackendResource>(Response.FromValue(new ApiManagementBackendResource(Client, response), response.GetRawResponse()));
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
        /// Creates or Updates a backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backendId"> Identifier of the Backend entity. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementBackendResource> CreateOrUpdate(WaitUntil waitUntil, string backendId, ApiManagementBackendData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendId, nameof(backendId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementBackendBackendClientDiagnostics.CreateScope("ApiManagementBackendCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementBackendBackendRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementBackendResource>(Response.FromValue(new ApiManagementBackendResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the backend specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendId"> Identifier of the Backend entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementBackendResource>> GetAsync(string backendId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendId, nameof(backendId));

            using var scope = _apiManagementBackendBackendClientDiagnostics.CreateScope("ApiManagementBackendCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementBackendBackendRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementBackendResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the backend specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendId"> Identifier of the Backend entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendId"/> is null. </exception>
        public virtual Response<ApiManagementBackendResource> Get(string backendId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendId, nameof(backendId));

            using var scope = _apiManagementBackendBackendClientDiagnostics.CreateScope("ApiManagementBackendCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementBackendBackendRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementBackendResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of backends in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| title | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| url | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementBackendResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementBackendResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementBackendBackendRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementBackendBackendRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementBackendResource(Client, ApiManagementBackendData.DeserializeApiManagementBackendData(e)), _apiManagementBackendBackendClientDiagnostics, Pipeline, "ApiManagementBackendCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of backends in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| title | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| url | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementBackendResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementBackendResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementBackendBackendRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementBackendBackendRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementBackendResource(Client, ApiManagementBackendData.DeserializeApiManagementBackendData(e)), _apiManagementBackendBackendClientDiagnostics, Pipeline, "ApiManagementBackendCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendId"> Identifier of the Backend entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backendId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendId, nameof(backendId));

            using var scope = _apiManagementBackendBackendClientDiagnostics.CreateScope("ApiManagementBackendCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementBackendBackendRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Backend_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backendId"> Identifier of the Backend entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendId"/> is null. </exception>
        public virtual Response<bool> Exists(string backendId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendId, nameof(backendId));

            using var scope = _apiManagementBackendBackendClientDiagnostics.CreateScope("ApiManagementBackendCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementBackendBackendRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementBackendResource> IEnumerable<ApiManagementBackendResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementBackendResource> IAsyncEnumerable<ApiManagementBackendResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}