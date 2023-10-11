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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing an EventGridNamespacePermissionBinding along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EventGridNamespacePermissionBindingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEventGridNamespacePermissionBindingResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventGridNamespaceResource" /> using the GetEventGridNamespacePermissionBinding method.
    /// </summary>
    public partial class EventGridNamespacePermissionBindingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventGridNamespacePermissionBindingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string permissionBindingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics;
        private readonly PermissionBindingsRestOperations _eventGridNamespacePermissionBindingPermissionBindingsRestClient;
        private readonly EventGridNamespacePermissionBindingData _data;

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespacePermissionBindingResource"/> class for mocking. </summary>
        protected EventGridNamespacePermissionBindingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EventGridNamespacePermissionBindingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventGridNamespacePermissionBindingResource(ArmClient client, EventGridNamespacePermissionBindingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespacePermissionBindingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventGridNamespacePermissionBindingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventGridNamespacePermissionBindingPermissionBindingsApiVersion);
            _eventGridNamespacePermissionBindingPermissionBindingsRestClient = new PermissionBindingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventGridNamespacePermissionBindingPermissionBindingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/namespaces/permissionBindings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventGridNamespacePermissionBindingData Data
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
        /// Get properties of a permission binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventGridNamespacePermissionBindingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingResource.Get");
            scope.Start();
            try
            {
                var response = await _eventGridNamespacePermissionBindingPermissionBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespacePermissionBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a permission binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventGridNamespacePermissionBindingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingResource.Get");
            scope.Start();
            try
            {
                var response = _eventGridNamespacePermissionBindingPermissionBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespacePermissionBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existing permission binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingResource.Delete");
            scope.Start();
            try
            {
                var response = await _eventGridNamespacePermissionBindingPermissionBindingsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete an existing permission binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingResource.Delete");
            scope.Start();
            try
            {
                var response = _eventGridNamespacePermissionBindingPermissionBindingsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a permission binding with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Permission binding information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridNamespacePermissionBindingResource>> UpdateAsync(WaitUntil waitUntil, EventGridNamespacePermissionBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingResource.Update");
            scope.Start();
            try
            {
                var response = await _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridNamespacePermissionBindingResource>(new EventGridNamespacePermissionBindingOperationSource(Client), _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a permission binding with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/permissionBindings/{permissionBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PermissionBindings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Permission binding information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridNamespacePermissionBindingResource> Update(WaitUntil waitUntil, EventGridNamespacePermissionBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics.CreateScope("EventGridNamespacePermissionBindingResource.Update");
            scope.Start();
            try
            {
                var response = _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridNamespacePermissionBindingResource>(new EventGridNamespacePermissionBindingOperationSource(Client), _eventGridNamespacePermissionBindingPermissionBindingsClientDiagnostics, Pipeline, _eventGridNamespacePermissionBindingPermissionBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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