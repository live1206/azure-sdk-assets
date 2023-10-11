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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsDisasterRecoveryResource" /> and their operations.
    /// Each <see cref="EventHubsDisasterRecoveryResource" /> in the collection will belong to the same instance of <see cref="EventHubsNamespaceResource" />.
    /// To get an <see cref="EventHubsDisasterRecoveryCollection" /> instance call the GetEventHubsDisasterRecoveries method from an instance of <see cref="EventHubsNamespaceResource" />.
    /// </summary>
    public partial class EventHubsDisasterRecoveryCollection : ArmCollection, IEnumerable<EventHubsDisasterRecoveryResource>, IAsyncEnumerable<EventHubsDisasterRecoveryResource>
    {
        private readonly ClientDiagnostics _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryCollection"/> class for mocking. </summary>
        protected EventHubsDisasterRecoveryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsDisasterRecoveryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsDisasterRecoveryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsDisasterRecoveryResource.ResourceType, out string eventHubsDisasterRecoveryDisasterRecoveryConfigsApiVersion);
            _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsDisasterRecoveryDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubsNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubsNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="data"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsDisasterRecoveryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string @alias, EventHubsDisasterRecoveryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsDisasterRecoveryResource>(Response.FromValue(new EventHubsDisasterRecoveryResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="data"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsDisasterRecoveryResource> CreateOrUpdate(WaitUntil waitUntil, string @alias, EventHubsDisasterRecoveryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsDisasterRecoveryResource>(Response.FromValue(new EventHubsDisasterRecoveryResource(Client, response), response.GetRawResponse()));
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
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<EventHubsDisasterRecoveryResource>> GetAsync(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<EventHubsDisasterRecoveryResource> Get(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Alias(Disaster Recovery configurations)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsDisasterRecoveryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsDisasterRecoveryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsDisasterRecoveryResource(Client, EventHubsDisasterRecoveryData.DeserializeEventHubsDisasterRecoveryData(e)), _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics, Pipeline, "EventHubsDisasterRecoveryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all Alias(Disaster Recovery configurations)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsDisasterRecoveryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsDisasterRecoveryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsDisasterRecoveryResource(Client, EventHubsDisasterRecoveryData.DeserializeEventHubsDisasterRecoveryData(e)), _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics, Pipeline, "EventHubsDisasterRecoveryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<bool> Exists(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _eventHubsDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsDisasterRecoveryResource> IEnumerable<EventHubsDisasterRecoveryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsDisasterRecoveryResource> IAsyncEnumerable<EventHubsDisasterRecoveryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}