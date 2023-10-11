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
    /// A class representing a collection of <see cref="WebSiteSlotTriggeredWebJobResource" /> and their operations.
    /// Each <see cref="WebSiteSlotTriggeredWebJobResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="WebSiteSlotTriggeredWebJobCollection" /> instance call the GetWebSiteSlotTriggeredWebJobs method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class WebSiteSlotTriggeredWebJobCollection : ArmCollection, IEnumerable<WebSiteSlotTriggeredWebJobResource>, IAsyncEnumerable<WebSiteSlotTriggeredWebJobResource>
    {
        private readonly ClientDiagnostics _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotTriggeredWebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobCollection"/> class for mocking. </summary>
        protected WebSiteSlotTriggeredWebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotTriggeredWebJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotTriggeredWebJobResource.ResourceType, out string webSiteSlotTriggeredWebJobWebAppsApiVersion);
            _webSiteSlotTriggeredWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotTriggeredWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a triggered web job by its ID for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotTriggeredWebJobResource>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job by its ID for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<WebSiteSlotTriggeredWebJobResource> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List triggered web jobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotTriggeredWebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotTriggeredWebJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotTriggeredWebJobWebAppsRestClient.CreateListTriggeredWebJobsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotTriggeredWebJobWebAppsRestClient.CreateListTriggeredWebJobsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotTriggeredWebJobResource(Client, TriggeredWebJobData.DeserializeTriggeredWebJobData(e)), _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics, Pipeline, "WebSiteSlotTriggeredWebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List triggered web jobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotTriggeredWebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotTriggeredWebJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotTriggeredWebJobWebAppsRestClient.CreateListTriggeredWebJobsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotTriggeredWebJobWebAppsRestClient.CreateListTriggeredWebJobsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotTriggeredWebJobResource(Client, TriggeredWebJobData.DeserializeTriggeredWebJobData(e)), _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics, Pipeline, "WebSiteSlotTriggeredWebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotTriggeredWebJobResource> IEnumerable<WebSiteSlotTriggeredWebJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotTriggeredWebJobResource> IAsyncEnumerable<WebSiteSlotTriggeredWebJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}