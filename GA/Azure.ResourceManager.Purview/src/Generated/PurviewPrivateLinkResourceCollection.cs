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

namespace Azure.ResourceManager.Purview
{
    /// <summary>
    /// A class representing a collection of <see cref="PurviewPrivateLinkResource" /> and their operations.
    /// Each <see cref="PurviewPrivateLinkResource" /> in the collection will belong to the same instance of <see cref="PurviewAccountResource" />.
    /// To get a <see cref="PurviewPrivateLinkResourceCollection" /> instance call the GetPurviewPrivateLinkResources method from an instance of <see cref="PurviewAccountResource" />.
    /// </summary>
    public partial class PurviewPrivateLinkResourceCollection : ArmCollection, IEnumerable<PurviewPrivateLinkResource>, IAsyncEnumerable<PurviewPrivateLinkResource>
    {
        private readonly ClientDiagnostics _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _purviewPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PurviewPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected PurviewPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PurviewPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PurviewPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Purview", PurviewPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PurviewPrivateLinkResource.ResourceType, out string purviewPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _purviewPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, purviewPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PurviewAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PurviewAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a privately linkable resources for an account with given group identifier
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_GetByGroupId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The group identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<PurviewPrivateLinkResource>> GetAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PurviewPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.GetByGroupIdAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a privately linkable resources for an account with given group identifier
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_GetByGroupId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The group identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<PurviewPrivateLinkResource> Get(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PurviewPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.GetByGroupId(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PurviewPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of privately linkable resources for an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PurviewPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PurviewPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PurviewPrivateLinkResource(Client, PurviewPrivateLinkResourceData.DeserializePurviewPrivateLinkResourceData(e)), _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "PurviewPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of privately linkable resources for an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PurviewPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PurviewPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PurviewPrivateLinkResource(Client, PurviewPrivateLinkResourceData.DeserializePurviewPrivateLinkResourceData(e)), _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "PurviewPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_GetByGroupId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The group identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PurviewPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.GetByGroupIdAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_GetByGroupId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> The group identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<bool> Exists(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _purviewPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PurviewPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _purviewPrivateLinkResourcePrivateLinkResourcesRestClient.GetByGroupId(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PurviewPrivateLinkResource> IEnumerable<PurviewPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PurviewPrivateLinkResource> IAsyncEnumerable<PurviewPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}