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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="DataShareResource" /> and their operations.
    /// Each <see cref="DataShareResource" /> in the collection will belong to the same instance of <see cref="DataShareAccountResource" />.
    /// To get a <see cref="DataShareCollection" /> instance call the GetDataShares method from an instance of <see cref="DataShareAccountResource" />.
    /// </summary>
    public partial class DataShareCollection : ArmCollection, IEnumerable<DataShareResource>, IAsyncEnumerable<DataShareResource>
    {
        private readonly ClientDiagnostics _dataShareSharesClientDiagnostics;
        private readonly SharesRestOperations _dataShareSharesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataShareCollection"/> class for mocking. </summary>
        protected DataShareCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataShareCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareSharesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", DataShareResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataShareResource.ResourceType, out string dataShareSharesApiVersion);
            _dataShareSharesRestClient = new SharesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareSharesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataShareAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataShareAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="shareName"> The name of the share. </param>
        /// <param name="data"> The share payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataShareResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string shareName, DataShareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataShareSharesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<DataShareResource>(Response.FromValue(new DataShareResource(Client, response), response.GetRawResponse()));
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
        /// Create a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="shareName"> The name of the share. </param>
        /// <param name="data"> The share payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataShareResource> CreateOrUpdate(WaitUntil waitUntil, string shareName, DataShareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataShareSharesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareName, data, cancellationToken);
                var operation = new DataShareArmOperation<DataShareResource>(Response.FromValue(new DataShareResource(Client, response), response.GetRawResponse()));
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
        /// Get a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="shareName"> The name of the share to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual async Task<Response<DataShareResource>> GetAsync(string shareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataShareSharesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="shareName"> The name of the share to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual Response<DataShareResource> Get(string shareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareCollection.Get");
            scope.Start();
            try
            {
                var response = _dataShareSharesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shares in an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation Token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataShareResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataShareResource> GetAllAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSharesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSharesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataShareResource(Client, DataShareData.DeserializeDataShareData(e)), _dataShareSharesClientDiagnostics, Pipeline, "DataShareCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List shares in an account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation Token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataShareResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataShareResource> GetAll(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSharesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSharesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataShareResource(Client, DataShareData.DeserializeDataShareData(e)), _dataShareSharesClientDiagnostics, Pipeline, "DataShareCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="shareName"> The name of the share to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string shareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataShareSharesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="shareName"> The name of the share to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual Response<bool> Exists(string shareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataShareSharesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, shareName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataShareResource> IEnumerable<DataShareResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataShareResource> IAsyncEnumerable<DataShareResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}