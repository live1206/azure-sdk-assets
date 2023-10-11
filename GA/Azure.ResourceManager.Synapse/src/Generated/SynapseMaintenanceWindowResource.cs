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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseMaintenanceWindow along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseMaintenanceWindowResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseMaintenanceWindowResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseSqlPoolResource" /> using the GetSynapseMaintenanceWindow method.
    /// </summary>
    public partial class SynapseMaintenanceWindowResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseMaintenanceWindowResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenancewindows/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseMaintenanceWindowSqlPoolMaintenanceWindowsClientDiagnostics;
        private readonly SqlPoolMaintenanceWindowsRestOperations _synapseMaintenanceWindowSqlPoolMaintenanceWindowsRestClient;
        private readonly SynapseMaintenanceWindowData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseMaintenanceWindowResource"/> class for mocking. </summary>
        protected SynapseMaintenanceWindowResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseMaintenanceWindowResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseMaintenanceWindowResource(ArmClient client, SynapseMaintenanceWindowData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseMaintenanceWindowResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseMaintenanceWindowResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseMaintenanceWindowSqlPoolMaintenanceWindowsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseMaintenanceWindowSqlPoolMaintenanceWindowsApiVersion);
            _synapseMaintenanceWindowSqlPoolMaintenanceWindowsRestClient = new SqlPoolMaintenanceWindowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseMaintenanceWindowSqlPoolMaintenanceWindowsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/maintenancewindows";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseMaintenanceWindowData Data
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
        /// Get a SQL pool's Maintenance Windows.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenancewindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolMaintenanceWindows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> is null. </exception>
        public virtual async Task<Response<SynapseMaintenanceWindowResource>> GetAsync(string maintenanceWindowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));

            using var scope = _synapseMaintenanceWindowSqlPoolMaintenanceWindowsClientDiagnostics.CreateScope("SynapseMaintenanceWindowResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseMaintenanceWindowSqlPoolMaintenanceWindowsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseMaintenanceWindowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SQL pool's Maintenance Windows.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenancewindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolMaintenanceWindows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> is null. </exception>
        public virtual Response<SynapseMaintenanceWindowResource> Get(string maintenanceWindowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));

            using var scope = _synapseMaintenanceWindowSqlPoolMaintenanceWindowsClientDiagnostics.CreateScope("SynapseMaintenanceWindowResource.Get");
            scope.Start();
            try
            {
                var response = _synapseMaintenanceWindowSqlPoolMaintenanceWindowsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseMaintenanceWindowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a Sql pool's maintenance windows settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenancewindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolMaintenanceWindows_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="data"> The required parameters for creating or updating Maintenance Windows settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string maintenanceWindowName, SynapseMaintenanceWindowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseMaintenanceWindowSqlPoolMaintenanceWindowsClientDiagnostics.CreateScope("SynapseMaintenanceWindowResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseMaintenanceWindowSqlPoolMaintenanceWindowsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(response);
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
        /// Creates or updates a Sql pool's maintenance windows settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenancewindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolMaintenanceWindows_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="data"> The required parameters for creating or updating Maintenance Windows settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string maintenanceWindowName, SynapseMaintenanceWindowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseMaintenanceWindowSqlPoolMaintenanceWindowsClientDiagnostics.CreateScope("SynapseMaintenanceWindowResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseMaintenanceWindowSqlPoolMaintenanceWindowsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, data, cancellationToken);
                var operation = new SynapseArmOperation(response);
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