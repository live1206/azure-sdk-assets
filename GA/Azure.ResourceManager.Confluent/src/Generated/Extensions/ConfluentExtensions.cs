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
using Azure.ResourceManager.Confluent.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Confluent
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Confluent. </summary>
    public static partial class ConfluentExtensions
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
        #region ConfluentOrganizationResource
        /// <summary>
        /// Gets an object representing a <see cref="ConfluentOrganizationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConfluentOrganizationResource.CreateResourceIdentifier" /> to create a <see cref="ConfluentOrganizationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfluentOrganizationResource" /> object. </returns>
        public static ConfluentOrganizationResource GetConfluentOrganizationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConfluentOrganizationResource.ValidateResourceId(id);
                return new ConfluentOrganizationResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of ConfluentOrganizationResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ConfluentOrganizationResources and their operations over a ConfluentOrganizationResource. </returns>
        public static ConfluentOrganizationCollection GetConfluentOrganizations(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetConfluentOrganizations();
        }

        /// <summary>
        /// Get the properties of a specific Organization resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ConfluentOrganizationResource>> GetConfluentOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetConfluentOrganizations().GetAsync(organizationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific Organization resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ConfluentOrganizationResource> GetConfluentOrganization(this ResourceGroupResource resourceGroupResource, string organizationName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetConfluentOrganizations().Get(organizationName, cancellationToken);
        }

        /// <summary>
        /// Organization Validate proxy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/validations/{organizationName}/orgvalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validations_ValidateOrganization</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="data"> Organization resource model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public static async Task<Response<ConfluentOrganizationResource>> ValidateOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationName, ConfluentOrganizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));
            Argument.AssertNotNull(data, nameof(data));

            return await GetResourceGroupResourceExtensionClient(resourceGroupResource).ValidateOrganizationAsync(organizationName, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Organization Validate proxy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/validations/{organizationName}/orgvalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validations_ValidateOrganization</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="data"> Organization resource model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public static Response<ConfluentOrganizationResource> ValidateOrganization(this ResourceGroupResource resourceGroupResource, string organizationName, ConfluentOrganizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));
            Argument.AssertNotNull(data, nameof(data));

            return GetResourceGroupResourceExtensionClient(resourceGroupResource).ValidateOrganization(organizationName, data, cancellationToken);
        }

        /// <summary>
        /// List Confluent marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfluentAgreement" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfluentAgreement> GetMarketplaceAgreementsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetMarketplaceAgreementsAsync(cancellationToken);
        }

        /// <summary>
        /// List Confluent marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfluentAgreement" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfluentAgreement> GetMarketplaceAgreements(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetMarketplaceAgreements(cancellationToken);
        }

        /// <summary>
        /// Create Confluent Marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> Confluent Marketplace Agreement resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<ConfluentAgreement>> CreateMarketplaceAgreementAsync(this SubscriptionResource subscriptionResource, ConfluentAgreement body = null, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionResourceExtensionClient(subscriptionResource).CreateMarketplaceAgreementAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create Confluent Marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> Confluent Marketplace Agreement resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<ConfluentAgreement> CreateMarketplaceAgreement(this SubscriptionResource subscriptionResource, ConfluentAgreement body = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).CreateMarketplaceAgreement(body, cancellationToken);
        }

        /// <summary>
        /// List all organizations under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfluentOrganizationResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfluentOrganizationResource> GetConfluentOrganizationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetConfluentOrganizationsAsync(cancellationToken);
        }

        /// <summary>
        /// List all organizations under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfluentOrganizationResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfluentOrganizationResource> GetConfluentOrganizations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetConfluentOrganizations(cancellationToken);
        }
    }
}