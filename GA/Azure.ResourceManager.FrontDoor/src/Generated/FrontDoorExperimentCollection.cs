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

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorExperimentResource" /> and their operations.
    /// Each <see cref="FrontDoorExperimentResource" /> in the collection will belong to the same instance of <see cref="FrontDoorNetworkExperimentProfileResource" />.
    /// To get a <see cref="FrontDoorExperimentCollection" /> instance call the GetFrontDoorExperiments method from an instance of <see cref="FrontDoorNetworkExperimentProfileResource" />.
    /// </summary>
    public partial class FrontDoorExperimentCollection : ArmCollection, IEnumerable<FrontDoorExperimentResource>, IAsyncEnumerable<FrontDoorExperimentResource>
    {
        private readonly ClientDiagnostics _frontDoorExperimentExperimentsClientDiagnostics;
        private readonly ExperimentsRestOperations _frontDoorExperimentExperimentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorExperimentCollection"/> class for mocking. </summary>
        protected FrontDoorExperimentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorExperimentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorExperimentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorExperimentExperimentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FrontDoor", FrontDoorExperimentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorExperimentResource.ResourceType, out string frontDoorExperimentExperimentsApiVersion);
            _frontDoorExperimentExperimentsRestClient = new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorExperimentExperimentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FrontDoorNetworkExperimentProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FrontDoorNetworkExperimentProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Experiment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="data"> The Experiment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorExperimentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string experimentName, FrontDoorExperimentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorExperimentExperimentsClientDiagnostics.CreateScope("FrontDoorExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorExperimentExperimentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FrontDoorArmOperation<FrontDoorExperimentResource>(new FrontDoorExperimentOperationSource(Client), _frontDoorExperimentExperimentsClientDiagnostics, Pipeline, _frontDoorExperimentExperimentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Experiment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="data"> The Experiment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorExperimentResource> CreateOrUpdate(WaitUntil waitUntil, string experimentName, FrontDoorExperimentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorExperimentExperimentsClientDiagnostics.CreateScope("FrontDoorExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorExperimentExperimentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data, cancellationToken);
                var operation = new FrontDoorArmOperation<FrontDoorExperimentResource>(new FrontDoorExperimentOperationSource(Client), _frontDoorExperimentExperimentsClientDiagnostics, Pipeline, _frontDoorExperimentExperimentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an Experiment by ExperimentName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorExperimentResource>> GetAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _frontDoorExperimentExperimentsClientDiagnostics.CreateScope("FrontDoorExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorExperimentExperimentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorExperimentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Experiment by ExperimentName
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<FrontDoorExperimentResource> Get(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _frontDoorExperimentExperimentsClientDiagnostics.CreateScope("FrontDoorExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorExperimentExperimentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorExperimentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Experiments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListByProfile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorExperimentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorExperimentExperimentsRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorExperimentExperimentsRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorExperimentResource(Client, FrontDoorExperimentData.DeserializeFrontDoorExperimentData(e)), _frontDoorExperimentExperimentsClientDiagnostics, Pipeline, "FrontDoorExperimentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Experiments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListByProfile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorExperimentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorExperimentExperimentsRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorExperimentExperimentsRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorExperimentResource(Client, FrontDoorExperimentData.DeserializeFrontDoorExperimentData(e)), _frontDoorExperimentExperimentsClientDiagnostics, Pipeline, "FrontDoorExperimentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _frontDoorExperimentExperimentsClientDiagnostics.CreateScope("FrontDoorExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorExperimentExperimentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}/Experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="experimentName"> The Experiment identifier associated with the Experiment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<bool> Exists(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _frontDoorExperimentExperimentsClientDiagnostics.CreateScope("FrontDoorExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorExperimentExperimentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, experimentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorExperimentResource> IEnumerable<FrontDoorExperimentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorExperimentResource> IAsyncEnumerable<FrontDoorExperimentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}