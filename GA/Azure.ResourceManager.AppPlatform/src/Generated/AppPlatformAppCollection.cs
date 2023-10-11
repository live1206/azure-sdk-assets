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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformAppResource" /> and their operations.
    /// Each <see cref="AppPlatformAppResource" /> in the collection will belong to the same instance of <see cref="AppPlatformServiceResource" />.
    /// To get an <see cref="AppPlatformAppCollection" /> instance call the GetAppPlatformApps method from an instance of <see cref="AppPlatformServiceResource" />.
    /// </summary>
    public partial class AppPlatformAppCollection : ArmCollection, IEnumerable<AppPlatformAppResource>, IAsyncEnumerable<AppPlatformAppResource>
    {
        private readonly ClientDiagnostics _appPlatformAppAppsClientDiagnostics;
        private readonly AppsRestOperations _appPlatformAppAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformAppCollection"/> class for mocking. </summary>
        protected AppPlatformAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformAppAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformAppResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformAppResource.ResourceType, out string appPlatformAppAppsApiVersion);
            _appPlatformAppAppsRestClient = new AppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformAppAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new App or update an exiting App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="appName"> The name of the App resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformAppResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string appName, AppPlatformAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformAppAppsClientDiagnostics.CreateScope("AppPlatformAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformAppAppsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformAppResource>(new AppPlatformAppOperationSource(Client), _appPlatformAppAppsClientDiagnostics, Pipeline, _appPlatformAppAppsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a new App or update an exiting App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="appName"> The name of the App resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformAppResource> CreateOrUpdate(WaitUntil waitUntil, string appName, AppPlatformAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformAppAppsClientDiagnostics.CreateScope("AppPlatformAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformAppAppsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformAppResource>(new AppPlatformAppOperationSource(Client), _appPlatformAppAppsClientDiagnostics, Pipeline, _appPlatformAppAppsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get an App and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> The name of the App resource. </param>
        /// <param name="syncStatus"> Indicates whether sync status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformAppResource>> GetAsync(string appName, string syncStatus = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _appPlatformAppAppsClientDiagnostics.CreateScope("AppPlatformAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformAppAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, syncStatus, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an App and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> The name of the App resource. </param>
        /// <param name="syncStatus"> Indicates whether sync status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual Response<AppPlatformAppResource> Get(string appName, string syncStatus = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _appPlatformAppAppsClientDiagnostics.CreateScope("AppPlatformAppCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformAppAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, syncStatus, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformAppResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformAppAppsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformAppAppsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformAppResource(Client, AppPlatformAppData.DeserializeAppPlatformAppData(e)), _appPlatformAppAppsClientDiagnostics, Pipeline, "AppPlatformAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformAppResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformAppAppsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformAppAppsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformAppResource(Client, AppPlatformAppData.DeserializeAppPlatformAppData(e)), _appPlatformAppAppsClientDiagnostics, Pipeline, "AppPlatformAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> The name of the App resource. </param>
        /// <param name="syncStatus"> Indicates whether sync status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string appName, string syncStatus = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _appPlatformAppAppsClientDiagnostics.CreateScope("AppPlatformAppCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformAppAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, syncStatus, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appName"> The name of the App resource. </param>
        /// <param name="syncStatus"> Indicates whether sync status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appName"/> is null. </exception>
        public virtual Response<bool> Exists(string appName, string syncStatus = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appName, nameof(appName));

            using var scope = _appPlatformAppAppsClientDiagnostics.CreateScope("AppPlatformAppCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformAppAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appName, syncStatus, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformAppResource> IEnumerable<AppPlatformAppResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformAppResource> IAsyncEnumerable<AppPlatformAppResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}