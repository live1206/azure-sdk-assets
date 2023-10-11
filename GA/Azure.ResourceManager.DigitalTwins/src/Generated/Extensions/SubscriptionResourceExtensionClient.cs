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
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _digitalTwinsDescriptionDigitalTwinsClientDiagnostics;
        private DigitalTwinsRestOperations _digitalTwinsDescriptionDigitalTwinsRestClient;

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

        private ClientDiagnostics DigitalTwinsDescriptionDigitalTwinsClientDiagnostics => _digitalTwinsDescriptionDigitalTwinsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DigitalTwins", DigitalTwinsDescriptionResource.ResourceType.Namespace, Diagnostics);
        private DigitalTwinsRestOperations DigitalTwinsDescriptionDigitalTwinsRestClient => _digitalTwinsDescriptionDigitalTwinsRestClient ??= new DigitalTwinsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DigitalTwinsDescriptionResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get all the DigitalTwinsInstances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/digitalTwinsInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DigitalTwinsDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DigitalTwinsDescriptionResource> GetDigitalTwinsDescriptionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DigitalTwinsDescriptionDigitalTwinsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DigitalTwinsDescriptionDigitalTwinsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DigitalTwinsDescriptionResource(Client, DigitalTwinsDescriptionData.DeserializeDigitalTwinsDescriptionData(e)), DigitalTwinsDescriptionDigitalTwinsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDigitalTwinsDescriptions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the DigitalTwinsInstances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/digitalTwinsInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DigitalTwinsDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DigitalTwinsDescriptionResource> GetDigitalTwinsDescriptions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DigitalTwinsDescriptionDigitalTwinsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DigitalTwinsDescriptionDigitalTwinsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DigitalTwinsDescriptionResource(Client, DigitalTwinsDescriptionData.DeserializeDigitalTwinsDescriptionData(e)), DigitalTwinsDescriptionDigitalTwinsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDigitalTwinsDescriptions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check if a DigitalTwinsInstance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of DigitalTwinsInstance. </param>
        /// <param name="content"> Set the name parameter in the DigitalTwinsInstanceCheckName structure to the name of the DigitalTwinsInstance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DigitalTwinsNameResult>> CheckDigitalTwinsNameAvailabilityAsync(AzureLocation location, DigitalTwinsNameContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DigitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDigitalTwinsNameAvailability");
            scope.Start();
            try
            {
                var response = await DigitalTwinsDescriptionDigitalTwinsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a DigitalTwinsInstance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of DigitalTwinsInstance. </param>
        /// <param name="content"> Set the name parameter in the DigitalTwinsInstanceCheckName structure to the name of the DigitalTwinsInstance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DigitalTwinsNameResult> CheckDigitalTwinsNameAvailability(AzureLocation location, DigitalTwinsNameContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DigitalTwinsDescriptionDigitalTwinsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDigitalTwinsNameAvailability");
            scope.Start();
            try
            {
                var response = DigitalTwinsDescriptionDigitalTwinsRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
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