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

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceFabricApplicationTypeResource" /> and their operations.
    /// Each <see cref="ServiceFabricApplicationTypeResource" /> in the collection will belong to the same instance of <see cref="ServiceFabricClusterResource" />.
    /// To get a <see cref="ServiceFabricApplicationTypeCollection" /> instance call the GetServiceFabricApplicationTypes method from an instance of <see cref="ServiceFabricClusterResource" />.
    /// </summary>
    public partial class ServiceFabricApplicationTypeCollection : ArmCollection, IEnumerable<ServiceFabricApplicationTypeResource>, IAsyncEnumerable<ServiceFabricApplicationTypeResource>
    {
        private readonly ClientDiagnostics _serviceFabricApplicationTypeApplicationTypesClientDiagnostics;
        private readonly ApplicationTypesRestOperations _serviceFabricApplicationTypeApplicationTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeCollection"/> class for mocking. </summary>
        protected ServiceFabricApplicationTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceFabricApplicationTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricApplicationTypeApplicationTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ServiceFabricApplicationTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceFabricApplicationTypeResource.ResourceType, out string serviceFabricApplicationTypeApplicationTypesApiVersion);
            _serviceFabricApplicationTypeApplicationTypesRestClient = new ApplicationTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricApplicationTypeApplicationTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricApplicationTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationTypeName, ServiceFabricApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeApplicationTypesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationTypeResource>(Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Service Fabric application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricApplicationTypeResource> CreateOrUpdate(WaitUntil waitUntil, string applicationTypeName, ServiceFabricApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeApplicationTypesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, data, cancellationToken);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationTypeResource>(Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricApplicationTypeResource>> GetAsync(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual Response<ServiceFabricApplicationTypeResource> Get(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all application type name resources created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricApplicationTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricApplicationTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricApplicationTypeApplicationTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ServiceFabricApplicationTypeResource(Client, ServiceFabricApplicationTypeData.DeserializeServiceFabricApplicationTypeData(e)), _serviceFabricApplicationTypeApplicationTypesClientDiagnostics, Pipeline, "ServiceFabricApplicationTypeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all application type name resources created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricApplicationTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricApplicationTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricApplicationTypeApplicationTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ServiceFabricApplicationTypeResource(Client, ServiceFabricApplicationTypeData.DeserializeServiceFabricApplicationTypeData(e)), _serviceFabricApplicationTypeApplicationTypesClientDiagnostics, Pipeline, "ServiceFabricApplicationTypeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceFabricApplicationTypeResource> IEnumerable<ServiceFabricApplicationTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceFabricApplicationTypeResource> IAsyncEnumerable<ServiceFabricApplicationTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}