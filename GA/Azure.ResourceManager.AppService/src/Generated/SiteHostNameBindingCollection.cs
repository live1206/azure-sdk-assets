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
    /// A class representing a collection of <see cref="SiteHostNameBindingResource" /> and their operations.
    /// Each <see cref="SiteHostNameBindingResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteHostNameBindingCollection" /> instance call the GetSiteHostNameBindings method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteHostNameBindingCollection : ArmCollection, IEnumerable<SiteHostNameBindingResource>, IAsyncEnumerable<SiteHostNameBindingResource>
    {
        private readonly ClientDiagnostics _siteHostNameBindingWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteHostNameBindingWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteHostNameBindingCollection"/> class for mocking. </summary>
        protected SiteHostNameBindingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteHostNameBindingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteHostNameBindingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteHostNameBindingWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteHostNameBindingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteHostNameBindingResource.ResourceType, out string siteHostNameBindingWebAppsApiVersion);
            _siteHostNameBindingWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteHostNameBindingWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a hostname binding for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateHostNameBinding</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="data"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteHostNameBindingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hostName, HostNameBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteHostNameBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteHostNameBindingWebAppsRestClient.CreateOrUpdateHostNameBindingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteHostNameBindingResource>(Response.FromValue(new SiteHostNameBindingResource(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a hostname binding for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateHostNameBinding</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="data"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteHostNameBindingResource> CreateOrUpdate(WaitUntil waitUntil, string hostName, HostNameBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteHostNameBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteHostNameBindingWebAppsRestClient.CreateOrUpdateHostNameBinding(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteHostNameBindingResource>(Response.FromValue(new SiteHostNameBindingResource(Client, response), response.GetRawResponse()));
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
        /// Description for Get the named hostname binding for an app (or deployment slot, if specified).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetHostNameBinding</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual async Task<Response<SiteHostNameBindingResource>> GetAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _siteHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteHostNameBindingCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteHostNameBindingWebAppsRestClient.GetHostNameBindingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteHostNameBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the named hostname binding for an app (or deployment slot, if specified).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetHostNameBinding</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<SiteHostNameBindingResource> Get(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _siteHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteHostNameBindingCollection.Get");
            scope.Start();
            try
            {
                var response = _siteHostNameBindingWebAppsRestClient.GetHostNameBinding(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteHostNameBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get hostname bindings for an app or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListHostNameBindings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteHostNameBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteHostNameBindingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteHostNameBindingWebAppsRestClient.CreateListHostNameBindingsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteHostNameBindingWebAppsRestClient.CreateListHostNameBindingsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteHostNameBindingResource(Client, HostNameBindingData.DeserializeHostNameBindingData(e)), _siteHostNameBindingWebAppsClientDiagnostics, Pipeline, "SiteHostNameBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get hostname bindings for an app or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListHostNameBindings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteHostNameBindingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteHostNameBindingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteHostNameBindingWebAppsRestClient.CreateListHostNameBindingsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteHostNameBindingWebAppsRestClient.CreateListHostNameBindingsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteHostNameBindingResource(Client, HostNameBindingData.DeserializeHostNameBindingData(e)), _siteHostNameBindingWebAppsClientDiagnostics, Pipeline, "SiteHostNameBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetHostNameBinding</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _siteHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteHostNameBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteHostNameBindingWebAppsRestClient.GetHostNameBindingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostNameBindings/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetHostNameBinding</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostName"> Hostname in the hostname binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _siteHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteHostNameBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteHostNameBindingWebAppsRestClient.GetHostNameBinding(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteHostNameBindingResource> IEnumerable<SiteHostNameBindingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteHostNameBindingResource> IAsyncEnumerable<SiteHostNameBindingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}