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
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotHub
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.IotHub. </summary>
    public static partial class IotHubExtensions
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
        #region IotHubDescriptionResource
        /// <summary>
        /// Gets an object representing an <see cref="IotHubDescriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubDescriptionResource.CreateResourceIdentifier" /> to create an <see cref="IotHubDescriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotHubDescriptionResource" /> object. </returns>
        public static IotHubDescriptionResource GetIotHubDescriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                IotHubDescriptionResource.ValidateResourceId(id);
                return new IotHubDescriptionResource(client, id);
            }
            );
        }
        #endregion

        #region EventHubConsumerGroupInfoResource
        /// <summary>
        /// Gets an object representing an <see cref="EventHubConsumerGroupInfoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubConsumerGroupInfoResource.CreateResourceIdentifier" /> to create an <see cref="EventHubConsumerGroupInfoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubConsumerGroupInfoResource" /> object. </returns>
        public static EventHubConsumerGroupInfoResource GetEventHubConsumerGroupInfoResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubConsumerGroupInfoResource.ValidateResourceId(id);
                return new EventHubConsumerGroupInfoResource(client, id);
            }
            );
        }
        #endregion

        #region IotHubCertificateDescriptionResource
        /// <summary>
        /// Gets an object representing an <see cref="IotHubCertificateDescriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubCertificateDescriptionResource.CreateResourceIdentifier" /> to create an <see cref="IotHubCertificateDescriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotHubCertificateDescriptionResource" /> object. </returns>
        public static IotHubCertificateDescriptionResource GetIotHubCertificateDescriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                IotHubCertificateDescriptionResource.ValidateResourceId(id);
                return new IotHubCertificateDescriptionResource(client, id);
            }
            );
        }
        #endregion

        #region IotHubPrivateEndpointGroupInformationResource
        /// <summary>
        /// Gets an object representing an <see cref="IotHubPrivateEndpointGroupInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubPrivateEndpointGroupInformationResource.CreateResourceIdentifier" /> to create an <see cref="IotHubPrivateEndpointGroupInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotHubPrivateEndpointGroupInformationResource" /> object. </returns>
        public static IotHubPrivateEndpointGroupInformationResource GetIotHubPrivateEndpointGroupInformationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                IotHubPrivateEndpointGroupInformationResource.ValidateResourceId(id);
                return new IotHubPrivateEndpointGroupInformationResource(client, id);
            }
            );
        }
        #endregion

        #region IotHubPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing an <see cref="IotHubPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="IotHubPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotHubPrivateEndpointConnectionResource" /> object. </returns>
        public static IotHubPrivateEndpointConnectionResource GetIotHubPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                IotHubPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new IotHubPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of IotHubDescriptionResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of IotHubDescriptionResources and their operations over a IotHubDescriptionResource. </returns>
        public static IotHubDescriptionCollection GetIotHubDescriptions(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetIotHubDescriptions();
        }

        /// <summary>
        /// Get the non-security related metadata of an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the IoT hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<IotHubDescriptionResource>> GetIotHubDescriptionAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetIotHubDescriptions().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the non-security related metadata of an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the IoT hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<IotHubDescriptionResource> GetIotHubDescription(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetIotHubDescriptions().Get(resourceName, cancellationToken);
        }

        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/IotHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotHubDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotHubDescriptionResource> GetIotHubDescriptionsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetIotHubDescriptionsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/IotHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotHubDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotHubDescriptionResource> GetIotHubDescriptions(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetIotHubDescriptions(cancellationToken);
        }

        /// <summary>
        /// Check if an IoT hub name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT hub to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<IotHubNameAvailabilityResponse>> CheckIotHubNameAvailabilityAsync(this SubscriptionResource subscriptionResource, IotHubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetSubscriptionResourceExtensionClient(subscriptionResource).CheckIotHubNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if an IoT hub name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT hub to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<IotHubNameAvailabilityResponse> CheckIotHubNameAvailability(this SubscriptionResource subscriptionResource, IotHubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).CheckIotHubNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Get the number of free and paid iot hubs in the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceProviderCommon_GetSubscriptionQuota</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotHubUserSubscriptionQuota" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotHubUserSubscriptionQuota> GetIotHubUserSubscriptionQuotaAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetIotHubUserSubscriptionQuotaAsync(cancellationToken);
        }

        /// <summary>
        /// Get the number of free and paid iot hubs in the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceProviderCommon_GetSubscriptionQuota</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotHubUserSubscriptionQuota" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotHubUserSubscriptionQuota> GetIotHubUserSubscriptionQuota(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetIotHubUserSubscriptionQuota(cancellationToken);
        }
    }
}