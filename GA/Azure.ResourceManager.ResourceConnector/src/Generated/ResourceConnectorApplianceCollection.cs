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

namespace Azure.ResourceManager.ResourceConnector
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceConnectorApplianceResource" /> and their operations.
    /// Each <see cref="ResourceConnectorApplianceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResourceConnectorApplianceCollection" /> instance call the GetResourceConnectorAppliances method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResourceConnectorApplianceCollection : ArmCollection, IEnumerable<ResourceConnectorApplianceResource>, IAsyncEnumerable<ResourceConnectorApplianceResource>
    {
        private readonly ClientDiagnostics _resourceConnectorApplianceAppliancesClientDiagnostics;
        private readonly AppliancesRestOperations _resourceConnectorApplianceAppliancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceConnectorApplianceCollection"/> class for mocking. </summary>
        protected ResourceConnectorApplianceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceConnectorApplianceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceConnectorApplianceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceConnectorApplianceAppliancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceConnector", ResourceConnectorApplianceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceConnectorApplianceResource.ResourceType, out string resourceConnectorApplianceAppliancesApiVersion);
            _resourceConnectorApplianceAppliancesRestClient = new AppliancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceConnectorApplianceAppliancesApiVersion);
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
        /// Creates or updates an Appliance in the specified Subscription and Resource Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="data"> Parameters supplied to create or update an Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceConnectorApplianceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, ResourceConnectorApplianceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceConnectorApplianceAppliancesClientDiagnostics.CreateScope("ResourceConnectorApplianceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceConnectorApplianceAppliancesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceConnectorArmOperation<ResourceConnectorApplianceResource>(new ResourceConnectorApplianceOperationSource(Client), _resourceConnectorApplianceAppliancesClientDiagnostics, Pipeline, _resourceConnectorApplianceAppliancesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an Appliance in the specified Subscription and Resource Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="data"> Parameters supplied to create or update an Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceConnectorApplianceResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, ResourceConnectorApplianceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceConnectorApplianceAppliancesClientDiagnostics.CreateScope("ResourceConnectorApplianceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceConnectorApplianceAppliancesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, cancellationToken);
                var operation = new ResourceConnectorArmOperation<ResourceConnectorApplianceResource>(new ResourceConnectorApplianceOperationSource(Client), _resourceConnectorApplianceAppliancesClientDiagnostics, Pipeline, _resourceConnectorApplianceAppliancesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the details of an Appliance with a specified resource group and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<ResourceConnectorApplianceResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _resourceConnectorApplianceAppliancesClientDiagnostics.CreateScope("ResourceConnectorApplianceCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceConnectorApplianceAppliancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceConnectorApplianceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an Appliance with a specified resource group and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<ResourceConnectorApplianceResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _resourceConnectorApplianceAppliancesClientDiagnostics.CreateScope("ResourceConnectorApplianceCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceConnectorApplianceAppliancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceConnectorApplianceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Appliances in the specified subscription and resource group. The operation returns properties of each Appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceConnectorApplianceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceConnectorApplianceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceConnectorApplianceAppliancesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceConnectorApplianceAppliancesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceConnectorApplianceResource(Client, ResourceConnectorApplianceData.DeserializeResourceConnectorApplianceData(e)), _resourceConnectorApplianceAppliancesClientDiagnostics, Pipeline, "ResourceConnectorApplianceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Appliances in the specified subscription and resource group. The operation returns properties of each Appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceConnectorApplianceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceConnectorApplianceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceConnectorApplianceAppliancesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceConnectorApplianceAppliancesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceConnectorApplianceResource(Client, ResourceConnectorApplianceData.DeserializeResourceConnectorApplianceData(e)), _resourceConnectorApplianceAppliancesClientDiagnostics, Pipeline, "ResourceConnectorApplianceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _resourceConnectorApplianceAppliancesClientDiagnostics.CreateScope("ResourceConnectorApplianceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceConnectorApplianceAppliancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _resourceConnectorApplianceAppliancesClientDiagnostics.CreateScope("ResourceConnectorApplianceCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceConnectorApplianceAppliancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceConnectorApplianceResource> IEnumerable<ResourceConnectorApplianceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceConnectorApplianceResource> IAsyncEnumerable<ResourceConnectorApplianceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}