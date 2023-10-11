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

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A Class representing a DeletedDataProtectionBackupInstance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DeletedDataProtectionBackupInstanceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDeletedDataProtectionBackupInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataProtectionBackupVaultResource" /> using the GetDeletedDataProtectionBackupInstance method.
    /// </summary>
    public partial class DeletedDataProtectionBackupInstanceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeletedDataProtectionBackupInstanceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics;
        private readonly DeletedBackupInstancesRestOperations _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient;
        private readonly DeletedDataProtectionBackupInstanceData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedDataProtectionBackupInstanceResource"/> class for mocking. </summary>
        protected DeletedDataProtectionBackupInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeletedDataProtectionBackupInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeletedDataProtectionBackupInstanceResource(ArmClient client, DeletedDataProtectionBackupInstanceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedDataProtectionBackupInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedDataProtectionBackupInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deletedDataProtectionBackupInstanceDeletedBackupInstancesApiVersion);
            _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient = new DeletedBackupInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedDataProtectionBackupInstanceDeletedBackupInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataProtection/backupVaults/deletedBackupInstances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedDataProtectionBackupInstanceData Data
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
        /// Gets a deleted backup instance with name in a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedDataProtectionBackupInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceResource.Get");
            scope.Start();
            try
            {
                var response = await _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedDataProtectionBackupInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted backup instance with name in a backup vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedDataProtectionBackupInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceResource.Get");
            scope.Start();
            try
            {
                var response = _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedDataProtectionBackupInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}/undelete</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Undelete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> UndeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceResource.Undelete");
            scope.Start();
            try
            {
                var response = await _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.UndeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataProtectionBackupArmOperation(_deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics, Pipeline, _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.CreateUndeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/deletedBackupInstances/{backupInstanceName}/undelete</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedBackupInstances_Undelete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Undelete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics.CreateScope("DeletedDataProtectionBackupInstanceResource.Undelete");
            scope.Start();
            try
            {
                var response = _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.Undelete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataProtectionBackupArmOperation(_deletedDataProtectionBackupInstanceDeletedBackupInstancesClientDiagnostics, Pipeline, _deletedDataProtectionBackupInstanceDeletedBackupInstancesRestClient.CreateUndeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
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