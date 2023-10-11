// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _netAppResourceClientDiagnostics;
        private NetAppResourceRestOperations _netAppResourceRestClient;
        private ClientDiagnostics _netAppResourceQuotaLimitsClientDiagnostics;
        private NetAppResourceQuotaLimitsRestOperations _netAppResourceQuotaLimitsRestClient;
        private ClientDiagnostics _netAppAccountAccountsClientDiagnostics;
        private AccountsRestOperations _netAppAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics NetAppResourceClientDiagnostics => _netAppResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private NetAppResourceRestOperations NetAppResourceRestClient => _netAppResourceRestClient ??= new NetAppResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NetAppResourceQuotaLimitsClientDiagnostics => _netAppResourceQuotaLimitsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private NetAppResourceQuotaLimitsRestOperations NetAppResourceQuotaLimitsRestClient => _netAppResourceQuotaLimitsRestClient ??= new NetAppResourceQuotaLimitsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NetAppAccountAccountsClientDiagnostics => _netAppAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations NetAppAccountAccountsRestClient => _netAppAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NetAppAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check if a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppNameAvailabilityAsync(AzureLocation location, NetAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNetAppNameAvailability");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppCheckAvailabilityResult> CheckNetAppNameAvailability(AzureLocation location, NetAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNetAppNameAvailability");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a file path is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckFilePathAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppFilePathAvailabilityAsync(AzureLocation location, NetAppFilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNetAppFilePathAvailability");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckFilePathAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a file path is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckFilePathAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppCheckAvailabilityResult> CheckNetAppFilePathAvailability(AzureLocation location, NetAppFilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNetAppFilePathAvailability");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckFilePathAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a quota is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckQuotaAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppQuotaAvailabilityAsync(AzureLocation location, NetAppQuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNetAppQuotaAvailability");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckQuotaAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a quota is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckQuotaAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppCheckAvailabilityResult> CheckNetAppQuotaAvailability(AzureLocation location, NetAppQuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNetAppQuotaAvailability");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckQuotaAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_QueryRegionInfo</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppRegionInfo>> QueryRegionInfoNetAppResourceAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.QueryRegionInfoNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.QueryRegionInfoAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_QueryRegionInfo</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppRegionInfo> QueryRegionInfoNetAppResource(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.QueryRegionInfoNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.QueryRegionInfo(Id.SubscriptionId, location, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the default and current limits for quotas
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppSubscriptionQuotaItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimitsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppResourceQuotaLimitsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, NetAppSubscriptionQuotaItem.DeserializeNetAppSubscriptionQuotaItem, NetAppResourceQuotaLimitsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNetAppQuotaLimits", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default and current limits for quotas
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppSubscriptionQuotaItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimits(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppResourceQuotaLimitsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, NetAppSubscriptionQuotaItem.DeserializeNetAppSubscriptionQuotaItem, NetAppResourceQuotaLimitsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNetAppQuotaLimits", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppSubscriptionQuotaItem>> GetNetAppQuotaLimitAsync(AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceQuotaLimitsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetNetAppQuotaLimit");
            scope.Start();
            try
            {
                var response = await NetAppResourceQuotaLimitsRestClient.GetAsync(Id.SubscriptionId, location, quotaLimitName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimit(AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceQuotaLimitsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetNetAppQuotaLimit");
            scope.Start();
            try
            {
                var response = NetAppResourceQuotaLimitsRestClient.Get(Id.SubscriptionId, location, quotaLimitName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppAccountResource> GetNetAppAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetAppAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetAppAccountResource(Client, NetAppAccountData.DeserializeNetAppAccountData(e)), NetAppAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNetAppAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppAccountResource> GetNetAppAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetAppAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetAppAccountResource(Client, NetAppAccountData.DeserializeNetAppAccountData(e)), NetAppAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNetAppAccounts", "value", "nextLink", cancellationToken);
        }
    }
}