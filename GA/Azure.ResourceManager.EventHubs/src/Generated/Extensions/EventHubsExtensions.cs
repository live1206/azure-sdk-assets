// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EventHubs. </summary>
    public static partial class EventHubsExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region EventHubsClusterResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsClusterResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsClusterResource" /> object. </returns>
        public static EventHubsClusterResource GetEventHubsClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsClusterResource.ValidateResourceId(id);
                return new EventHubsClusterResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsNamespaceResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsNamespaceResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsNamespaceResource" /> object. </returns>
        public static EventHubsNamespaceResource GetEventHubsNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsNamespaceResource.ValidateResourceId(id);
                return new EventHubsNamespaceResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsNetworkRuleSetResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsNetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsNetworkRuleSetResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsNetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsNetworkRuleSetResource" /> object. </returns>
        public static EventHubsNetworkRuleSetResource GetEventHubsNetworkRuleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsNetworkRuleSetResource.ValidateResourceId(id);
                return new EventHubsNetworkRuleSetResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsNamespaceAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsNamespaceAuthorizationRuleResource" /> object. </returns>
        public static EventHubsNamespaceAuthorizationRuleResource GetEventHubsNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsNamespaceAuthorizationRuleResource.ValidateResourceId(id);
                return new EventHubsNamespaceAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsDisasterRecoveryAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> object. </returns>
        public static EventHubsDisasterRecoveryAuthorizationRuleResource GetEventHubsDisasterRecoveryAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsDisasterRecoveryAuthorizationRuleResource.ValidateResourceId(id);
                return new EventHubsDisasterRecoveryAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubAuthorizationRuleResource.CreateResourceIdentifier" /> to create an <see cref="EventHubAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubAuthorizationRuleResource" /> object. </returns>
        public static EventHubAuthorizationRuleResource GetEventHubAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubAuthorizationRuleResource.ValidateResourceId(id);
                return new EventHubAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsPrivateEndpointConnectionResource" /> object. </returns>
        public static EventHubsPrivateEndpointConnectionResource GetEventHubsPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new EventHubsPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsDisasterRecoveryResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsDisasterRecoveryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsDisasterRecoveryResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsDisasterRecoveryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsDisasterRecoveryResource" /> object. </returns>
        public static EventHubsDisasterRecoveryResource GetEventHubsDisasterRecoveryResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsDisasterRecoveryResource.ValidateResourceId(id);
                return new EventHubsDisasterRecoveryResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubResource.CreateResourceIdentifier" /> to create an <see cref="EventHubResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubResource" /> object. </returns>
        public static EventHubResource GetEventHubResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubResource.ValidateResourceId(id);
                return new EventHubResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsConsumerGroupResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsConsumerGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsConsumerGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsConsumerGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsConsumerGroupResource" /> object. </returns>
        public static EventHubsConsumerGroupResource GetEventHubsConsumerGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsConsumerGroupResource.ValidateResourceId(id);
                return new EventHubsConsumerGroupResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsSchemaGroupResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsSchemaGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsSchemaGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsSchemaGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsSchemaGroupResource" /> object. </returns>
        public static EventHubsSchemaGroupResource GetEventHubsSchemaGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsSchemaGroupResource.ValidateResourceId(id);
                return new EventHubsSchemaGroupResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubsApplicationGroupResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubsApplicationGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsApplicationGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsApplicationGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsApplicationGroupResource" /> object. </returns>
        public static EventHubsApplicationGroupResource GetEventHubsApplicationGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubsApplicationGroupResource.ValidateResourceId(id);
                return new EventHubsApplicationGroupResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of EventHubsClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EventHubsClusterResources and their operations over a EventHubsClusterResource. </returns>
        public static EventHubsClusterCollection GetEventHubsClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetEventHubsClusters();
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EventHubsClusterResource>> GetEventHubsClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetEventHubsClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EventHubsClusterResource> GetEventHubsCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetEventHubsClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of EventHubsNamespaceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EventHubsNamespaceResources and their operations over a EventHubsNamespaceResource. </returns>
        public static EventHubsNamespaceCollection GetEventHubsNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetEventHubsNamespaces();
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EventHubsNamespaceResource>> GetEventHubsNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetEventHubsNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EventHubsNamespaceResource> GetEventHubsNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetEventHubsNamespaces().Get(namespaceName, cancellationToken);
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListAvailableClusterRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailableCluster> GetAvailableClusterRegionClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAvailableClusterRegionClustersAsync(cancellationToken);
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListAvailableClusterRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailableCluster> GetAvailableClusterRegionClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetAvailableClusterRegionClusters(cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EventHubsClusterResource> GetEventHubsClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetEventHubsClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EventHubsClusterResource> GetEventHubsClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetEventHubsClusters(cancellationToken);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EventHubsNamespaceResource> GetEventHubsNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetEventHubsNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EventHubsNamespaceResource> GetEventHubsNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetEventHubsNamespaces(cancellationToken);
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<EventHubsNameAvailabilityResult>> CheckEventHubsNamespaceNameAvailabilityAsync(this SubscriptionResource subscriptionResource, EventHubsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetSubscriptionResourceExtensionClient(subscriptionResource).CheckEventHubsNamespaceNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<EventHubsNameAvailabilityResult> CheckEventHubsNamespaceNameAvailability(this SubscriptionResource subscriptionResource, EventHubsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).CheckEventHubsNamespaceNameAvailability(content, cancellationToken);
        }
    }
}