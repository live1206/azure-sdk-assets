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
    /// A class representing a collection of <see cref="ApiManagementDiagnosticResource" /> and their operations.
    /// Each <see cref="ApiManagementDiagnosticResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementDiagnosticCollection" /> instance call the GetApiManagementDiagnostics method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementDiagnosticCollection : ArmCollection, IEnumerable<ApiManagementDiagnosticResource>, IAsyncEnumerable<ApiManagementDiagnosticResource>
    {
        private readonly ClientDiagnostics _apiManagementDiagnosticDiagnosticClientDiagnostics;
        private readonly DiagnosticRestOperations _apiManagementDiagnosticDiagnosticRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementDiagnosticCollection"/> class for mocking. </summary>
        protected ApiManagementDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementDiagnosticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementDiagnosticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementDiagnosticDiagnosticClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementDiagnosticResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementDiagnosticResource.ResourceType, out string apiManagementDiagnosticDiagnosticApiVersion);
            _apiManagementDiagnosticDiagnosticRestClient = new DiagnosticRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementDiagnosticDiagnosticApiVersion);
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
        /// Creates a new Diagnostic or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementDiagnosticResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diagnosticId, DiagnosticContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementDiagnosticDiagnosticClientDiagnostics.CreateScope("ApiManagementDiagnosticCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementDiagnosticDiagnosticRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementDiagnosticResource>(Response.FromValue(new ApiManagementDiagnosticResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new Diagnostic or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementDiagnosticResource> CreateOrUpdate(WaitUntil waitUntil, string diagnosticId, DiagnosticContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementDiagnosticDiagnosticClientDiagnostics.CreateScope("ApiManagementDiagnosticCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementDiagnosticDiagnosticRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementDiagnosticResource>(Response.FromValue(new ApiManagementDiagnosticResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the Diagnostic specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementDiagnosticResource>> GetAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiManagementDiagnosticDiagnosticClientDiagnostics.CreateScope("ApiManagementDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementDiagnosticDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Diagnostic specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual Response<ApiManagementDiagnosticResource> Get(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiManagementDiagnosticDiagnosticClientDiagnostics.CreateScope("ApiManagementDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementDiagnosticDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all diagnostics of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementDiagnosticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementDiagnosticResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementDiagnosticDiagnosticRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementDiagnosticDiagnosticRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementDiagnosticResource(Client, DiagnosticContractData.DeserializeDiagnosticContractData(e)), _apiManagementDiagnosticDiagnosticClientDiagnostics, Pipeline, "ApiManagementDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all diagnostics of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementDiagnosticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementDiagnosticResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementDiagnosticDiagnosticRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementDiagnosticDiagnosticRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementDiagnosticResource(Client, DiagnosticContractData.DeserializeDiagnosticContractData(e)), _apiManagementDiagnosticDiagnosticClientDiagnostics, Pipeline, "ApiManagementDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiManagementDiagnosticDiagnosticClientDiagnostics.CreateScope("ApiManagementDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementDiagnosticDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostic_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiManagementDiagnosticDiagnosticClientDiagnostics.CreateScope("ApiManagementDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementDiagnosticDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementDiagnosticResource> IEnumerable<ApiManagementDiagnosticResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementDiagnosticResource> IAsyncEnumerable<ApiManagementDiagnosticResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}