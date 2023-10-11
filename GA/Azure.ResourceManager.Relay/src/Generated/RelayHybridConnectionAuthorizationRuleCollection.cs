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

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing a collection of <see cref="RelayHybridConnectionAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="RelayHybridConnectionAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="RelayHybridConnectionResource" />.
    /// To get a <see cref="RelayHybridConnectionAuthorizationRuleCollection" /> instance call the GetRelayHybridConnectionAuthorizationRules method from an instance of <see cref="RelayHybridConnectionResource" />.
    /// </summary>
    public partial class RelayHybridConnectionAuthorizationRuleCollection : ArmCollection, IEnumerable<RelayHybridConnectionAuthorizationRuleResource>, IAsyncEnumerable<RelayHybridConnectionAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics;
        private readonly HybridConnectionsRestOperations _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RelayHybridConnectionAuthorizationRuleCollection"/> class for mocking. </summary>
        protected RelayHybridConnectionAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RelayHybridConnectionAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RelayHybridConnectionAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", RelayHybridConnectionAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RelayHybridConnectionAuthorizationRuleResource.ResourceType, out string relayHybridConnectionAuthorizationRuleHybridConnectionsApiVersion);
            _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient = new HybridConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayHybridConnectionAuthorizationRuleHybridConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RelayHybridConnectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RelayHybridConnectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an authorization rule for a hybrid connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RelayHybridConnectionAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation<RelayHybridConnectionAuthorizationRuleResource>(Response.FromValue(new RelayHybridConnectionAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an authorization rule for a hybrid connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The authorization rule parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RelayHybridConnectionAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, RelayAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken);
                var operation = new RelayArmOperation<RelayHybridConnectionAuthorizationRuleResource>(Response.FromValue(new RelayHybridConnectionAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Hybrid connection authorization rule for a hybrid connection by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<RelayHybridConnectionAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelayHybridConnectionAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Hybrid connection authorization rule for a hybrid connection by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<RelayHybridConnectionAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelayHybridConnectionAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Authorization rules for a hybrid connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_ListAuthorizationRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RelayHybridConnectionAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RelayHybridConnectionAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RelayHybridConnectionAuthorizationRuleResource(Client, RelayAuthorizationRuleData.DeserializeRelayAuthorizationRuleData(e)), _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics, Pipeline, "RelayHybridConnectionAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Authorization rules for a hybrid connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_ListAuthorizationRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RelayHybridConnectionAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RelayHybridConnectionAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RelayHybridConnectionAuthorizationRuleResource(Client, RelayAuthorizationRuleData.DeserializeRelayAuthorizationRuleData(e)), _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics, Pipeline, "RelayHybridConnectionAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _relayHybridConnectionAuthorizationRuleHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionAuthorizationRuleHybridConnectionsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RelayHybridConnectionAuthorizationRuleResource> IEnumerable<RelayHybridConnectionAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RelayHybridConnectionAuthorizationRuleResource> IAsyncEnumerable<RelayHybridConnectionAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}