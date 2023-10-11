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

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingJobOutputResource" /> and their operations.
    /// Each <see cref="StreamingJobOutputResource" /> in the collection will belong to the same instance of <see cref="StreamingJobResource" />.
    /// To get a <see cref="StreamingJobOutputCollection" /> instance call the GetStreamingJobOutputs method from an instance of <see cref="StreamingJobResource" />.
    /// </summary>
    public partial class StreamingJobOutputCollection : ArmCollection, IEnumerable<StreamingJobOutputResource>, IAsyncEnumerable<StreamingJobOutputResource>
    {
        private readonly ClientDiagnostics _streamingJobOutputOutputsClientDiagnostics;
        private readonly OutputsRestOperations _streamingJobOutputOutputsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingJobOutputCollection"/> class for mocking. </summary>
        protected StreamingJobOutputCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobOutputCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingJobOutputCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobOutputOutputsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", StreamingJobOutputResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingJobOutputResource.ResourceType, out string streamingJobOutputOutputsApiVersion);
            _streamingJobOutputOutputsRestClient = new OutputsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobOutputOutputsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StreamingJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StreamingJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an output or replaces an already existing output under an existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs/{outputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_CreateOrReplace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outputName"> The name of the output. </param>
        /// <param name="data"> The definition of the output that will be used to create a new output or replace the existing one under the streaming job. </param>
        /// <param name="ifMatch"> The ETag of the output. Omit this value to always overwrite the current output. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new output to be created, but to prevent updating an existing output. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outputName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingJobOutputResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string outputName, StreamingJobOutputData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outputName, nameof(outputName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobOutputOutputsClientDiagnostics.CreateScope("StreamingJobOutputCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingJobOutputOutputsRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outputName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamingJobOutputResource>(Response.FromValue(new StreamingJobOutputResource(Client, response), response.GetRawResponse()));
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
        /// Creates an output or replaces an already existing output under an existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs/{outputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_CreateOrReplace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="outputName"> The name of the output. </param>
        /// <param name="data"> The definition of the output that will be used to create a new output or replace the existing one under the streaming job. </param>
        /// <param name="ifMatch"> The ETag of the output. Omit this value to always overwrite the current output. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new output to be created, but to prevent updating an existing output. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outputName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamingJobOutputResource> CreateOrUpdate(WaitUntil waitUntil, string outputName, StreamingJobOutputData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outputName, nameof(outputName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobOutputOutputsClientDiagnostics.CreateScope("StreamingJobOutputCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingJobOutputOutputsRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outputName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamingJobOutputResource>(Response.FromValue(new StreamingJobOutputResource(Client, response), response.GetRawResponse()));
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
        /// Gets details about the specified output.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs/{outputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outputName"> The name of the output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outputName"/> is null. </exception>
        public virtual async Task<Response<StreamingJobOutputResource>> GetAsync(string outputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outputName, nameof(outputName));

            using var scope = _streamingJobOutputOutputsClientDiagnostics.CreateScope("StreamingJobOutputCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobOutputOutputsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outputName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobOutputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified output.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs/{outputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outputName"> The name of the output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outputName"/> is null. </exception>
        public virtual Response<StreamingJobOutputResource> Get(string outputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outputName, nameof(outputName));

            using var scope = _streamingJobOutputOutputsClientDiagnostics.CreateScope("StreamingJobOutputCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingJobOutputOutputsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outputName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobOutputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the outputs under the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_ListByStreamingJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="select"> The $select OData query parameter. This is a comma-separated list of structural properties to include in the response, or "*" to include all properties. By default, all properties are returned except diagnostics. Currently only accepts '*' as a valid value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingJobOutputResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingJobOutputResource> GetAllAsync(string select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobOutputOutputsRestClient.CreateListByStreamingJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobOutputOutputsRestClient.CreateListByStreamingJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamingJobOutputResource(Client, StreamingJobOutputData.DeserializeStreamingJobOutputData(e)), _streamingJobOutputOutputsClientDiagnostics, Pipeline, "StreamingJobOutputCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the outputs under the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_ListByStreamingJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="select"> The $select OData query parameter. This is a comma-separated list of structural properties to include in the response, or "*" to include all properties. By default, all properties are returned except diagnostics. Currently only accepts '*' as a valid value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingJobOutputResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingJobOutputResource> GetAll(string select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobOutputOutputsRestClient.CreateListByStreamingJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobOutputOutputsRestClient.CreateListByStreamingJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamingJobOutputResource(Client, StreamingJobOutputData.DeserializeStreamingJobOutputData(e)), _streamingJobOutputOutputsClientDiagnostics, Pipeline, "StreamingJobOutputCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs/{outputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outputName"> The name of the output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outputName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string outputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outputName, nameof(outputName));

            using var scope = _streamingJobOutputOutputsClientDiagnostics.CreateScope("StreamingJobOutputCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingJobOutputOutputsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outputName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/outputs/{outputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Outputs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outputName"> The name of the output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outputName"/> is null. </exception>
        public virtual Response<bool> Exists(string outputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outputName, nameof(outputName));

            using var scope = _streamingJobOutputOutputsClientDiagnostics.CreateScope("StreamingJobOutputCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingJobOutputOutputsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outputName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingJobOutputResource> IEnumerable<StreamingJobOutputResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingJobOutputResource> IAsyncEnumerable<StreamingJobOutputResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}