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

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing a collection of <see cref="TimeSeriesDatabaseConnectionResource" /> and their operations.
    /// Each <see cref="TimeSeriesDatabaseConnectionResource" /> in the collection will belong to the same instance of <see cref="DigitalTwinsDescriptionResource" />.
    /// To get a <see cref="TimeSeriesDatabaseConnectionCollection" /> instance call the GetTimeSeriesDatabaseConnections method from an instance of <see cref="DigitalTwinsDescriptionResource" />.
    /// </summary>
    public partial class TimeSeriesDatabaseConnectionCollection : ArmCollection, IEnumerable<TimeSeriesDatabaseConnectionResource>, IAsyncEnumerable<TimeSeriesDatabaseConnectionResource>
    {
        private readonly ClientDiagnostics _timeSeriesDatabaseConnectionClientDiagnostics;
        private readonly TimeSeriesDatabaseConnectionsRestOperations _timeSeriesDatabaseConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TimeSeriesDatabaseConnectionCollection"/> class for mocking. </summary>
        protected TimeSeriesDatabaseConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TimeSeriesDatabaseConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TimeSeriesDatabaseConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _timeSeriesDatabaseConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DigitalTwins", TimeSeriesDatabaseConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TimeSeriesDatabaseConnectionResource.ResourceType, out string timeSeriesDatabaseConnectionApiVersion);
            _timeSeriesDatabaseConnectionRestClient = new TimeSeriesDatabaseConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, timeSeriesDatabaseConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DigitalTwinsDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DigitalTwinsDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a time series database connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections/{timeSeriesDatabaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="data"> The time series database connection description. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesDatabaseConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TimeSeriesDatabaseConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string timeSeriesDatabaseConnectionName, TimeSeriesDatabaseConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _timeSeriesDatabaseConnectionClientDiagnostics.CreateScope("TimeSeriesDatabaseConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _timeSeriesDatabaseConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DigitalTwinsArmOperation<TimeSeriesDatabaseConnectionResource>(new TimeSeriesDatabaseConnectionOperationSource(Client), _timeSeriesDatabaseConnectionClientDiagnostics, Pipeline, _timeSeriesDatabaseConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a time series database connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections/{timeSeriesDatabaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="data"> The time series database connection description. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesDatabaseConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TimeSeriesDatabaseConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string timeSeriesDatabaseConnectionName, TimeSeriesDatabaseConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _timeSeriesDatabaseConnectionClientDiagnostics.CreateScope("TimeSeriesDatabaseConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _timeSeriesDatabaseConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, data, cancellationToken);
                var operation = new DigitalTwinsArmOperation<TimeSeriesDatabaseConnectionResource>(new TimeSeriesDatabaseConnectionOperationSource(Client), _timeSeriesDatabaseConnectionClientDiagnostics, Pipeline, _timeSeriesDatabaseConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the description of an existing time series database connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections/{timeSeriesDatabaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        public virtual async Task<Response<TimeSeriesDatabaseConnectionResource>> GetAsync(string timeSeriesDatabaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var scope = _timeSeriesDatabaseConnectionClientDiagnostics.CreateScope("TimeSeriesDatabaseConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _timeSeriesDatabaseConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TimeSeriesDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the description of an existing time series database connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections/{timeSeriesDatabaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        public virtual Response<TimeSeriesDatabaseConnectionResource> Get(string timeSeriesDatabaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var scope = _timeSeriesDatabaseConnectionClientDiagnostics.CreateScope("TimeSeriesDatabaseConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _timeSeriesDatabaseConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TimeSeriesDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all existing time series database connections for this DigitalTwins instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TimeSeriesDatabaseConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TimeSeriesDatabaseConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _timeSeriesDatabaseConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _timeSeriesDatabaseConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TimeSeriesDatabaseConnectionResource(Client, TimeSeriesDatabaseConnectionData.DeserializeTimeSeriesDatabaseConnectionData(e)), _timeSeriesDatabaseConnectionClientDiagnostics, Pipeline, "TimeSeriesDatabaseConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all existing time series database connections for this DigitalTwins instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TimeSeriesDatabaseConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TimeSeriesDatabaseConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _timeSeriesDatabaseConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _timeSeriesDatabaseConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TimeSeriesDatabaseConnectionResource(Client, TimeSeriesDatabaseConnectionData.DeserializeTimeSeriesDatabaseConnectionData(e)), _timeSeriesDatabaseConnectionClientDiagnostics, Pipeline, "TimeSeriesDatabaseConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections/{timeSeriesDatabaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string timeSeriesDatabaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var scope = _timeSeriesDatabaseConnectionClientDiagnostics.CreateScope("TimeSeriesDatabaseConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _timeSeriesDatabaseConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/timeSeriesDatabaseConnections/{timeSeriesDatabaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeSeriesDatabaseConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string timeSeriesDatabaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var scope = _timeSeriesDatabaseConnectionClientDiagnostics.CreateScope("TimeSeriesDatabaseConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _timeSeriesDatabaseConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, timeSeriesDatabaseConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TimeSeriesDatabaseConnectionResource> IEnumerable<TimeSeriesDatabaseConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TimeSeriesDatabaseConnectionResource> IAsyncEnumerable<TimeSeriesDatabaseConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}