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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteBuildResource" /> and their operations.
    /// Each <see cref="StaticSiteBuildResource" /> in the collection will belong to the same instance of <see cref="StaticSiteResource" />.
    /// To get a <see cref="StaticSiteBuildCollection" /> instance call the GetStaticSiteBuilds method from an instance of <see cref="StaticSiteResource" />.
    /// </summary>
    public partial class StaticSiteBuildCollection : ArmCollection, IEnumerable<StaticSiteBuildResource>, IAsyncEnumerable<StaticSiteBuildResource>
    {
        private readonly ClientDiagnostics _staticSiteBuildStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildCollection"/> class for mocking. </summary>
        protected StaticSiteBuildCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteBuildCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteBuildResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteBuildResource.ResourceType, out string staticSiteBuildStaticSitesApiVersion);
            _staticSiteBuildStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildResource>> GetAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<StaticSiteBuildResource> Get(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all static site builds for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuilds</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildStaticSitesRestClient.CreateGetStaticSiteBuildsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildStaticSitesRestClient.CreateGetStaticSiteBuildsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildResource(Client, StaticSiteBuildData.DeserializeStaticSiteBuildData(e)), _staticSiteBuildStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets all static site builds for a particular static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuilds</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildStaticSitesRestClient.CreateGetStaticSiteBuildsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildStaticSitesRestClient.CreateGetStaticSiteBuildsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildResource(Client, StaticSiteBuildData.DeserializeStaticSiteBuildData(e)), _staticSiteBuildStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteBuildResource> IEnumerable<StaticSiteBuildResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildResource> IAsyncEnumerable<StaticSiteBuildResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}