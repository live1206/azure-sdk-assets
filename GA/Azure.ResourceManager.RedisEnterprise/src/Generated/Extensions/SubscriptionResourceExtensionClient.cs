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
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _operationsStatusClientDiagnostics;
        private OperationsStatusRestOperations _operationsStatusRestClient;
        private ClientDiagnostics _redisEnterpriseClusterRedisEnterpriseClientDiagnostics;
        private RedisEnterpriseRestOperations _redisEnterpriseClusterRedisEnterpriseRestClient;
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;

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

        private ClientDiagnostics OperationsStatusClientDiagnostics => _operationsStatusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RedisEnterprise", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationsStatusRestOperations OperationsStatusRestClient => _operationsStatusRestClient ??= new OperationsStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics RedisEnterpriseClusterRedisEnterpriseClientDiagnostics => _redisEnterpriseClusterRedisEnterpriseClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RedisEnterprise", RedisEnterpriseClusterResource.ResourceType.Namespace, Diagnostics);
        private RedisEnterpriseRestOperations RedisEnterpriseClusterRedisEnterpriseRestClient => _redisEnterpriseClusterRedisEnterpriseRestClient ??= new RedisEnterpriseRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(RedisEnterpriseClusterResource.ResourceType));
        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RedisEnterprise", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the status of operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/operationsStatus/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationsStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RedisEnterpriseOperationStatus>> GetRedisEnterpriseOperationsStatusAsync(AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = OperationsStatusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRedisEnterpriseOperationsStatus");
            scope.Start();
            try
            {
                var response = await OperationsStatusRestClient.GetAsync(Id.SubscriptionId, location, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the status of operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/operationsStatus/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationsStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RedisEnterpriseOperationStatus> GetRedisEnterpriseOperationsStatus(AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = OperationsStatusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRedisEnterpriseOperationsStatus");
            scope.Start();
            try
            {
                var response = OperationsStatusRestClient.Get(Id.SubscriptionId, location, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all RedisEnterprise clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redisEnterprise</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisEnterpriseClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisEnterpriseClusterResource> GetRedisEnterpriseClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RedisEnterpriseClusterRedisEnterpriseRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RedisEnterpriseClusterRedisEnterpriseRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RedisEnterpriseClusterResource(Client, RedisEnterpriseClusterData.DeserializeRedisEnterpriseClusterData(e)), RedisEnterpriseClusterRedisEnterpriseClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetRedisEnterpriseClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all RedisEnterprise clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redisEnterprise</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisEnterpriseClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisEnterpriseClusterResource> GetRedisEnterpriseClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RedisEnterpriseClusterRedisEnterpriseRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RedisEnterpriseClusterRedisEnterpriseRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RedisEnterpriseClusterResource(Client, RedisEnterpriseClusterData.DeserializeRedisEnterpriseClusterData(e)), RedisEnterpriseClusterRedisEnterpriseClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetRedisEnterpriseClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about skus in specified location for the given subscription id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisEnterpriseRegionSkuDetail" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisEnterpriseRegionSkuDetail> GetRedisEnterpriseSkusAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, RedisEnterpriseRegionSkuDetail.DeserializeRedisEnterpriseRegionSkuDetail, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetRedisEnterpriseSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about skus in specified location for the given subscription id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisEnterpriseRegionSkuDetail" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisEnterpriseRegionSkuDetail> GetRedisEnterpriseSkus(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, RedisEnterpriseRegionSkuDetail.DeserializeRedisEnterpriseRegionSkuDetail, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetRedisEnterpriseSkus", "value", null, cancellationToken);
        }
    }
}