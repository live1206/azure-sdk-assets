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
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A Class representing a PrivateEndpointConnectionProxy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PrivateEndpointConnectionProxyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPrivateEndpointConnectionProxyResource method.
    /// Otherwise you can get one from its parent resource <see cref="DeviceUpdateAccountResource" /> using the GetPrivateEndpointConnectionProxy method.
    /// </summary>
    public partial class PrivateEndpointConnectionProxyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateEndpointConnectionProxyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateEndpointConnectionProxyClientDiagnostics;
        private readonly PrivateEndpointConnectionProxiesRestOperations _privateEndpointConnectionProxyRestClient;
        private readonly PrivateEndpointConnectionProxyData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxyResource"/> class for mocking. </summary>
        protected PrivateEndpointConnectionProxyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateEndpointConnectionProxyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateEndpointConnectionProxyResource(ArmClient client, PrivateEndpointConnectionProxyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateEndpointConnectionProxyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionProxyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string privateEndpointConnectionProxyApiVersion);
            _privateEndpointConnectionProxyRestClient = new PrivateEndpointConnectionProxiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateEndpointConnectionProxyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DeviceUpdate/accounts/privateEndpointConnectionProxies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateEndpointConnectionProxyData Data
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
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateEndpointConnectionProxyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnectionProxyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Delete");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation(_privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Delete");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DeviceUpdateArmOperation(_privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateEndpointConnectionProxyResource>> UpdateAsync(WaitUntil waitUntil, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Update");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation<PrivateEndpointConnectionProxyResource>(new PrivateEndpointConnectionProxyOperationSource(Client), _privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateEndpointConnectionProxyResource> Update(WaitUntil waitUntil, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Update");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DeviceUpdateArmOperation<PrivateEndpointConnectionProxyResource>(new PrivateEndpointConnectionProxyOperationSource(Client), _privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Validate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response> ValidateAsync(PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Validate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Validate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response Validate(PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.Validate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Updates a private endpoint inside the private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/updatePrivateEndpointProperties</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_UpdatePrivateEndpointProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointUpdate"> The parameters for updating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointUpdate"/> is null. </exception>
        public virtual async Task<Response> UpdatePrivateEndpointPropertiesAsync(PrivateEndpointUpdate privateEndpointUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointUpdate, nameof(privateEndpointUpdate));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.UpdatePrivateEndpointProperties");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.UpdatePrivateEndpointPropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointUpdate, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Updates a private endpoint inside the private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/updatePrivateEndpointProperties</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_UpdatePrivateEndpointProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointUpdate"> The parameters for updating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointUpdate"/> is null. </exception>
        public virtual Response UpdatePrivateEndpointProperties(PrivateEndpointUpdate privateEndpointUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointUpdate, nameof(privateEndpointUpdate));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyResource.UpdatePrivateEndpointProperties");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.UpdatePrivateEndpointProperties(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointUpdate, cancellationToken);
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
