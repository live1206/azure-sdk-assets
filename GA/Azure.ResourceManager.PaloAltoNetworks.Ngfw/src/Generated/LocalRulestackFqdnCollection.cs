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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="LocalRulestackFqdnResource" /> and their operations.
    /// Each <see cref="LocalRulestackFqdnResource" /> in the collection will belong to the same instance of <see cref="LocalRulestackResource" />.
    /// To get a <see cref="LocalRulestackFqdnCollection" /> instance call the GetLocalRulestackFqdns method from an instance of <see cref="LocalRulestackResource" />.
    /// </summary>
    public partial class LocalRulestackFqdnCollection : ArmCollection, IEnumerable<LocalRulestackFqdnResource>, IAsyncEnumerable<LocalRulestackFqdnResource>
    {
        private readonly ClientDiagnostics _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics;
        private readonly FqdnListLocalRulestackRestOperations _localRulestackFqdnFqdnListLocalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackFqdnCollection"/> class for mocking. </summary>
        protected LocalRulestackFqdnCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackFqdnCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LocalRulestackFqdnCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", LocalRulestackFqdnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LocalRulestackFqdnResource.ResourceType, out string localRulestackFqdnFqdnListLocalRulestackApiVersion);
            _localRulestackFqdnFqdnListLocalRulestackRestClient = new FqdnListLocalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localRulestackFqdnFqdnListLocalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LocalRulestackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LocalRulestackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a FqdnListLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalRulestackFqdnResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, LocalRulestackFqdnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackFqdnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<LocalRulestackFqdnResource>(new LocalRulestackFqdnOperationSource(Client), _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics, Pipeline, _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a FqdnListLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalRulestackFqdnResource> CreateOrUpdate(WaitUntil waitUntil, string name, LocalRulestackFqdnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackFqdnCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new NgfwArmOperation<LocalRulestackFqdnResource>(new LocalRulestackFqdnOperationSource(Client), _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics, Pipeline, _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a FqdnListLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<LocalRulestackFqdnResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackFqdnCollection.Get");
            scope.Start();
            try
            {
                var response = await _localRulestackFqdnFqdnListLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackFqdnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FqdnListLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<LocalRulestackFqdnResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackFqdnCollection.Get");
            scope.Start();
            try
            {
                var response = _localRulestackFqdnFqdnListLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackFqdnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FqdnListLocalRulestackResource resources by LocalRulestacks
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_ListByLocalRulestacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalRulestackFqdnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LocalRulestackFqdnResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateListByLocalRulestacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateListByLocalRulestacksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LocalRulestackFqdnResource(Client, LocalRulestackFqdnData.DeserializeLocalRulestackFqdnData(e)), _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics, Pipeline, "LocalRulestackFqdnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FqdnListLocalRulestackResource resources by LocalRulestacks
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_ListByLocalRulestacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalRulestackFqdnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LocalRulestackFqdnResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateListByLocalRulestacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackFqdnFqdnListLocalRulestackRestClient.CreateListByLocalRulestacksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LocalRulestackFqdnResource(Client, LocalRulestackFqdnData.DeserializeLocalRulestackFqdnData(e)), _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics, Pipeline, "LocalRulestackFqdnCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackFqdnCollection.Exists");
            scope.Start();
            try
            {
                var response = await _localRulestackFqdnFqdnListLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackFqdnFqdnListLocalRulestackClientDiagnostics.CreateScope("LocalRulestackFqdnCollection.Exists");
            scope.Start();
            try
            {
                var response = _localRulestackFqdnFqdnListLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LocalRulestackFqdnResource> IEnumerable<LocalRulestackFqdnResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LocalRulestackFqdnResource> IAsyncEnumerable<LocalRulestackFqdnResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}