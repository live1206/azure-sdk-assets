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

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing a collection of <see cref="SphereCertificateResource" /> and their operations.
    /// Each <see cref="SphereCertificateResource" /> in the collection will belong to the same instance of <see cref="SphereCatalogResource" />.
    /// To get a <see cref="SphereCertificateCollection" /> instance call the GetSphereCertificates method from an instance of <see cref="SphereCatalogResource" />.
    /// </summary>
    public partial class SphereCertificateCollection : ArmCollection, IEnumerable<SphereCertificateResource>, IAsyncEnumerable<SphereCertificateResource>
    {
        private readonly ClientDiagnostics _sphereCertificateCertificatesClientDiagnostics;
        private readonly CertificatesRestOperations _sphereCertificateCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SphereCertificateCollection"/> class for mocking. </summary>
        protected SphereCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SphereCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SphereCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereCertificateCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", SphereCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SphereCertificateResource.ResourceType, out string sphereCertificateCertificatesApiVersion);
            _sphereCertificateCertificatesRestClient = new CertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereCertificateCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SphereCatalogResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SphereCatalogResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Certificate
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serialNumber"/> is null. </exception>
        public virtual async Task<Response<SphereCertificateResource>> GetAsync(string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _sphereCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serialNumber, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Certificate
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serialNumber"/> is null. </exception>
        public virtual Response<SphereCertificateResource> Get(string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _sphereCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serialNumber, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Certificate resources by Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_ListByCatalog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SphereCertificateResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereCertificateCertificatesRestClient.CreateListByCatalogRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereCertificateCertificatesRestClient.CreateListByCatalogNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SphereCertificateResource(Client, SphereCertificateData.DeserializeSphereCertificateData(e)), _sphereCertificateCertificatesClientDiagnostics, Pipeline, "SphereCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Certificate resources by Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_ListByCatalog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SphereCertificateResource> GetAll(string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereCertificateCertificatesRestClient.CreateListByCatalogRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereCertificateCertificatesRestClient.CreateListByCatalogNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SphereCertificateResource(Client, SphereCertificateData.DeserializeSphereCertificateData(e)), _sphereCertificateCertificatesClientDiagnostics, Pipeline, "SphereCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serialNumber"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sphereCertificateCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serialNumber, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/certificates/{serialNumber}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serialNumber"> Serial number of the certificate. Use '.default' to get current active certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serialNumber"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serialNumber"/> is null. </exception>
        public virtual Response<bool> Exists(string serialNumber, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serialNumber, nameof(serialNumber));

            using var scope = _sphereCertificateCertificatesClientDiagnostics.CreateScope("SphereCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _sphereCertificateCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serialNumber, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SphereCertificateResource> IEnumerable<SphereCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SphereCertificateResource> IAsyncEnumerable<SphereCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}