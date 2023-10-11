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
using Azure.ResourceManager.Automanage.Models;

namespace Azure.ResourceManager.Automanage
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _automanageConfigurationProfileConfigurationProfilesClientDiagnostics;
        private ConfigurationProfilesRestOperations _automanageConfigurationProfileConfigurationProfilesRestClient;
        private ClientDiagnostics _servicePrincipalsClientDiagnostics;
        private ServicePrincipalsRestOperations _servicePrincipalsRestClient;

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

        private ClientDiagnostics AutomanageConfigurationProfileConfigurationProfilesClientDiagnostics => _automanageConfigurationProfileConfigurationProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageConfigurationProfileResource.ResourceType.Namespace, Diagnostics);
        private ConfigurationProfilesRestOperations AutomanageConfigurationProfileConfigurationProfilesRestClient => _automanageConfigurationProfileConfigurationProfilesRestClient ??= new ConfigurationProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AutomanageConfigurationProfileResource.ResourceType));
        private ClientDiagnostics ServicePrincipalsClientDiagnostics => _servicePrincipalsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automanage", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ServicePrincipalsRestOperations ServicePrincipalsRestClient => _servicePrincipalsRestClient ??= new ServicePrincipalsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Retrieve a list of configuration profile within a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automanage/configurationProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageConfigurationProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageConfigurationProfileResource> GetAutomanageConfigurationProfilesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutomanageConfigurationProfileConfigurationProfilesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageConfigurationProfileResource(Client, AutomanageConfigurationProfileData.DeserializeAutomanageConfigurationProfileData(e)), AutomanageConfigurationProfileConfigurationProfilesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAutomanageConfigurationProfiles", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of configuration profile within a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automanage/configurationProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageConfigurationProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageConfigurationProfileResource> GetAutomanageConfigurationProfiles(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutomanageConfigurationProfileConfigurationProfilesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageConfigurationProfileResource(Client, AutomanageConfigurationProfileData.DeserializeAutomanageConfigurationProfileData(e)), AutomanageConfigurationProfileConfigurationProfilesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAutomanageConfigurationProfiles", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the Automanage AAD first party Application Service Principal details for the subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automanage/servicePrincipals</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServicePrincipals_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageServicePrincipalData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageServicePrincipalData> GetServicePrincipalsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServicePrincipalsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AutomanageServicePrincipalData.DeserializeAutomanageServicePrincipalData, ServicePrincipalsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetServicePrincipals", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the Automanage AAD first party Application Service Principal details for the subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automanage/servicePrincipals</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServicePrincipals_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageServicePrincipalData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageServicePrincipalData> GetServicePrincipals(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServicePrincipalsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AutomanageServicePrincipalData.DeserializeAutomanageServicePrincipalData, ServicePrincipalsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetServicePrincipals", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the Automanage AAD first party Application Service Principal details for the subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automanage/servicePrincipals/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServicePrincipals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomanageServicePrincipalData>> GetServicePrincipalAsync(CancellationToken cancellationToken = default)
        {
            using var scope = ServicePrincipalsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetServicePrincipal");
            scope.Start();
            try
            {
                var response = await ServicePrincipalsRestClient.GetAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Automanage AAD first party Application Service Principal details for the subscription id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Automanage/servicePrincipals/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServicePrincipals_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomanageServicePrincipalData> GetServicePrincipal(CancellationToken cancellationToken = default)
        {
            using var scope = ServicePrincipalsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetServicePrincipal");
            scope.Start();
            try
            {
                var response = ServicePrincipalsRestClient.Get(Id.SubscriptionId, cancellationToken);
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