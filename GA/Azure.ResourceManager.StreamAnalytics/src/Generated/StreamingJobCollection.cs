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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingJobResource" /> and their operations.
    /// Each <see cref="StreamingJobResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="StreamingJobCollection" /> instance call the GetStreamingJobs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class StreamingJobCollection : ArmCollection, IEnumerable<StreamingJobResource>, IAsyncEnumerable<StreamingJobResource>
    {
        private readonly ClientDiagnostics _streamingJobClientDiagnostics;
        private readonly StreamingJobsRestOperations _streamingJobRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingJobCollection"/> class for mocking. </summary>
        protected StreamingJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", StreamingJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingJobResource.ResourceType, out string streamingJobApiVersion);
            _streamingJobRestClient = new StreamingJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a streaming job or replaces an already existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_CreateOrReplace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="data"> The definition of the streaming job that will be used to create a new streaming job or replace the existing one. </param>
        /// <param name="ifMatch"> The ETag of the streaming job. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new streaming job to be created, but to prevent updating an existing record set. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingJobResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobName, StreamingJobData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobClientDiagnostics.CreateScope("StreamingJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingJobRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamingJobResource>(new StreamingJobOperationSource(Client), _streamingJobClientDiagnostics, Pipeline, _streamingJobRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, jobName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a streaming job or replaces an already existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_CreateOrReplace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="data"> The definition of the streaming job that will be used to create a new streaming job or replace the existing one. </param>
        /// <param name="ifMatch"> The ETag of the streaming job. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new streaming job to be created, but to prevent updating an existing record set. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamingJobResource> CreateOrUpdate(WaitUntil waitUntil, string jobName, StreamingJobData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobClientDiagnostics.CreateScope("StreamingJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingJobRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, jobName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamingJobResource>(new StreamingJobOperationSource(Client), _streamingJobClientDiagnostics, Pipeline, _streamingJobRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, jobName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets details about the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<StreamingJobResource>> GetAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _streamingJobClientDiagnostics.CreateScope("StreamingJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<StreamingJobResource> Get(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _streamingJobClientDiagnostics.CreateScope("StreamingJobCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingJobRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the streaming jobs in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingJobResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamingJobResource(Client, StreamingJobData.DeserializeStreamingJobData(e)), _streamingJobClientDiagnostics, Pipeline, "StreamingJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the streaming jobs in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingJobResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamingJobResource(Client, StreamingJobData.DeserializeStreamingJobData(e)), _streamingJobClientDiagnostics, Pipeline, "StreamingJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _streamingJobClientDiagnostics.CreateScope("StreamingJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingJobRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _streamingJobClientDiagnostics.CreateScope("StreamingJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingJobRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jobName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingJobResource> IEnumerable<StreamingJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingJobResource> IAsyncEnumerable<StreamingJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}