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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningBatchDeploymentResource" /> and their operations.
    /// Each <see cref="MachineLearningBatchDeploymentResource" /> in the collection will belong to the same instance of <see cref="MachineLearningBatchEndpointResource" />.
    /// To get a <see cref="MachineLearningBatchDeploymentCollection" /> instance call the GetMachineLearningBatchDeployments method from an instance of <see cref="MachineLearningBatchEndpointResource" />.
    /// </summary>
    public partial class MachineLearningBatchDeploymentCollection : ArmCollection, IEnumerable<MachineLearningBatchDeploymentResource>, IAsyncEnumerable<MachineLearningBatchDeploymentResource>
    {
        private readonly ClientDiagnostics _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics;
        private readonly BatchDeploymentsRestOperations _machineLearningBatchDeploymentBatchDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningBatchDeploymentCollection"/> class for mocking. </summary>
        protected MachineLearningBatchDeploymentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningBatchDeploymentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningBatchDeploymentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningBatchDeploymentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningBatchDeploymentResource.ResourceType, out string machineLearningBatchDeploymentBatchDeploymentsApiVersion);
            _machineLearningBatchDeploymentBatchDeploymentsRestClient = new BatchDeploymentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningBatchDeploymentBatchDeploymentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningBatchEndpointResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningBatchEndpointResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates/updates a batch inference deployment (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="data"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningBatchDeploymentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deploymentName, MachineLearningBatchDeploymentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics.CreateScope("MachineLearningBatchDeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningBatchDeploymentResource>(new MachineLearningBatchDeploymentOperationSource(Client), _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics, Pipeline, _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates/updates a batch inference deployment (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="data"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningBatchDeploymentResource> CreateOrUpdate(WaitUntil waitUntil, string deploymentName, MachineLearningBatchDeploymentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics.CreateScope("MachineLearningBatchDeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningBatchDeploymentResource>(new MachineLearningBatchDeploymentOperationSource(Client), _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics, Pipeline, _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a batch inference deployment by id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningBatchDeploymentResource>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics.CreateScope("MachineLearningBatchDeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningBatchDeploymentBatchDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningBatchDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a batch inference deployment by id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<MachineLearningBatchDeploymentResource> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics.CreateScope("MachineLearningBatchDeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningBatchDeploymentBatchDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningBatchDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Batch inference deployments in the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningBatchDeploymentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningBatchDeploymentResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningBatchDeploymentResource(Client, MachineLearningBatchDeploymentData.DeserializeMachineLearningBatchDeploymentData(e)), _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics, Pipeline, "MachineLearningBatchDeploymentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists Batch inference deployments in the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningBatchDeploymentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningBatchDeploymentResource> GetAll(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningBatchDeploymentBatchDeploymentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningBatchDeploymentResource(Client, MachineLearningBatchDeploymentData.DeserializeMachineLearningBatchDeploymentData(e)), _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics, Pipeline, "MachineLearningBatchDeploymentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics.CreateScope("MachineLearningBatchDeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningBatchDeploymentBatchDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchDeployments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _machineLearningBatchDeploymentBatchDeploymentsClientDiagnostics.CreateScope("MachineLearningBatchDeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningBatchDeploymentBatchDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningBatchDeploymentResource> IEnumerable<MachineLearningBatchDeploymentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningBatchDeploymentResource> IAsyncEnumerable<MachineLearningBatchDeploymentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}