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

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing a collection of <see cref="TableResource" /> and their operations.
    /// Each <see cref="TableResource" /> in the collection will belong to the same instance of <see cref="TableServiceResource" />.
    /// To get a <see cref="TableCollection" /> instance call the GetTables method from an instance of <see cref="TableServiceResource" />.
    /// </summary>
    public partial class TableCollection : ArmCollection, IEnumerable<TableResource>, IAsyncEnumerable<TableResource>
    {
        private readonly ClientDiagnostics _tableClientDiagnostics;
        private readonly TableRestOperations _tableRestClient;

        /// <summary> Initializes a new instance of the <see cref="TableCollection"/> class for mocking. </summary>
        protected TableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", TableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TableResource.ResourceType, out string tableApiVersion);
            _tableRestClient = new TableRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TableServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TableServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new table with the specified table name, under the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="data"> The parameters to provide to create a table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TableResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tableName, TableData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tableClientDiagnostics.CreateScope("TableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tableRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tableName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<TableResource>(Response.FromValue(new TableResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new table with the specified table name, under the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="data"> The parameters to provide to create a table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TableResource> CreateOrUpdate(WaitUntil waitUntil, string tableName, TableData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tableClientDiagnostics.CreateScope("TableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tableRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tableName, data, cancellationToken);
                var operation = new StorageArmOperation<TableResource>(Response.FromValue(new TableResource(Client, response), response.GetRawResponse()));
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
        /// Gets the table with the specified table name, under the specified account if it exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<TableResource>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _tableClientDiagnostics.CreateScope("TableCollection.Get");
            scope.Start();
            try
            {
                var response = await _tableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the table with the specified table name, under the specified account if it exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<TableResource> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _tableClientDiagnostics.CreateScope("TableCollection.Get");
            scope.Start();
            try
            {
                var response = _tableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all the tables under the specified storage account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TableResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tableRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tableRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TableResource(Client, TableData.DeserializeTableData(e)), _tableClientDiagnostics, Pipeline, "TableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all the tables under the specified storage account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TableResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tableRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tableRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TableResource(Client, TableData.DeserializeTableData(e)), _tableClientDiagnostics, Pipeline, "TableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _tableClientDiagnostics.CreateScope("TableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Table_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _tableClientDiagnostics.CreateScope("TableCollection.Exists");
            scope.Start();
            try
            {
                var response = _tableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TableResource> IEnumerable<TableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TableResource> IAsyncEnumerable<TableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}