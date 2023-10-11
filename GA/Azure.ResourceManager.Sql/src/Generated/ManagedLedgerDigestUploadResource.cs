// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedLedgerDigestUpload along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedLedgerDigestUploadResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedLedgerDigestUploadResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseResource" /> using the GetManagedLedgerDigestUpload method.
    /// </summary>
    public partial class ManagedLedgerDigestUploadResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedLedgerDigestUploadResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, ManagedLedgerDigestUploadsName ledgerDigestUploads)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedLedgerDigestUploadClientDiagnostics;
        private readonly ManagedLedgerDigestUploadsRestOperations _managedLedgerDigestUploadRestClient;
        private readonly ManagedLedgerDigestUploadData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedLedgerDigestUploadResource"/> class for mocking. </summary>
        protected ManagedLedgerDigestUploadResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedLedgerDigestUploadResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedLedgerDigestUploadResource(ArmClient client, ManagedLedgerDigestUploadData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedLedgerDigestUploadResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedLedgerDigestUploadResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedLedgerDigestUploadClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedLedgerDigestUploadApiVersion);
            _managedLedgerDigestUploadRestClient = new ManagedLedgerDigestUploadsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedLedgerDigestUploadApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/ledgerDigestUploads";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedLedgerDigestUploadData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedLedgerDigestUploadResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadResource.Get");
            scope.Start();
            try
            {
                var response = await _managedLedgerDigestUploadRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedLedgerDigestUploadResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadResource.Get");
            scope.Start();
            try
            {
                var response = _managedLedgerDigestUploadRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// <param name="data"> The Ledger Digest Storage Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedLedgerDigestUploadResource>> UpdateAsync(WaitUntil waitUntil, ManagedLedgerDigestUploadData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadResource.Update");
            scope.Start();
            try
            {
                var response = await _managedLedgerDigestUploadRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedLedgerDigestUploadResource>(new ManagedLedgerDigestUploadOperationSource(Client), _managedLedgerDigestUploadClientDiagnostics, Pipeline, _managedLedgerDigestUploadRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// <param name="data"> The Ledger Digest Storage Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedLedgerDigestUploadResource> Update(WaitUntil waitUntil, ManagedLedgerDigestUploadData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadResource.Update");
            scope.Start();
            try
            {
                var response = _managedLedgerDigestUploadRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedLedgerDigestUploadResource>(new ManagedLedgerDigestUploadOperationSource(Client), _managedLedgerDigestUploadClientDiagnostics, Pipeline, _managedLedgerDigestUploadRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_Disable</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ManagedLedgerDigestUploadResource>> DisableAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadResource.Disable");
            scope.Start();
            try
            {
                var response = await _managedLedgerDigestUploadRestClient.DisableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedLedgerDigestUploadResource>(new ManagedLedgerDigestUploadOperationSource(Client), _managedLedgerDigestUploadClientDiagnostics, Pipeline, _managedLedgerDigestUploadRestClient.CreateDisableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}/disable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedLedgerDigestUploads_Disable</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ManagedLedgerDigestUploadResource> Disable(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedLedgerDigestUploadClientDiagnostics.CreateScope("ManagedLedgerDigestUploadResource.Disable");
            scope.Start();
            try
            {
                var response = _managedLedgerDigestUploadRestClient.Disable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation<ManagedLedgerDigestUploadResource>(new ManagedLedgerDigestUploadOperationSource(Client), _managedLedgerDigestUploadClientDiagnostics, Pipeline, _managedLedgerDigestUploadRestClient.CreateDisableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}