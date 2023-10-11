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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="ActionGroupResource" /> and their operations.
    /// Each <see cref="ActionGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ActionGroupCollection" /> instance call the GetActionGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ActionGroupCollection : ArmCollection, IEnumerable<ActionGroupResource>, IAsyncEnumerable<ActionGroupResource>
    {
        private readonly ClientDiagnostics _actionGroupClientDiagnostics;
        private readonly ActionGroupsRestOperations _actionGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ActionGroupCollection"/> class for mocking. </summary>
        protected ActionGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ActionGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ActionGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _actionGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ActionGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ActionGroupResource.ResourceType, out string actionGroupApiVersion);
            _actionGroupRestClient = new ActionGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, actionGroupApiVersion);
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
        /// Create a new action group or update an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="data"> The action group to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ActionGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string actionGroupName, ActionGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(actionGroupName, nameof(actionGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _actionGroupClientDiagnostics.CreateScope("ActionGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _actionGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, actionGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<ActionGroupResource>(Response.FromValue(new ActionGroupResource(Client, response), response.GetRawResponse()));
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
        /// Create a new action group or update an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="data"> The action group to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ActionGroupResource> CreateOrUpdate(WaitUntil waitUntil, string actionGroupName, ActionGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(actionGroupName, nameof(actionGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _actionGroupClientDiagnostics.CreateScope("ActionGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _actionGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, actionGroupName, data, cancellationToken);
                var operation = new MonitorArmOperation<ActionGroupResource>(Response.FromValue(new ActionGroupResource(Client, response), response.GetRawResponse()));
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
        /// Get an action group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> is null. </exception>
        public virtual async Task<Response<ActionGroupResource>> GetAsync(string actionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(actionGroupName, nameof(actionGroupName));

            using var scope = _actionGroupClientDiagnostics.CreateScope("ActionGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _actionGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, actionGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ActionGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an action group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> is null. </exception>
        public virtual Response<ActionGroupResource> Get(string actionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(actionGroupName, nameof(actionGroupName));

            using var scope = _actionGroupClientDiagnostics.CreateScope("ActionGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _actionGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, actionGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ActionGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all action groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ActionGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ActionGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _actionGroupRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ActionGroupResource(Client, ActionGroupData.DeserializeActionGroupData(e)), _actionGroupClientDiagnostics, Pipeline, "ActionGroupCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a list of all action groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ActionGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ActionGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _actionGroupRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ActionGroupResource(Client, ActionGroupData.DeserializeActionGroupData(e)), _actionGroupClientDiagnostics, Pipeline, "ActionGroupCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string actionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(actionGroupName, nameof(actionGroupName));

            using var scope = _actionGroupClientDiagnostics.CreateScope("ActionGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _actionGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, actionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ActionGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="actionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="actionGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string actionGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(actionGroupName, nameof(actionGroupName));

            using var scope = _actionGroupClientDiagnostics.CreateScope("ActionGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _actionGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, actionGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ActionGroupResource> IEnumerable<ActionGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ActionGroupResource> IAsyncEnumerable<ActionGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}