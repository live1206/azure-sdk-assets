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

namespace Azure.ResourceManager.Maps
{
    /// <summary>
    /// A class representing a collection of <see cref="MapsCreatorResource" /> and their operations.
    /// Each <see cref="MapsCreatorResource" /> in the collection will belong to the same instance of <see cref="MapsAccountResource" />.
    /// To get a <see cref="MapsCreatorCollection" /> instance call the GetMapsCreators method from an instance of <see cref="MapsAccountResource" />.
    /// </summary>
    public partial class MapsCreatorCollection : ArmCollection, IEnumerable<MapsCreatorResource>, IAsyncEnumerable<MapsCreatorResource>
    {
        private readonly ClientDiagnostics _mapsCreatorCreatorsClientDiagnostics;
        private readonly CreatorsRestOperations _mapsCreatorCreatorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MapsCreatorCollection"/> class for mocking. </summary>
        protected MapsCreatorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MapsCreatorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MapsCreatorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mapsCreatorCreatorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Maps", MapsCreatorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MapsCreatorResource.ResourceType, out string mapsCreatorCreatorsApiVersion);
            _mapsCreatorCreatorsRestClient = new CreatorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mapsCreatorCreatorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MapsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MapsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Maps Creator resource. Creator resource will manage Azure resources required to populate a custom set of mapping data. It requires an account to exist before it can be created.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="data"> The new or updated parameters for the Creator resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MapsCreatorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string creatorName, MapsCreatorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mapsCreatorCreatorsClientDiagnostics.CreateScope("MapsCreatorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mapsCreatorCreatorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MapsArmOperation<MapsCreatorResource>(Response.FromValue(new MapsCreatorResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Maps Creator resource. Creator resource will manage Azure resources required to populate a custom set of mapping data. It requires an account to exist before it can be created.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="data"> The new or updated parameters for the Creator resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MapsCreatorResource> CreateOrUpdate(WaitUntil waitUntil, string creatorName, MapsCreatorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mapsCreatorCreatorsClientDiagnostics.CreateScope("MapsCreatorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mapsCreatorCreatorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, data, cancellationToken);
                var operation = new MapsArmOperation<MapsCreatorResource>(Response.FromValue(new MapsCreatorResource(Client, response), response.GetRawResponse()));
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
        /// Get a Maps Creator resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual async Task<Response<MapsCreatorResource>> GetAsync(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _mapsCreatorCreatorsClientDiagnostics.CreateScope("MapsCreatorCollection.Get");
            scope.Start();
            try
            {
                var response = await _mapsCreatorCreatorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MapsCreatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Maps Creator resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual Response<MapsCreatorResource> Get(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _mapsCreatorCreatorsClientDiagnostics.CreateScope("MapsCreatorCollection.Get");
            scope.Start();
            try
            {
                var response = _mapsCreatorCreatorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MapsCreatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all Creator instances for an Azure Maps Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MapsCreatorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MapsCreatorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mapsCreatorCreatorsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mapsCreatorCreatorsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MapsCreatorResource(Client, MapsCreatorData.DeserializeMapsCreatorData(e)), _mapsCreatorCreatorsClientDiagnostics, Pipeline, "MapsCreatorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all Creator instances for an Azure Maps Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MapsCreatorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MapsCreatorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mapsCreatorCreatorsRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mapsCreatorCreatorsRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MapsCreatorResource(Client, MapsCreatorData.DeserializeMapsCreatorData(e)), _mapsCreatorCreatorsClientDiagnostics, Pipeline, "MapsCreatorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _mapsCreatorCreatorsClientDiagnostics.CreateScope("MapsCreatorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mapsCreatorCreatorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Creators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual Response<bool> Exists(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _mapsCreatorCreatorsClientDiagnostics.CreateScope("MapsCreatorCollection.Exists");
            scope.Start();
            try
            {
                var response = _mapsCreatorCreatorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MapsCreatorResource> IEnumerable<MapsCreatorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MapsCreatorResource> IAsyncEnumerable<MapsCreatorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}