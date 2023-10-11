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

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A Class representing a DeviceProvisioningServicesPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDeviceProvisioningServicesPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="DeviceProvisioningServiceResource" /> using the GetDeviceProvisioningServicesPrivateEndpointConnection method.
    /// </summary>
    public partial class DeviceProvisioningServicesPrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics;
        private readonly IotDpsResourceRestOperations _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient;
        private readonly DeviceProvisioningServicesPrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected DeviceProvisioningServicesPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeviceProvisioningServicesPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeviceProvisioningServicesPrivateEndpointConnectionResource(ArmClient client, DeviceProvisioningServicesPrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceProvisioningServicesPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceApiVersion);
            _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient = new IotDpsResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Devices/provisioningServices/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeviceProvisioningServicesPrivateEndpointConnectionData Data
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
        /// Get private endpoint connection properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeviceProvisioningServicesPrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get private endpoint connection properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeviceProvisioningServicesPrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete private endpoint connection with the specified name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_DeletePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.DeletePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>(new DeviceProvisioningServicesPrivateEndpointConnectionOperationSource(Client), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete private endpoint connection with the specified name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_DeletePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.DeletePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>(new DeviceProvisioningServicesPrivateEndpointConnectionOperationSource(Client), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the status of a private endpoint connection with the specified name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CreateOrUpdatePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection with updated properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, DeviceProvisioningServicesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateOrUpdatePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>(new DeviceProvisioningServicesPrivateEndpointConnectionOperationSource(Client), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateCreateOrUpdatePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the status of a private endpoint connection with the specified name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CreateOrUpdatePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection with updated properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource> Update(WaitUntil waitUntil, DeviceProvisioningServicesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateOrUpdatePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>(new DeviceProvisioningServicesPrivateEndpointConnectionOperationSource(Client), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateCreateOrUpdatePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
