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
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A Class representing a DataBoxEdgeOrder along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataBoxEdgeOrderResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataBoxEdgeOrderResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataBoxEdgeDeviceResource" /> using the GetDataBoxEdgeOrder method.
    /// </summary>
    public partial class DataBoxEdgeOrderResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataBoxEdgeOrderResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string deviceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataBoxEdgeOrderOrdersClientDiagnostics;
        private readonly OrdersRestOperations _dataBoxEdgeOrderOrdersRestClient;
        private readonly DataBoxEdgeOrderData _data;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeOrderResource"/> class for mocking. </summary>
        protected DataBoxEdgeOrderResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataBoxEdgeOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataBoxEdgeOrderResource(ArmClient client, DataBoxEdgeOrderData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataBoxEdgeOrderResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeOrderOrdersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataBoxEdgeOrderOrdersApiVersion);
            _dataBoxEdgeOrderOrdersRestClient = new OrdersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeOrderOrdersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataBoxEdgeOrderData Data
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
        /// Gets a specific order by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataBoxEdgeOrderResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeOrderOrdersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific order by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataBoxEdgeOrderResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeOrderOrdersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the order related to the device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeOrderOrdersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation(_dataBoxEdgeOrderOrdersClientDiagnostics, Pipeline, _dataBoxEdgeOrderOrdersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the order related to the device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.Delete");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeOrderOrdersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                var operation = new DataBoxEdgeArmOperation(_dataBoxEdgeOrderOrdersClientDiagnostics, Pipeline, _dataBoxEdgeOrderOrdersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Creates or updates an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The order to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeOrderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, DataBoxEdgeOrderData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeOrderOrdersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeOrderResource>(new DataBoxEdgeOrderOperationSource(Client), _dataBoxEdgeOrderOrdersClientDiagnostics, Pipeline, _dataBoxEdgeOrderOrdersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The order to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeOrderResource> CreateOrUpdate(WaitUntil waitUntil, DataBoxEdgeOrderData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeOrderOrdersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeOrderResource>(new DataBoxEdgeOrderOperationSource(Client), _dataBoxEdgeOrderOrdersClientDiagnostics, Pipeline, _dataBoxEdgeOrderOrdersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the DCAccess Code
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default/listDCAccessCode</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_ListDCAccessCode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataBoxEdgeDataCenterAccessCode>> GetDataCenterAccessCodeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.GetDataCenterAccessCode");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeOrderOrdersRestClient.ListDCAccessCodeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the DCAccess Code
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/orders/default/listDCAccessCode</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Orders_ListDCAccessCode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataBoxEdgeDataCenterAccessCode> GetDataCenterAccessCode(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeOrderOrdersClientDiagnostics.CreateScope("DataBoxEdgeOrderResource.GetDataCenterAccessCode");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeOrderOrdersRestClient.ListDCAccessCode(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}