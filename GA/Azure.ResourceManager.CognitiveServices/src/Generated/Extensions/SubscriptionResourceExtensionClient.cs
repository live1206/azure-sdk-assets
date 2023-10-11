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
using Azure.ResourceManager.CognitiveServices.Models;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _cognitiveServicesAccountAccountsClientDiagnostics;
        private AccountsRestOperations _cognitiveServicesAccountAccountsRestClient;
        private ClientDiagnostics _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics;
        private DeletedAccountsRestOperations _cognitiveServicesDeletedAccountDeletedAccountsRestClient;
        private ClientDiagnostics _resourceSkusClientDiagnostics;
        private ResourceSkusRestOperations _resourceSkusRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private CognitiveServicesManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _commitmentTiersClientDiagnostics;
        private CommitmentTiersRestOperations _commitmentTiersRestClient;
        private ClientDiagnostics _modelsClientDiagnostics;
        private ModelsRestOperations _modelsRestClient;
        private ClientDiagnostics _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics;
        private CommitmentPlansRestOperations _cognitiveServicesCommitmentPlanCommitmentPlansRestClient;

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

        private ClientDiagnostics CognitiveServicesAccountAccountsClientDiagnostics => _cognitiveServicesAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations CognitiveServicesAccountAccountsRestClient => _cognitiveServicesAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CognitiveServicesAccountResource.ResourceType));
        private ClientDiagnostics CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics => _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesDeletedAccountResource.ResourceType.Namespace, Diagnostics);
        private DeletedAccountsRestOperations CognitiveServicesDeletedAccountDeletedAccountsRestClient => _cognitiveServicesDeletedAccountDeletedAccountsRestClient ??= new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CognitiveServicesDeletedAccountResource.ResourceType));
        private ClientDiagnostics ResourceSkusClientDiagnostics => _resourceSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceSkusRestOperations ResourceSkusRestClient => _resourceSkusRestClient ??= new ResourceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CognitiveServicesManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CognitiveServicesManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CommitmentTiersClientDiagnostics => _commitmentTiersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CommitmentTiersRestOperations CommitmentTiersRestClient => _commitmentTiersRestClient ??= new CommitmentTiersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ModelsClientDiagnostics => _modelsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ModelsRestOperations ModelsRestClient => _modelsRestClient ??= new ModelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics => _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesCommitmentPlanResource.ResourceType.Namespace, Diagnostics);
        private CommitmentPlansRestOperations CognitiveServicesCommitmentPlanCommitmentPlansRestClient => _cognitiveServicesCommitmentPlanCommitmentPlansRestClient ??= new CommitmentPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CognitiveServicesCommitmentPlanResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CognitiveServicesDeletedAccountResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of CognitiveServicesDeletedAccountResources and their operations over a CognitiveServicesDeletedAccountResource. </returns>
        public virtual CognitiveServicesDeletedAccountCollection GetCognitiveServicesDeletedAccounts()
        {
            return GetCachedClient(Client => new CognitiveServicesDeletedAccountCollection(Client, Id));
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesAccountResource> GetCognitiveServicesAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CognitiveServicesAccountAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CognitiveServicesAccountAccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesAccountResource(Client, CognitiveServicesAccountData.DeserializeCognitiveServicesAccountData(e)), CognitiveServicesAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCognitiveServicesAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesAccountResource> GetCognitiveServicesAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CognitiveServicesAccountAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CognitiveServicesAccountAccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesAccountResource(Client, CognitiveServicesAccountData.DeserializeCognitiveServicesAccountData(e)), CognitiveServicesAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCognitiveServicesAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesDeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesDeletedAccountResource> GetDeletedAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CognitiveServicesDeletedAccountDeletedAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CognitiveServicesDeletedAccountDeletedAccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesDeletedAccountResource(Client, CognitiveServicesAccountData.DeserializeCognitiveServicesAccountData(e)), CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesDeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesDeletedAccountResource> GetDeletedAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CognitiveServicesDeletedAccountDeletedAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CognitiveServicesDeletedAccountDeletedAccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesDeletedAccountResource(Client, CognitiveServicesAccountData.DeserializeCognitiveServicesAccountData(e)), CognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Microsoft.CognitiveServices SKUs available for your Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCognitiveServicesSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableCognitiveServicesSku> GetResourceSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, AvailableCognitiveServicesSku.DeserializeAvailableCognitiveServicesSku, ResourceSkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourceSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Microsoft.CognitiveServices SKUs available for your Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCognitiveServicesSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableCognitiveServicesSku> GetResourceSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, AvailableCognitiveServicesSku.DeserializeAvailableCognitiveServicesSku, ResourceSkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourceSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get usages for the requested subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of usages to return. The supported parameter is name.value (name of the metric, can have an or of multiple names). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceAccountUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceAccountUsage> GetUsagesAsync(AzureLocation location, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ServiceAccountUsage.DeserializeServiceAccountUsage, UsagesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get usages for the requested subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of usages to return. The supported parameter is name.value (name of the metric, can have an or of multiple names). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceAccountUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceAccountUsage> GetUsages(AzureLocation location, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ServiceAccountUsage.DeserializeServiceAccountUsage, UsagesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check available SKUs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/checkSkuAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckSkuAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="content"> Check SKU Availability POST body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesSkuAvailabilityList" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesSkuAvailabilityList> CheckSkuAvailabilityAsync(AzureLocation location, CognitiveServicesSkuAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateCheckSkuAvailabilityRequest(Id.SubscriptionId, location, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, CognitiveServicesSkuAvailabilityList.DeserializeCognitiveServicesSkuAvailabilityList, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.CheckSkuAvailability", "value", null, cancellationToken);
        }

        /// <summary>
        /// Check available SKUs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/checkSkuAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckSkuAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="content"> Check SKU Availability POST body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesSkuAvailabilityList" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesSkuAvailabilityList> CheckSkuAvailability(AzureLocation location, CognitiveServicesSkuAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateCheckSkuAvailabilityRequest(Id.SubscriptionId, location, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, CognitiveServicesSkuAvailabilityList.DeserializeCognitiveServicesSkuAvailabilityList, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.CheckSkuAvailability", "value", null, cancellationToken);
        }

        /// <summary>
        /// Check whether a domain is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/checkDomainAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckDomainAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Check Domain Availability parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CognitiveServicesDomainAvailabilityList>> CheckDomainAvailabilityAsync(CognitiveServicesDomainAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDomainAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckDomainAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check whether a domain is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/checkDomainAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckDomainAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Check Domain Availability parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CognitiveServicesDomainAvailabilityList> CheckDomainAvailability(CognitiveServicesDomainAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDomainAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckDomainAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Commitment Tiers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/commitmentTiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentTiers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommitmentTier" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommitmentTier> GetCommitmentTiersAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CommitmentTiersRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CommitmentTiersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, CommitmentTier.DeserializeCommitmentTier, CommitmentTiersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCommitmentTiers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Commitment Tiers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/commitmentTiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentTiers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommitmentTier" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommitmentTier> GetCommitmentTiers(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CommitmentTiersRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CommitmentTiersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, CommitmentTier.DeserializeCommitmentTier, CommitmentTiersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCommitmentTiers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Models.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/models</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Models_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesModel" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesModel> GetModelsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ModelsRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ModelsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, CognitiveServicesModel.DeserializeCognitiveServicesModel, ModelsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetModels", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Models.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/models</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Models_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesModel" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesModel> GetModels(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ModelsRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ModelsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, CognitiveServicesModel.DeserializeCognitiveServicesModel, ModelsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetModels", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/commitmentPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_ListPlansBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CognitiveServicesCommitmentPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CognitiveServicesCommitmentPlanResource> GetCognitiveServicesCommitmentPlansAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesCommitmentPlanResource(Client, CommitmentPlanData.DeserializeCommitmentPlanData(e)), CognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCognitiveServicesCommitmentPlans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/commitmentPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_ListPlansBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CognitiveServicesCommitmentPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CognitiveServicesCommitmentPlanResource> GetCognitiveServicesCommitmentPlans(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateListPlansBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CognitiveServicesCommitmentPlanResource(Client, CommitmentPlanData.DeserializeCommitmentPlanData(e)), CognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCognitiveServicesCommitmentPlans", "value", "nextLink", cancellationToken);
        }
    }
}