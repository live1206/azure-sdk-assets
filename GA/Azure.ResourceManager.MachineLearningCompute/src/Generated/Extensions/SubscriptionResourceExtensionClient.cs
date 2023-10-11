// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MachineLearningCompute
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _operationalizationClusterClientDiagnostics;
        private OperationalizationClustersRestOperations _operationalizationClusterRestClient;

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

        private ClientDiagnostics OperationalizationClusterClientDiagnostics => _operationalizationClusterClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearningCompute", OperationalizationClusterResource.ResourceType.Namespace, Diagnostics);
        private OperationalizationClustersRestOperations OperationalizationClusterRestClient => _operationalizationClusterRestClient ??= new OperationalizationClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(OperationalizationClusterResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningCompute/operationalizationClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalizationClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalizationClusterResource> GetOperationalizationClustersAsync(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationalizationClusterRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationalizationClusterRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new OperationalizationClusterResource(Client, OperationalizationClusterData.DeserializeOperationalizationClusterData(e)), OperationalizationClusterClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOperationalizationClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningCompute/operationalizationClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalizationClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalizationClusterResource> GetOperationalizationClusters(string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationalizationClusterRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationalizationClusterRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new OperationalizationClusterResource(Client, OperationalizationClusterData.DeserializeOperationalizationClusterData(e)), OperationalizationClusterClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOperationalizationClusters", "value", "nextLink", cancellationToken);
        }
    }
}