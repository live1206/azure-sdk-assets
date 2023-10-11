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
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a NamespaceTopicEventSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NamespaceTopicEventSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNamespaceTopicEventSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="NamespaceTopicResource" /> using the GetNamespaceTopicEventSubscription method.
    /// </summary>
    public partial class NamespaceTopicEventSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NamespaceTopicEventSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName, string eventSubscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _namespaceTopicEventSubscriptionClientDiagnostics;
        private readonly NamespaceTopicEventSubscriptionsRestOperations _namespaceTopicEventSubscriptionRestClient;
        private readonly NamespaceTopicEventSubscriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="NamespaceTopicEventSubscriptionResource"/> class for mocking. </summary>
        protected NamespaceTopicEventSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NamespaceTopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NamespaceTopicEventSubscriptionResource(ArmClient client, NamespaceTopicEventSubscriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceTopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NamespaceTopicEventSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string namespaceTopicEventSubscriptionApiVersion);
            _namespaceTopicEventSubscriptionRestClient = new NamespaceTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, namespaceTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/namespaces/topics/eventSubscriptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NamespaceTopicEventSubscriptionData Data
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
        /// Get properties of an event subscription of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NamespaceTopicEventSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceTopicEventSubscriptionClientDiagnostics.CreateScope("NamespaceTopicEventSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _namespaceTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of an event subscription of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopicEventSubscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NamespaceTopicEventSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceTopicEventSubscriptionClientDiagnostics.CreateScope("NamespaceTopicEventSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _namespaceTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existing event subscription of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopicEventSubscriptions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceTopicEventSubscriptionClientDiagnostics.CreateScope("NamespaceTopicEventSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _namespaceTopicEventSubscriptionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_namespaceTopicEventSubscriptionClientDiagnostics, Pipeline, _namespaceTopicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete an existing event subscription of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopicEventSubscriptions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceTopicEventSubscriptionClientDiagnostics.CreateScope("NamespaceTopicEventSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _namespaceTopicEventSubscriptionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_namespaceTopicEventSubscriptionClientDiagnostics, Pipeline, _namespaceTopicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing event subscription of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopicEventSubscriptions_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<NamespaceTopicEventSubscriptionResource>> UpdateAsync(WaitUntil waitUntil, NamespaceTopicEventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _namespaceTopicEventSubscriptionClientDiagnostics.CreateScope("NamespaceTopicEventSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = await _namespaceTopicEventSubscriptionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<NamespaceTopicEventSubscriptionResource>(new NamespaceTopicEventSubscriptionOperationSource(Client), _namespaceTopicEventSubscriptionClientDiagnostics, Pipeline, _namespaceTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Update an existing event subscription of a namespace topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NamespaceTopicEventSubscriptions_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<NamespaceTopicEventSubscriptionResource> Update(WaitUntil waitUntil, NamespaceTopicEventSubscriptionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _namespaceTopicEventSubscriptionClientDiagnostics.CreateScope("NamespaceTopicEventSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = _namespaceTopicEventSubscriptionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new EventGridArmOperation<NamespaceTopicEventSubscriptionResource>(new NamespaceTopicEventSubscriptionOperationSource(Client), _namespaceTopicEventSubscriptionClientDiagnostics, Pipeline, _namespaceTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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