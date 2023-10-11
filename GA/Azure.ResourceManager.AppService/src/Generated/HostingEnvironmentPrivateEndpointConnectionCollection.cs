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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="HostingEnvironmentPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="HostingEnvironmentPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="AppServiceEnvironmentResource" />.
    /// To get a <see cref="HostingEnvironmentPrivateEndpointConnectionCollection" /> instance call the GetHostingEnvironmentPrivateEndpointConnections method from an instance of <see cref="AppServiceEnvironmentResource" />.
    /// </summary>
    public partial class HostingEnvironmentPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<HostingEnvironmentPrivateEndpointConnectionResource>, IAsyncEnumerable<HostingEnvironmentPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected HostingEnvironmentPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostingEnvironmentPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", HostingEnvironmentPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HostingEnvironmentPrivateEndpointConnectionResource.ResourceType, out string hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Approves or rejects a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.ApproveOrRejectPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, info, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>(new HostingEnvironmentPrivateEndpointConnectionOperationSource(Client), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, info).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Approves or rejects a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<HostingEnvironmentPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.ApproveOrRejectPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, info, cancellationToken);
                var operation = new AppServiceArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>(new HostingEnvironmentPrivateEndpointConnectionOperationSource(Client), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, info).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<HostingEnvironmentPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a private endpoint connection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<HostingEnvironmentPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the list of private endpoints associated with a hosting environment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetPrivateEndpointConnectionList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostingEnvironmentPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostingEnvironmentPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateGetPrivateEndpointConnectionListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateGetPrivateEndpointConnectionListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HostingEnvironmentPrivateEndpointConnectionResource(Client, RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(e)), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the list of private endpoints associated with a hosting environment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetPrivateEndpointConnectionList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostingEnvironmentPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostingEnvironmentPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateGetPrivateEndpointConnectionListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateGetPrivateEndpointConnectionListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HostingEnvironmentPrivateEndpointConnectionResource(Client, RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(e)), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HostingEnvironmentPrivateEndpointConnectionResource> IEnumerable<HostingEnvironmentPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostingEnvironmentPrivateEndpointConnectionResource> IAsyncEnumerable<HostingEnvironmentPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}