// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingBenefitsSavingsPlanResource" /> and their operations.
    /// Each <see cref="BillingBenefitsSavingsPlanResource" /> in the collection will belong to the same instance of <see cref="BillingBenefitsSavingsPlanOrderResource" />.
    /// To get a <see cref="BillingBenefitsSavingsPlanCollection" /> instance call the GetBillingBenefitsSavingsPlans method from an instance of <see cref="BillingBenefitsSavingsPlanOrderResource" />.
    /// </summary>
    public partial class BillingBenefitsSavingsPlanCollection : ArmCollection, IEnumerable<BillingBenefitsSavingsPlanResource>, IAsyncEnumerable<BillingBenefitsSavingsPlanResource>
    {
        private readonly ClientDiagnostics _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics;
        private readonly SavingsPlanRestOperations _billingBenefitsSavingsPlanSavingsPlanRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanCollection"/> class for mocking. </summary>
        protected BillingBenefitsSavingsPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingBenefitsSavingsPlanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.BillingBenefits", BillingBenefitsSavingsPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingBenefitsSavingsPlanResource.ResourceType, out string billingBenefitsSavingsPlanSavingsPlanApiVersion);
            _billingBenefitsSavingsPlanSavingsPlanRestClient = new SavingsPlanRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingBenefitsSavingsPlanSavingsPlanApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingBenefitsSavingsPlanOrderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingBenefitsSavingsPlanOrderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        public virtual async Task<Response<BillingBenefitsSavingsPlanResource>> GetAsync(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanId, nameof(savingsPlanId));

            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanSavingsPlanRestClient.GetAsync(Id.Name, savingsPlanId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        public virtual Response<BillingBenefitsSavingsPlanResource> Get(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanId, nameof(savingsPlanId));

            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanSavingsPlanRestClient.Get(Id.Name, savingsPlanId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List savings plans in an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingBenefitsSavingsPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingBenefitsSavingsPlanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingBenefitsSavingsPlanResource(Client, BillingBenefitsSavingsPlanData.DeserializeBillingBenefitsSavingsPlanData(e)), _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics, Pipeline, "BillingBenefitsSavingsPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List savings plans in an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingBenefitsSavingsPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingBenefitsSavingsPlanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingBenefitsSavingsPlanResource(Client, BillingBenefitsSavingsPlanData.DeserializeBillingBenefitsSavingsPlanData(e)), _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics, Pipeline, "BillingBenefitsSavingsPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanId, nameof(savingsPlanId));

            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanSavingsPlanRestClient.GetAsync(Id.Name, savingsPlanId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        public virtual Response<bool> Exists(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanId, nameof(savingsPlanId));

            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanSavingsPlanRestClient.Get(Id.Name, savingsPlanId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingBenefitsSavingsPlanResource> IEnumerable<BillingBenefitsSavingsPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingBenefitsSavingsPlanResource> IAsyncEnumerable<BillingBenefitsSavingsPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}