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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBFirewallRuleResource" /> and their operations.
    /// Each <see cref="CosmosDBFirewallRuleResource" /> in the collection will belong to the same instance of <see cref="MongoClusterResource" />.
    /// To get a <see cref="CosmosDBFirewallRuleCollection" /> instance call the GetCosmosDBFirewallRules method from an instance of <see cref="MongoClusterResource" />.
    /// </summary>
    public partial class CosmosDBFirewallRuleCollection : ArmCollection, IEnumerable<CosmosDBFirewallRuleResource>, IAsyncEnumerable<CosmosDBFirewallRuleResource>
    {
        private readonly ClientDiagnostics _cosmosDBFirewallRuleMongoClustersClientDiagnostics;
        private readonly MongoClustersRestOperations _cosmosDBFirewallRuleMongoClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBFirewallRuleCollection"/> class for mocking. </summary>
        protected CosmosDBFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBFirewallRuleMongoClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBFirewallRuleResource.ResourceType, out string cosmosDBFirewallRuleMongoClustersApiVersion);
            _cosmosDBFirewallRuleMongoClustersRestClient = new MongoClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBFirewallRuleMongoClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MongoClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MongoClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new firewall rule or updates an existing firewall rule on a mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_CreateOrUpdateFirewallRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the mongo cluster firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallRuleName, CosmosDBFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBFirewallRuleMongoClustersClientDiagnostics.CreateScope("CosmosDBFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBFirewallRuleMongoClustersRestClient.CreateOrUpdateFirewallRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBFirewallRuleResource>(new CosmosDBFirewallRuleOperationSource(Client), _cosmosDBFirewallRuleMongoClustersClientDiagnostics, Pipeline, _cosmosDBFirewallRuleMongoClustersRestClient.CreateCreateOrUpdateFirewallRuleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new firewall rule or updates an existing firewall rule on a mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_CreateOrUpdateFirewallRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the mongo cluster firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string firewallRuleName, CosmosDBFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBFirewallRuleMongoClustersClientDiagnostics.CreateScope("CosmosDBFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBFirewallRuleMongoClustersRestClient.CreateOrUpdateFirewallRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBFirewallRuleResource>(new CosmosDBFirewallRuleOperationSource(Client), _cosmosDBFirewallRuleMongoClustersClientDiagnostics, Pipeline, _cosmosDBFirewallRuleMongoClustersRestClient.CreateCreateOrUpdateFirewallRuleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a mongo cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_GetFirewallRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the mongo cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBFirewallRuleResource>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBFirewallRuleMongoClustersClientDiagnostics.CreateScope("CosmosDBFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBFirewallRuleMongoClustersRestClient.GetFirewallRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a mongo cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_GetFirewallRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the mongo cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<CosmosDBFirewallRuleResource> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBFirewallRuleMongoClustersClientDiagnostics.CreateScope("CosmosDBFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBFirewallRuleMongoClustersRestClient.GetFirewallRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the firewall rules in a given mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_ListFirewallRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBFirewallRuleMongoClustersRestClient.CreateListFirewallRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBFirewallRuleMongoClustersRestClient.CreateListFirewallRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CosmosDBFirewallRuleResource(Client, CosmosDBFirewallRuleData.DeserializeCosmosDBFirewallRuleData(e)), _cosmosDBFirewallRuleMongoClustersClientDiagnostics, Pipeline, "CosmosDBFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the firewall rules in a given mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_ListFirewallRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBFirewallRuleMongoClustersRestClient.CreateListFirewallRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBFirewallRuleMongoClustersRestClient.CreateListFirewallRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CosmosDBFirewallRuleResource(Client, CosmosDBFirewallRuleData.DeserializeCosmosDBFirewallRuleData(e)), _cosmosDBFirewallRuleMongoClustersClientDiagnostics, Pipeline, "CosmosDBFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_GetFirewallRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the mongo cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBFirewallRuleMongoClustersClientDiagnostics.CreateScope("CosmosDBFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBFirewallRuleMongoClustersRestClient.GetFirewallRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_GetFirewallRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the mongo cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBFirewallRuleMongoClustersClientDiagnostics.CreateScope("CosmosDBFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBFirewallRuleMongoClustersRestClient.GetFirewallRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBFirewallRuleResource> IEnumerable<CosmosDBFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBFirewallRuleResource> IAsyncEnumerable<CosmosDBFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}