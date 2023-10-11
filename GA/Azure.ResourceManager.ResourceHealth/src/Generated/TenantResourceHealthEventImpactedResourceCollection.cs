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

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantResourceHealthEventImpactedResource" /> and their operations.
    /// Each <see cref="TenantResourceHealthEventImpactedResource" /> in the collection will belong to the same instance of <see cref="TenantResourceHealthEventResource" />.
    /// To get a <see cref="TenantResourceHealthEventImpactedResourceCollection" /> instance call the GetTenantResourceHealthEventImpactedResources method from an instance of <see cref="TenantResourceHealthEventResource" />.
    /// </summary>
    public partial class TenantResourceHealthEventImpactedResourceCollection : ArmCollection, IEnumerable<TenantResourceHealthEventImpactedResource>, IAsyncEnumerable<TenantResourceHealthEventImpactedResource>
    {
        private readonly ClientDiagnostics _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics;
        private readonly ImpactedResourcesRestOperations _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventImpactedResourceCollection"/> class for mocking. </summary>
        protected TenantResourceHealthEventImpactedResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceHealthEventImpactedResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantResourceHealthEventImpactedResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", TenantResourceHealthEventImpactedResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantResourceHealthEventImpactedResource.ResourceType, out string tenantResourceHealthEventImpactedResourceImpactedResourcesApiVersion);
            _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient = new ImpactedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantResourceHealthEventImpactedResourceImpactedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.ResourceHealth/events")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.ResourceHealth/events"), nameof(id));
        }

        /// <summary>
        /// Gets the specific impacted resource in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        public virtual async Task<Response<TenantResourceHealthEventImpactedResource>> GetAsync(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var scope = _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("TenantResourceHealthEventImpactedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetByTenantIdAsync(Id.Name, impactedResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific impacted resource in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        public virtual Response<TenantResourceHealthEventImpactedResource> Get(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var scope = _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("TenantResourceHealthEventImpactedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetByTenantId(Id.Name, impactedResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists impacted resources in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_ListByTenantIdAndEventId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantResourceHealthEventImpactedResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantResourceHealthEventImpactedResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.CreateListByTenantIdAndEventIdRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.CreateListByTenantIdAndEventIdNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TenantResourceHealthEventImpactedResource(Client, ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(e)), _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics, Pipeline, "TenantResourceHealthEventImpactedResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists impacted resources in the tenant by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_ListByTenantIdAndEventId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantResourceHealthEventImpactedResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantResourceHealthEventImpactedResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.CreateListByTenantIdAndEventIdRequest(Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.CreateListByTenantIdAndEventIdNextPageRequest(nextLink, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TenantResourceHealthEventImpactedResource(Client, ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(e)), _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics, Pipeline, "TenantResourceHealthEventImpactedResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var scope = _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("TenantResourceHealthEventImpactedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetByTenantIdAsync(Id.Name, impactedResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_GetByTenantId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var scope = _tenantResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("TenantResourceHealthEventImpactedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetByTenantId(Id.Name, impactedResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TenantResourceHealthEventImpactedResource> IEnumerable<TenantResourceHealthEventImpactedResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantResourceHealthEventImpactedResource> IAsyncEnumerable<TenantResourceHealthEventImpactedResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}