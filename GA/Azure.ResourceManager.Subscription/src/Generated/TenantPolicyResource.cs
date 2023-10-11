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
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A Class representing a TenantPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenantPolicy method.
    /// </summary>
    public partial class TenantPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier()
        {
            var resourceId = $"/providers/Microsoft.Subscription/policies/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantPolicySubscriptionPolicyClientDiagnostics;
        private readonly SubscriptionPolicyRestOperations _tenantPolicySubscriptionPolicyRestClient;
        private readonly TenantPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicyResource"/> class for mocking. </summary>
        protected TenantPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantPolicyResource(ArmClient client, TenantPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPolicySubscriptionPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Subscription", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantPolicySubscriptionPolicyApiVersion);
            _tenantPolicySubscriptionPolicyRestClient = new SubscriptionPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPolicySubscriptionPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Subscription/policies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantPolicyData Data
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
        /// Get the subscription tenant policy for the user's tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionPolicy_GetPolicyForTenant</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySubscriptionPolicyClientDiagnostics.CreateScope("TenantPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantPolicySubscriptionPolicyRestClient.GetPolicyForTenantAsync(cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the subscription tenant policy for the user's tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionPolicy_GetPolicyForTenant</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tenantPolicySubscriptionPolicyClientDiagnostics.CreateScope("TenantPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _tenantPolicySubscriptionPolicyRestClient.GetPolicyForTenant(cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update Subscription tenant policy for user's tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionPolicy_AddUpdatePolicyForTenant</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The TenantPolicyCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, TenantPolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _tenantPolicySubscriptionPolicyClientDiagnostics.CreateScope("TenantPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantPolicySubscriptionPolicyRestClient.AddUpdatePolicyForTenantAsync(content, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionArmOperation<TenantPolicyResource>(Response.FromValue(new TenantPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update Subscription tenant policy for user's tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionPolicy_AddUpdatePolicyForTenant</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The TenantPolicyCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<TenantPolicyResource> CreateOrUpdate(WaitUntil waitUntil, TenantPolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _tenantPolicySubscriptionPolicyClientDiagnostics.CreateScope("TenantPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantPolicySubscriptionPolicyRestClient.AddUpdatePolicyForTenant(content, cancellationToken);
                var operation = new SubscriptionArmOperation<TenantPolicyResource>(Response.FromValue(new TenantPolicyResource(Client, response), response.GetRawResponse()));
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