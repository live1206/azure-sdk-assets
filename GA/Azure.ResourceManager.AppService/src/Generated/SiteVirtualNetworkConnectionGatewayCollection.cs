// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteVirtualNetworkConnectionGatewayResource" /> and their operations.
    /// Each <see cref="SiteVirtualNetworkConnectionGatewayResource" /> in the collection will belong to the same instance of <see cref="SiteVirtualNetworkConnectionResource" />.
    /// To get a <see cref="SiteVirtualNetworkConnectionGatewayCollection" /> instance call the GetSiteVirtualNetworkConnectionGateways method from an instance of <see cref="SiteVirtualNetworkConnectionResource" />.
    /// </summary>
    public partial class SiteVirtualNetworkConnectionGatewayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteVirtualNetworkConnectionGatewayWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionGatewayCollection"/> class for mocking. </summary>
        protected SiteVirtualNetworkConnectionGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteVirtualNetworkConnectionGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteVirtualNetworkConnectionGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteVirtualNetworkConnectionGatewayResource.ResourceType, out string siteVirtualNetworkConnectionGatewayWebAppsApiVersion);
            _siteVirtualNetworkConnectionGatewayWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteVirtualNetworkConnectionGatewayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteVirtualNetworkConnectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteVirtualNetworkConnectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateVnetConnectionGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is "primary". </param>
        /// <param name="data"> The properties to update this gateway with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteVirtualNetworkConnectionGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gatewayName, AppServiceVirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionGatewayWebAppsRestClient.CreateOrUpdateVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteVirtualNetworkConnectionGatewayResource>(Response.FromValue(new SiteVirtualNetworkConnectionGatewayResource(Client, response), response.GetRawResponse()));
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
        /// Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateVnetConnectionGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is "primary". </param>
        /// <param name="data"> The properties to update this gateway with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteVirtualNetworkConnectionGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string gatewayName, AppServiceVirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionGatewayWebAppsRestClient.CreateOrUpdateVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteVirtualNetworkConnectionGatewayResource>(Response.FromValue(new SiteVirtualNetworkConnectionGatewayResource(Client, response), response.GetRawResponse()));
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
        /// Description for Gets an app's Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnectionGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is "primary". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<SiteVirtualNetworkConnectionGatewayResource>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an app's Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnectionGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is "primary". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnectionGatewayResource> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnectionGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is "primary". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnectionGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is "primary". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}