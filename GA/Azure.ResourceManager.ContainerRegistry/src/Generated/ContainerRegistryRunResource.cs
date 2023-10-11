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
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A Class representing a ContainerRegistryRun along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ContainerRegistryRunResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetContainerRegistryRunResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerRegistryResource" /> using the GetContainerRegistryRun method.
    /// </summary>
    public partial class ContainerRegistryRunResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerRegistryRunResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string runId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerRegistryRunRunsClientDiagnostics;
        private readonly RunsRestOperations _containerRegistryRunRunsRestClient;
        private readonly ContainerRegistryRunData _data;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryRunResource"/> class for mocking. </summary>
        protected ContainerRegistryRunResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ContainerRegistryRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerRegistryRunResource(ArmClient client, ContainerRegistryRunData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerRegistryRunResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryRunRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerRegistryRunRunsApiVersion);
            _containerRegistryRunRunsRestClient = new RunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryRunRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerRegistry/registries/runs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerRegistryRunData Data
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
        /// Gets the detailed information for a given run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerRegistryRunResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information for a given run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerRegistryRunResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Patch the run properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The run update properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryRunResource>> UpdateAsync(WaitUntil waitUntil, ContainerRegistryRunPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.Update");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryRunResource>(new ContainerRegistryRunOperationSource(Client), _containerRegistryRunRunsClientDiagnostics, Pipeline, _containerRegistryRunRunsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Patch the run properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The run update properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryRunResource> Update(WaitUntil waitUntil, ContainerRegistryRunPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.Update");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryRunResource>(new ContainerRegistryRunOperationSource(Client), _containerRegistryRunRunsClientDiagnostics, Pipeline, _containerRegistryRunRunsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a link to download the run logs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}/listLogSasUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_GetLogSasUrl</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerRegistryRunGetLogResult>> GetLogSasUrlAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.GetLogSasUrl");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.GetLogSasUrlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a link to download the run logs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}/listLogSasUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_GetLogSasUrl</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerRegistryRunGetLogResult> GetLogSasUrl(CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.GetLogSasUrl");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.GetLogSasUrl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancel an existing run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> CancelAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.Cancel");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation(_containerRegistryRunRunsClientDiagnostics, Pipeline, _containerRegistryRunRunsRestClient.CreateCancelRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Cancel an existing run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Cancel(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunResource.Cancel");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ContainerRegistryArmOperation(_containerRegistryRunRunsClientDiagnostics, Pipeline, _containerRegistryRunRunsRestClient.CreateCancelRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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