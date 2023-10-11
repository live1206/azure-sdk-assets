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
    /// A Class representing a SynapseClusterPrincipalAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseClusterPrincipalAssignmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseClusterPrincipalAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseKustoPoolResource" /> using the GetSynapseClusterPrincipalAssignment method.
    /// </summary>
    public partial class SynapseClusterPrincipalAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseClusterPrincipalAssignmentResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string principalAssignmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics;
        private readonly KustoPoolPrincipalAssignmentsRestOperations _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient;
        private readonly SynapseClusterPrincipalAssignmentData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseClusterPrincipalAssignmentResource"/> class for mocking. </summary>
        protected SynapseClusterPrincipalAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseClusterPrincipalAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseClusterPrincipalAssignmentResource(ArmClient client, SynapseClusterPrincipalAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseClusterPrincipalAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseClusterPrincipalAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsApiVersion);
            _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient = new KustoPoolPrincipalAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/kustoPools/principalAssignments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseClusterPrincipalAssignmentData Data
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
        /// Gets a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseClusterPrincipalAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseClusterPrincipalAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SynapseArmOperation(_synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Create a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Kusto pool principalAssignment's parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseClusterPrincipalAssignmentResource>> UpdateAsync(WaitUntil waitUntil, SynapseClusterPrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseClusterPrincipalAssignmentResource>(new SynapseClusterPrincipalAssignmentOperationSource(Client), _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Kusto pool principalAssignment's parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseClusterPrincipalAssignmentResource> Update(WaitUntil waitUntil, SynapseClusterPrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseClusterPrincipalAssignmentResource>(new SynapseClusterPrincipalAssignmentOperationSource(Client), _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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