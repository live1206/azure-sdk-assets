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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantScheduledActionResource" /> and their operations.
    /// Each <see cref="TenantScheduledActionResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="TenantScheduledActionCollection" /> instance call the GetTenantScheduledActions method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class TenantScheduledActionCollection : ArmCollection
    {
        private readonly ClientDiagnostics _tenantScheduledActionScheduledActionsClientDiagnostics;
        private readonly ScheduledActionsRestOperations _tenantScheduledActionScheduledActionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantScheduledActionCollection"/> class for mocking. </summary>
        protected TenantScheduledActionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantScheduledActionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantScheduledActionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantScheduledActionScheduledActionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", TenantScheduledActionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantScheduledActionResource.ResourceType, out string tenantScheduledActionScheduledActionsApiVersion);
            _tenantScheduledActionScheduledActionsRestClient = new ScheduledActionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantScheduledActionScheduledActionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a private scheduled action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="data"> Scheduled action to be created or updated. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity. Optional when updating an entity and can be specified to achieve optimistic concurrency. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantScheduledActionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, ScheduledActionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantScheduledActionScheduledActionsClientDiagnostics.CreateScope("TenantScheduledActionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantScheduledActionScheduledActionsRestClient.CreateOrUpdateAsync(name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation<TenantScheduledActionResource>(Response.FromValue(new TenantScheduledActionResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a private scheduled action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="data"> Scheduled action to be created or updated. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity. Optional when updating an entity and can be specified to achieve optimistic concurrency. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TenantScheduledActionResource> CreateOrUpdate(WaitUntil waitUntil, string name, ScheduledActionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantScheduledActionScheduledActionsClientDiagnostics.CreateScope("TenantScheduledActionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantScheduledActionScheduledActionsRestClient.CreateOrUpdate(name, data, ifMatch, cancellationToken);
                var operation = new CostManagementArmOperation<TenantScheduledActionResource>(Response.FromValue(new TenantScheduledActionResource(Client, response), response.GetRawResponse()));
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
        /// Get the private scheduled action by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<TenantScheduledActionResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _tenantScheduledActionScheduledActionsClientDiagnostics.CreateScope("TenantScheduledActionCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantScheduledActionScheduledActionsRestClient.GetAsync(name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantScheduledActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the private scheduled action by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<TenantScheduledActionResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _tenantScheduledActionScheduledActionsClientDiagnostics.CreateScope("TenantScheduledActionCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantScheduledActionScheduledActionsRestClient.Get(name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantScheduledActionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _tenantScheduledActionScheduledActionsClientDiagnostics.CreateScope("TenantScheduledActionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantScheduledActionScheduledActionsRestClient.GetAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _tenantScheduledActionScheduledActionsClientDiagnostics.CreateScope("TenantScheduledActionCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantScheduledActionScheduledActionsRestClient.Get(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}