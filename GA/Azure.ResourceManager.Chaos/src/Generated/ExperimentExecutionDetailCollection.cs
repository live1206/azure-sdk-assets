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

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ExperimentExecutionDetailResource" /> and their operations.
    /// Each <see cref="ExperimentExecutionDetailResource" /> in the collection will belong to the same instance of <see cref="ExperimentResource" />.
    /// To get an <see cref="ExperimentExecutionDetailCollection" /> instance call the GetExperimentExecutionDetails method from an instance of <see cref="ExperimentResource" />.
    /// </summary>
    public partial class ExperimentExecutionDetailCollection : ArmCollection, IEnumerable<ExperimentExecutionDetailResource>, IAsyncEnumerable<ExperimentExecutionDetailResource>
    {
        private readonly ClientDiagnostics _experimentExecutionDetailExperimentsClientDiagnostics;
        private readonly ExperimentsRestOperations _experimentExecutionDetailExperimentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExperimentExecutionDetailCollection"/> class for mocking. </summary>
        protected ExperimentExecutionDetailCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentExecutionDetailCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExperimentExecutionDetailCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _experimentExecutionDetailExperimentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ExperimentExecutionDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExperimentExecutionDetailResource.ResourceType, out string experimentExecutionDetailExperimentsApiVersion);
            _experimentExecutionDetailExperimentsRestClient = new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, experimentExecutionDetailExperimentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExperimentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExperimentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an execution detail of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetExecutionDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionDetailsId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionDetailsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionDetailsId"/> is null. </exception>
        public virtual async Task<Response<ExperimentExecutionDetailResource>> GetAsync(string executionDetailsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionDetailsId, nameof(executionDetailsId));

            using var scope = _experimentExecutionDetailExperimentsClientDiagnostics.CreateScope("ExperimentExecutionDetailCollection.Get");
            scope.Start();
            try
            {
                var response = await _experimentExecutionDetailExperimentsRestClient.GetExecutionDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionDetailsId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentExecutionDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an execution detail of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetExecutionDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionDetailsId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionDetailsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionDetailsId"/> is null. </exception>
        public virtual Response<ExperimentExecutionDetailResource> Get(string executionDetailsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionDetailsId, nameof(executionDetailsId));

            using var scope = _experimentExecutionDetailExperimentsClientDiagnostics.CreateScope("ExperimentExecutionDetailCollection.Get");
            scope.Start();
            try
            {
                var response = _experimentExecutionDetailExperimentsRestClient.GetExecutionDetails(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionDetailsId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentExecutionDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of execution details of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListExecutionDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExperimentExecutionDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExperimentExecutionDetailResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _experimentExecutionDetailExperimentsRestClient.CreateListExecutionDetailsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _experimentExecutionDetailExperimentsRestClient.CreateListExecutionDetailsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExperimentExecutionDetailResource(Client, ExperimentExecutionDetailData.DeserializeExperimentExecutionDetailData(e)), _experimentExecutionDetailExperimentsClientDiagnostics, Pipeline, "ExperimentExecutionDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of execution details of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListExecutionDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExperimentExecutionDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExperimentExecutionDetailResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _experimentExecutionDetailExperimentsRestClient.CreateListExecutionDetailsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _experimentExecutionDetailExperimentsRestClient.CreateListExecutionDetailsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExperimentExecutionDetailResource(Client, ExperimentExecutionDetailData.DeserializeExperimentExecutionDetailData(e)), _experimentExecutionDetailExperimentsClientDiagnostics, Pipeline, "ExperimentExecutionDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetExecutionDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionDetailsId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionDetailsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionDetailsId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string executionDetailsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionDetailsId, nameof(executionDetailsId));

            using var scope = _experimentExecutionDetailExperimentsClientDiagnostics.CreateScope("ExperimentExecutionDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = await _experimentExecutionDetailExperimentsRestClient.GetExecutionDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionDetailsId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetExecutionDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionDetailsId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionDetailsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionDetailsId"/> is null. </exception>
        public virtual Response<bool> Exists(string executionDetailsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionDetailsId, nameof(executionDetailsId));

            using var scope = _experimentExecutionDetailExperimentsClientDiagnostics.CreateScope("ExperimentExecutionDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = _experimentExecutionDetailExperimentsRestClient.GetExecutionDetails(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionDetailsId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExperimentExecutionDetailResource> IEnumerable<ExperimentExecutionDetailResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExperimentExecutionDetailResource> IAsyncEnumerable<ExperimentExecutionDetailResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}