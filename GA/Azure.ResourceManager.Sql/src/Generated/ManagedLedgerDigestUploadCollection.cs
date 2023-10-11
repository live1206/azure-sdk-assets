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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedLedgerDigestUploadResource" /> and their operations.
    /// Each <see cref="ManagedLedgerDigestUploadResource" /> in the collection will belong to the same instance of <see cref="ManagedDatabaseResource" />.
    /// To get a <see cref="ManagedLedgerDigestUploadCollection" /> instance call the GetManagedLedgerDigestUploads method from an instance of <see cref="ManagedDatabaseResource" />.
    /// </summary>
    public partial class ManagedLedgerDigestUploadCollection : ArmCollection, IEnumerable<ManagedLedgerDigestUploadResource>, IAsyncEnumerable<ManagedLedgerDigestUploadResource>
    {
        private readonly ClientDiagnostics _managedLedgerDigestUploadClientDiagnostics;
        private readonly ManagedLedgerDigestUploadsRestOperations _managedLedgerDigestUploadRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedLedgerDigestUploadCollection"/> class for mocking. </summary>
        protected ManagedLedgerDigestUploadCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedLedgerDigestUploadCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedLedgerDigestUploadCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedLedgerDigestUploadClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedLedgerDigestUploadResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedLedgerDigestUploadResource.ResourceType, out string managedLedgerDigestUploadApiVersion);
            _managedLedgerDigestUploadRestClient = new ManagedLedgerDigestUploadsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedLedgerDigestUploadApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ledgerDigestUploads"> The name of the Ledger Digest Upload Configurations. </param>
        /// <param name="data"> The Ledger Digest Storage Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedLedgerDigestUploadResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ManagedLedgerDigestUploadsName ledgerDigestUploads, ManagedLedgerDigestUploadData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedLedgerDigestUploadRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedLedgerDigestUploadResource>(new ManagedLedgerDigestUploadOperationSource(Client), _managedLedgerDigestUploadClientDiagnostics, Pipeline, _managedLedgerDigestUploadRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data).Request, response, OperationFinalStateVia.Location);
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
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ledgerDigestUploads"> The name of the Ledger Digest Upload Configurations. </param>
        /// <param name="data"> The Ledger Digest Storage Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedLedgerDigestUploadResource> CreateOrUpdate(WaitUntil waitUntil, ManagedLedgerDigestUploadsName ledgerDigestUploads, ManagedLedgerDigestUploadData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedLedgerDigestUploadRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedLedgerDigestUploadResource>(new ManagedLedgerDigestUploadOperationSource(Client), _managedLedgerDigestUploadClientDiagnostics, Pipeline, _managedLedgerDigestUploadRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the current ledger digest upload configuration for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The ManagedLedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedLedgerDigestUploadResource>> GetAsync(ManagedLedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedLedgerDigestUploadRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedLedgerDigestUploadResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current ledger digest upload configuration for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The ManagedLedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedLedgerDigestUploadResource> Get(ManagedLedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadCollection.Get");
            scope.Start();
            try
            {
                var response = _managedLedgerDigestUploadRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedLedgerDigestUploadResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedLedgerDigestUploadResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedLedgerDigestUploadResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedLedgerDigestUploadRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedLedgerDigestUploadRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedLedgerDigestUploadResource(Client, ManagedLedgerDigestUploadData.DeserializeManagedLedgerDigestUploadData(e)), _managedLedgerDigestUploadClientDiagnostics, Pipeline, "ManagedLedgerDigestUploadCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedLedgerDigestUploadResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedLedgerDigestUploadResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedLedgerDigestUploadRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedLedgerDigestUploadRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedLedgerDigestUploadResource(Client, ManagedLedgerDigestUploadData.DeserializeManagedLedgerDigestUploadData(e)), _managedLedgerDigestUploadClientDiagnostics, Pipeline, "ManagedLedgerDigestUploadCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The ManagedLedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ManagedLedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedLedgerDigestUploadRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The ManagedLedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedLedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedLedgerDigestUploadRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedLedgerDigestUploadResource> IEnumerable<ManagedLedgerDigestUploadResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedLedgerDigestUploadResource> IAsyncEnumerable<ManagedLedgerDigestUploadResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}