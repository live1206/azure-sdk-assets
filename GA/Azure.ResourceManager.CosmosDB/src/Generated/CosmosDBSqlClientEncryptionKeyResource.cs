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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a CosmosDBSqlClientEncryptionKey along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CosmosDBSqlClientEncryptionKeyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCosmosDBSqlClientEncryptionKeyResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBSqlDatabaseResource" /> using the GetCosmosDBSqlClientEncryptionKey method.
    /// </summary>
    public partial class CosmosDBSqlClientEncryptionKeyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBSqlClientEncryptionKeyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string databaseName, string clientEncryptionKeyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient;
        private readonly CosmosDBSqlClientEncryptionKeyData _data;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlClientEncryptionKeyResource"/> class for mocking. </summary>
        protected CosmosDBSqlClientEncryptionKeyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CosmosDBSqlClientEncryptionKeyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBSqlClientEncryptionKeyResource(ArmClient client, CosmosDBSqlClientEncryptionKeyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlClientEncryptionKeyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBSqlClientEncryptionKeyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBSqlClientEncryptionKeySqlResourcesApiVersion);
            _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlClientEncryptionKeySqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/sqlDatabases/clientEncryptionKeys";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBSqlClientEncryptionKeyData Data
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
        /// Gets the ClientEncryptionKey under an existing Azure Cosmos DB SQL database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBSqlClientEncryptionKeyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlClientEncryptionKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ClientEncryptionKey under an existing Azure Cosmos DB SQL database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBSqlClientEncryptionKeyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlClientEncryptionKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a ClientEncryptionKey. This API is meant to be invoked via tools such as the Azure Powershell (instead of directly).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateClientEncryptionKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters to provide for the client encryption key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlClientEncryptionKeyResource>> UpdateAsync(WaitUntil waitUntil, CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyResource.Update");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateUpdateClientEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlClientEncryptionKeyResource>(new CosmosDBSqlClientEncryptionKeyOperationSource(Client), _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateCreateUpdateClientEncryptionKeyRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a ClientEncryptionKey. This API is meant to be invoked via tools such as the Azure Powershell (instead of directly).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateClientEncryptionKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters to provide for the client encryption key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlClientEncryptionKeyResource> Update(WaitUntil waitUntil, CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyResource.Update");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateUpdateClientEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlClientEncryptionKeyResource>(new CosmosDBSqlClientEncryptionKeyOperationSource(Client), _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateCreateUpdateClientEncryptionKeyRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
