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
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _serviceFabricClusterClustersClientDiagnostics;
        private ClustersRestOperations _serviceFabricClusterClustersRestClient;
        private ClientDiagnostics _clusterVersionsClientDiagnostics;
        private ClusterVersionsRestOperations _clusterVersionsRestClient;

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

        private ClientDiagnostics ServiceFabricClusterClustersClientDiagnostics => _serviceFabricClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ServiceFabricClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations ServiceFabricClusterClustersRestClient => _serviceFabricClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ServiceFabricClusterResource.ResourceType));
        private ClientDiagnostics ClusterVersionsClientDiagnostics => _clusterVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ClusterVersionsRestOperations ClusterVersionsRestClient => _clusterVersionsRestClient ??= new ClusterVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricClusterResource> GetServiceFabricClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceFabricClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ServiceFabricClusterResource(Client, ServiceFabricClusterData.DeserializeServiceFabricClusterData(e)), ServiceFabricClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetServiceFabricClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricClusterResource> GetServiceFabricClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceFabricClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ServiceFabricClusterResource(Client, ServiceFabricClusterData.DeserializeServiceFabricClusterData(e)), ServiceFabricClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetServiceFabricClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetRequest(Id.SubscriptionId, location, clusterVersion);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersions(AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetRequest(Id.SubscriptionId, location, clusterVersion);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_GetByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetByEnvironmentRequest(Id.SubscriptionId, location, environment, clusterVersion);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_GetByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetByEnvironmentRequest(Id.SubscriptionId, location, environment, clusterVersion);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersions(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_ListByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListByEnvironmentRequest(Id.SubscriptionId, location, environment);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_ListByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListByEnvironmentRequest(Id.SubscriptionId, location, environment);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult, ClusterVersionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }
    }
}