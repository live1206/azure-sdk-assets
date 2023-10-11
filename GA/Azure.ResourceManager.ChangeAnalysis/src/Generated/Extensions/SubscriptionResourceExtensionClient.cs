// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ChangeAnalysis.Models;

namespace Azure.ResourceManager.ChangeAnalysis
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _changesClientDiagnostics;
        private ChangesRestOperations _changesRestClient;

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

        private ClientDiagnostics ChangesClientDiagnostics => _changesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ChangeAnalysis", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ChangesRestOperations ChangesRestClient => _changesRestClient ??= new ChangesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List the changes of a subscription within the specified time range. Customer data will always be masked.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ChangeAnalysis/changes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Changes_ListChangesBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DetectedChangeData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DetectedChangeData> GetChangesBySubscriptionAsync(DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ChangesRestClient.CreateListChangesBySubscriptionRequest(Id.SubscriptionId, startTime, endTime, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ChangesRestClient.CreateListChangesBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, startTime, endTime, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DetectedChangeData.DeserializeDetectedChangeData, ChangesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetChangesBySubscription", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the changes of a subscription within the specified time range. Customer data will always be masked.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ChangeAnalysis/changes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Changes_ListChangesBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DetectedChangeData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DetectedChangeData> GetChangesBySubscription(DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ChangesRestClient.CreateListChangesBySubscriptionRequest(Id.SubscriptionId, startTime, endTime, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ChangesRestClient.CreateListChangesBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, startTime, endTime, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DetectedChangeData.DeserializeDetectedChangeData, ChangesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetChangesBySubscription", "value", "nextLink", cancellationToken);
        }
    }
}