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
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private AzureReservationAPIRestOperations _defaultRestClient;

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

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzureReservationAPIRestOperations DefaultRestClient => _defaultRestClient ??= new AzureReservationAPIRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ReservationQuotaResources in the SubscriptionResource. </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <returns> An object representing collection of ReservationQuotaResources and their operations over a ReservationQuotaResource. </returns>
        public virtual ReservationQuotaCollection GetAllReservationQuota(string providerId, AzureLocation location)
        {
            return new ReservationQuotaCollection(Client, Id, providerId, location);
        }

        /// <summary> Gets a collection of QuotaRequestDetailResources in the SubscriptionResource. </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <returns> An object representing collection of QuotaRequestDetailResources and their operations over a QuotaRequestDetailResource. </returns>
        public virtual QuotaRequestDetailCollection GetQuotaRequestDetails(string providerId, AzureLocation location)
        {
            return new QuotaRequestDetailCollection(Client, Id, providerId, location);
        }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the specified Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetCatalog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationCatalog" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationCatalog> GetCatalogAsync(SubscriptionResourceGetCatalogOptions options, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateGetCatalogRequest(Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateGetCatalogNextPageRequest(nextLink, Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ReservationCatalog.DeserializeReservationCatalog, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCatalog", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the specified Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetCatalog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationCatalog" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationCatalog> GetCatalog(SubscriptionResourceGetCatalogOptions options, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateGetCatalogRequest(Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateGetCatalogNextPageRequest(nextLink, Id.SubscriptionId, options.ReservedResourceType, options.Location, options.PublisherId, options.OfferId, options.PlanId, options.Filter, options.Skip, options.Take);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ReservationCatalog.DeserializeReservationCatalog, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetCatalog", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get applicable `Reservation`s that are applied to this subscription or a resource group under this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/appliedReservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAppliedReservationList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppliedReservationData>> GetAppliedReservationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAppliedReservations");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.GetAppliedReservationListAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get applicable `Reservation`s that are applied to this subscription or a resource group under this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/appliedReservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAppliedReservationList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppliedReservationData> GetAppliedReservations(CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAppliedReservations");
            scope.Start();
            try
            {
                var response = DefaultRestClient.GetAppliedReservationList(Id.SubscriptionId, cancellationToken);
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