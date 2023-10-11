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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabArtifactSourceResource" /> and their operations.
    /// Each <see cref="DevTestLabArtifactSourceResource" /> in the collection will belong to the same instance of <see cref="DevTestLabResource" />.
    /// To get a <see cref="DevTestLabArtifactSourceCollection" /> instance call the GetDevTestLabArtifactSources method from an instance of <see cref="DevTestLabResource" />.
    /// </summary>
    public partial class DevTestLabArtifactSourceCollection : ArmCollection, IEnumerable<DevTestLabArtifactSourceResource>, IAsyncEnumerable<DevTestLabArtifactSourceResource>
    {
        private readonly ClientDiagnostics _devTestLabArtifactSourceArtifactSourcesClientDiagnostics;
        private readonly ArtifactSourcesRestOperations _devTestLabArtifactSourceArtifactSourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabArtifactSourceCollection"/> class for mocking. </summary>
        protected DevTestLabArtifactSourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabArtifactSourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabArtifactSourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabArtifactSourceArtifactSourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabArtifactSourceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabArtifactSourceResource.ResourceType, out string devTestLabArtifactSourceArtifactSourcesApiVersion);
            _devTestLabArtifactSourceArtifactSourcesRestClient = new ArtifactSourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabArtifactSourceArtifactSourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing artifact source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="data"> Properties of an artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabArtifactSourceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabArtifactSourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabArtifactSourceArtifactSourcesClientDiagnostics.CreateScope("DevTestLabArtifactSourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabArtifactSourceArtifactSourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabArtifactSourceResource>(Response.FromValue(new DevTestLabArtifactSourceResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace an existing artifact source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="data"> Properties of an artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabArtifactSourceResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabArtifactSourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabArtifactSourceArtifactSourcesClientDiagnostics.CreateScope("DevTestLabArtifactSourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabArtifactSourceArtifactSourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabArtifactSourceResource>(Response.FromValue(new DevTestLabArtifactSourceResource(Client, response), response.GetRawResponse()));
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
        /// Get artifact source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabArtifactSourceResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabArtifactSourceArtifactSourcesClientDiagnostics.CreateScope("DevTestLabArtifactSourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabArtifactSourceArtifactSourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabArtifactSourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get artifact source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabArtifactSourceResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabArtifactSourceArtifactSourcesClientDiagnostics.CreateScope("DevTestLabArtifactSourceCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabArtifactSourceArtifactSourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabArtifactSourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List artifact sources in a given lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabArtifactSourceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabArtifactSourceResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabArtifactSourceArtifactSourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabArtifactSourceArtifactSourcesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabArtifactSourceResource(Client, DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(e)), _devTestLabArtifactSourceArtifactSourcesClientDiagnostics, Pipeline, "DevTestLabArtifactSourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List artifact sources in a given lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabArtifactSourceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabArtifactSourceResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabArtifactSourceArtifactSourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabArtifactSourceArtifactSourcesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabArtifactSourceResource(Client, DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(e)), _devTestLabArtifactSourceArtifactSourcesClientDiagnostics, Pipeline, "DevTestLabArtifactSourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabArtifactSourceArtifactSourcesClientDiagnostics.CreateScope("DevTestLabArtifactSourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabArtifactSourceArtifactSourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabArtifactSourceArtifactSourcesClientDiagnostics.CreateScope("DevTestLabArtifactSourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabArtifactSourceArtifactSourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabArtifactSourceResource> IEnumerable<DevTestLabArtifactSourceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabArtifactSourceResource> IAsyncEnumerable<DevTestLabArtifactSourceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}