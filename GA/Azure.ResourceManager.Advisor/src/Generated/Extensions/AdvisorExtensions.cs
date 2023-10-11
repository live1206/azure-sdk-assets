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
using Azure.ResourceManager.Advisor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Advisor
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Advisor. </summary>
    public static partial class AdvisorExtensions
    {
        private static ArmResourceExtensionClient GetArmResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ArmResourceExtensionClient(client, resource.Id);
            });
        }

        private static ArmResourceExtensionClient GetArmResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ArmResourceExtensionClient(client, scope);
            });
        }

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

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new TenantResourceExtensionClient(client, resource.Id);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new TenantResourceExtensionClient(client, scope);
            });
        }
        #region MetadataEntityResource
        /// <summary>
        /// Gets an object representing a <see cref="MetadataEntityResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MetadataEntityResource.CreateResourceIdentifier" /> to create a <see cref="MetadataEntityResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MetadataEntityResource" /> object. </returns>
        public static MetadataEntityResource GetMetadataEntityResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MetadataEntityResource.ValidateResourceId(id);
                return new MetadataEntityResource(client, id);
            }
            );
        }
        #endregion

        #region ResourceRecommendationBaseResource
        /// <summary>
        /// Gets an object representing a <see cref="ResourceRecommendationBaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceRecommendationBaseResource.CreateResourceIdentifier" /> to create a <see cref="ResourceRecommendationBaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceRecommendationBaseResource" /> object. </returns>
        public static ResourceRecommendationBaseResource GetResourceRecommendationBaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ResourceRecommendationBaseResource.ValidateResourceId(id);
                return new ResourceRecommendationBaseResource(client, id);
            }
            );
        }
        #endregion

        #region SuppressionContractResource
        /// <summary>
        /// Gets an object representing a <see cref="SuppressionContractResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SuppressionContractResource.CreateResourceIdentifier" /> to create a <see cref="SuppressionContractResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SuppressionContractResource" /> object. </returns>
        public static SuppressionContractResource GetSuppressionContractResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SuppressionContractResource.ValidateResourceId(id);
                return new SuppressionContractResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of ResourceRecommendationBaseResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ResourceRecommendationBaseResources and their operations over a ResourceRecommendationBaseResource. </returns>
        public static ResourceRecommendationBaseCollection GetResourceRecommendationBases(this ArmClient client, ResourceIdentifier scope)
        {
            return GetArmResourceExtensionClient(client, scope).GetResourceRecommendationBases();
        }

        /// <summary>
        /// Obtains details of a cached recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="recommendationId"> The recommendation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recommendationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendationId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ResourceRecommendationBaseResource>> GetResourceRecommendationBaseAsync(this ArmClient client, ResourceIdentifier scope, string recommendationId, CancellationToken cancellationToken = default)
        {
            return await client.GetResourceRecommendationBases(scope).GetAsync(recommendationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Obtains details of a cached recommendation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="recommendationId"> The recommendation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recommendationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendationId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ResourceRecommendationBaseResource> GetResourceRecommendationBase(this ArmClient client, ResourceIdentifier scope, string recommendationId, CancellationToken cancellationToken = default)
        {
            return client.GetResourceRecommendationBases(scope).Get(recommendationId, cancellationToken);
        }

        /// <summary>
        /// Retrieve Azure Advisor configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Advisor/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfigData> GetConfigurationsAsync(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetConfigurationsAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieve Azure Advisor configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Advisor/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfigData> GetConfigurations(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetConfigurations(cancellationToken);
        }

        /// <summary>
        /// Create/Overwrite Azure Advisor configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Advisor/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateInResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configurationName"> Advisor configuration name. Value must be 'default'. </param>
        /// <param name="data"> The Azure Advisor configuration data structure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public static async Task<Response<ConfigData>> CreateConfigurationAsync(this ResourceGroupResource resourceGroupResource, ConfigurationName configurationName, ConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            return await GetResourceGroupResourceExtensionClient(resourceGroupResource).CreateConfigurationAsync(configurationName, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create/Overwrite Azure Advisor configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Advisor/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateInResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configurationName"> Advisor configuration name. Value must be 'default'. </param>
        /// <param name="data"> The Azure Advisor configuration data structure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public static Response<ConfigData> CreateConfiguration(this ResourceGroupResource resourceGroupResource, ConfigurationName configurationName, ConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            return GetResourceGroupResourceExtensionClient(resourceGroupResource).CreateConfiguration(configurationName, data, cancellationToken);
        }

        /// <summary>
        /// Retrieve Azure Advisor configurations and also retrieve configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfigData> GetConfigurationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetConfigurationsAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieve Azure Advisor configurations and also retrieve configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfigData> GetConfigurations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetConfigurations(cancellationToken);
        }

        /// <summary>
        /// Create/Overwrite Azure Advisor configuration and also delete all configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="configurationName"> Advisor configuration name. Value must be 'default'. </param>
        /// <param name="data"> The Azure Advisor configuration data structure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public static async Task<Response<ConfigData>> CreateConfigurationAsync(this SubscriptionResource subscriptionResource, ConfigurationName configurationName, ConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            return await GetSubscriptionResourceExtensionClient(subscriptionResource).CreateConfigurationAsync(configurationName, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create/Overwrite Azure Advisor configuration and also delete all configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="configurationName"> Advisor configuration name. Value must be 'default'. </param>
        /// <param name="data"> The Azure Advisor configuration data structure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public static Response<ConfigData> CreateConfiguration(this SubscriptionResource subscriptionResource, ConfigurationName configurationName, ConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).CreateConfiguration(configurationName, data, cancellationToken);
        }

        /// <summary>
        /// Initiates the recommendation generation or computation process for a subscription. This operation is asynchronous. The generated recommendations are stored in a cache in the Advisor service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Generate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response> GenerateRecommendationAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionResourceExtensionClient(subscriptionResource).GenerateRecommendationAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Initiates the recommendation generation or computation process for a subscription. This operation is asynchronous. The generated recommendations are stored in a cache in the Advisor service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Generate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response GenerateRecommendation(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GenerateRecommendation(cancellationToken);
        }

        /// <summary>
        /// Retrieves the status of the recommendation computation or generation process. Invoke this API after calling the generation recommendation. The URI of this API is returned in the Location field of the response header.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetGenerateStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="operationId"> The operation ID, which can be found from the Location field in the generate recommendation response header. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response> GetGenerateStatusRecommendationAsync(this SubscriptionResource subscriptionResource, Guid operationId, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionResourceExtensionClient(subscriptionResource).GetGenerateStatusRecommendationAsync(operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the status of the recommendation computation or generation process. Invoke this API after calling the generation recommendation. The URI of this API is returned in the Location field of the response header.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetGenerateStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="operationId"> The operation ID, which can be found from the Location field in the generate recommendation response header. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response GetGenerateStatusRecommendation(this SubscriptionResource subscriptionResource, Guid operationId, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetGenerateStatusRecommendation(operationId, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of snoozed or dismissed suppressions for a subscription. The snoozed or dismissed attribute of a recommendation is referred to as a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/suppressions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> The number of suppressions per page if a paged version of this API is being used. </param>
        /// <param name="skipToken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SuppressionContractResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SuppressionContractResource> GetSuppressionContractsAsync(this SubscriptionResource subscriptionResource, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetSuppressionContractsAsync(top, skipToken, cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of snoozed or dismissed suppressions for a subscription. The snoozed or dismissed attribute of a recommendation is referred to as a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/suppressions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> The number of suppressions per page if a paged version of this API is being used. </param>
        /// <param name="skipToken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SuppressionContractResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SuppressionContractResource> GetSuppressionContracts(this SubscriptionResource subscriptionResource, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetSuppressionContracts(top, skipToken, cancellationToken);
        }

        /// <summary> Gets a collection of MetadataEntityResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MetadataEntityResources and their operations over a MetadataEntityResource. </returns>
        public static MetadataEntityCollection GetMetadataEntities(this TenantResource tenantResource)
        {
            return GetTenantResourceExtensionClient(tenantResource).GetMetadataEntities();
        }

        /// <summary>
        /// Gets the metadata entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Advisor/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecommendationMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MetadataEntityResource>> GetMetadataEntityAsync(this TenantResource tenantResource, string name, CancellationToken cancellationToken = default)
        {
            return await tenantResource.GetMetadataEntities().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the metadata entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Advisor/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecommendationMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MetadataEntityResource> GetMetadataEntity(this TenantResource tenantResource, string name, CancellationToken cancellationToken = default)
        {
            return tenantResource.GetMetadataEntities().Get(name, cancellationToken);
        }
    }
}