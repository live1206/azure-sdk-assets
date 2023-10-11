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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="PartnerRegistrationResource" /> and their operations.
    /// Each <see cref="PartnerRegistrationResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PartnerRegistrationCollection" /> instance call the GetPartnerRegistrations method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PartnerRegistrationCollection : ArmCollection, IEnumerable<PartnerRegistrationResource>, IAsyncEnumerable<PartnerRegistrationResource>
    {
        private readonly ClientDiagnostics _partnerRegistrationClientDiagnostics;
        private readonly PartnerRegistrationsRestOperations _partnerRegistrationRestClient;

        /// <summary> Initializes a new instance of the <see cref="PartnerRegistrationCollection"/> class for mocking. </summary>
        protected PartnerRegistrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerRegistrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PartnerRegistrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", PartnerRegistrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PartnerRegistrationResource.ResourceType, out string partnerRegistrationApiVersion);
            _partnerRegistrationRestClient = new PartnerRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerRegistrationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new partner registration with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerRegistrationName"> Name of the partner registration. </param>
        /// <param name="data"> PartnerRegistration information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerRegistrationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PartnerRegistrationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string partnerRegistrationName, PartnerRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerRegistrationName, nameof(partnerRegistrationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerRegistrationClientDiagnostics.CreateScope("PartnerRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _partnerRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<PartnerRegistrationResource>(new PartnerRegistrationOperationSource(Client), _partnerRegistrationClientDiagnostics, Pipeline, _partnerRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new partner registration with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerRegistrationName"> Name of the partner registration. </param>
        /// <param name="data"> PartnerRegistration information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerRegistrationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PartnerRegistrationResource> CreateOrUpdate(WaitUntil waitUntil, string partnerRegistrationName, PartnerRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerRegistrationName, nameof(partnerRegistrationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _partnerRegistrationClientDiagnostics.CreateScope("PartnerRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _partnerRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, data, cancellationToken);
                var operation = new EventGridArmOperation<PartnerRegistrationResource>(new PartnerRegistrationOperationSource(Client), _partnerRegistrationClientDiagnostics, Pipeline, _partnerRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a partner registration with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerRegistrationName"> Name of the partner registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerRegistrationName"/> is null. </exception>
        public virtual async Task<Response<PartnerRegistrationResource>> GetAsync(string partnerRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerRegistrationName, nameof(partnerRegistrationName));

            using var scope = _partnerRegistrationClientDiagnostics.CreateScope("PartnerRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _partnerRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a partner registration with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerRegistrationName"> Name of the partner registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerRegistrationName"/> is null. </exception>
        public virtual Response<PartnerRegistrationResource> Get(string partnerRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerRegistrationName, nameof(partnerRegistrationName));

            using var scope = _partnerRegistrationClientDiagnostics.CreateScope("PartnerRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = _partnerRegistrationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the partner registrations under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PartnerRegistrationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PartnerRegistrationResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _partnerRegistrationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _partnerRegistrationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PartnerRegistrationResource(Client, PartnerRegistrationData.DeserializePartnerRegistrationData(e)), _partnerRegistrationClientDiagnostics, Pipeline, "PartnerRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the partner registrations under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PartnerRegistrationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PartnerRegistrationResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _partnerRegistrationRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _partnerRegistrationRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PartnerRegistrationResource(Client, PartnerRegistrationData.DeserializePartnerRegistrationData(e)), _partnerRegistrationClientDiagnostics, Pipeline, "PartnerRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerRegistrationName"> Name of the partner registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerRegistrationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string partnerRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerRegistrationName, nameof(partnerRegistrationName));

            using var scope = _partnerRegistrationClientDiagnostics.CreateScope("PartnerRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _partnerRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PartnerRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerRegistrationName"> Name of the partner registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerRegistrationName"/> is null. </exception>
        public virtual Response<bool> Exists(string partnerRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerRegistrationName, nameof(partnerRegistrationName));

            using var scope = _partnerRegistrationClientDiagnostics.CreateScope("PartnerRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _partnerRegistrationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, partnerRegistrationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PartnerRegistrationResource> IEnumerable<PartnerRegistrationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PartnerRegistrationResource> IAsyncEnumerable<PartnerRegistrationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}