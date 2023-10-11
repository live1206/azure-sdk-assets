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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _serviceBusNamespaceNamespacesClientDiagnostics;
        private NamespacesRestOperations _serviceBusNamespaceNamespacesRestClient;

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

        private ClientDiagnostics ServiceBusNamespaceNamespacesClientDiagnostics => _serviceBusNamespaceNamespacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusNamespaceResource.ResourceType.Namespace, Diagnostics);
        private NamespacesRestOperations ServiceBusNamespaceNamespacesRestClient => _serviceBusNamespaceNamespacesRestClient ??= new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ServiceBusNamespaceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all the available namespaces within the subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusNamespaceResource> GetServiceBusNamespacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceBusNamespaceNamespacesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceBusNamespaceNamespacesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceBusNamespaceResource(Client, ServiceBusNamespaceData.DeserializeServiceBusNamespaceData(e)), ServiceBusNamespaceNamespacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetServiceBusNamespaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the available namespaces within the subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusNamespaceResource> GetServiceBusNamespaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceBusNamespaceNamespacesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceBusNamespaceNamespacesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceBusNamespaceResource(Client, ServiceBusNamespaceData.DeserializeServiceBusNamespaceData(e)), ServiceBusNamespaceNamespacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetServiceBusNamespaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceBusNameAvailabilityResult>> CheckServiceBusNamespaceNameAvailabilityAsync(ServiceBusNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceBusNamespaceNamespacesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckServiceBusNamespaceNameAvailability");
            scope.Start();
            try
            {
                var response = await ServiceBusNamespaceNamespacesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusNameAvailabilityResult> CheckServiceBusNamespaceNameAvailability(ServiceBusNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceBusNamespaceNamespacesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckServiceBusNamespaceNameAvailability");
            scope.Start();
            try
            {
                var response = ServiceBusNamespaceNamespacesRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}