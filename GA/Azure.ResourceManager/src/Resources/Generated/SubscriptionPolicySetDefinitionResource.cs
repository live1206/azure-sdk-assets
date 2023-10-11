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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a SubscriptionPolicySetDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SubscriptionPolicySetDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSubscriptionPolicySetDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetSubscriptionPolicySetDefinition method.
    /// </summary>
    public partial class SubscriptionPolicySetDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionPolicySetDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string policySetDefinitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient;
        private readonly PolicySetDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicySetDefinitionResource"/> class for mocking. </summary>
        protected SubscriptionPolicySetDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionPolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionPolicySetDefinitionResource(ArmClient client, PolicySetDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicySetDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionPolicySetDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policySetDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicySetDefinitionData Data
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
        /// This operation retrieves the policy set definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionPolicySetDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy set definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionPolicySetDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation deletes the policy set definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(response);
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
        /// This operation deletes the policy set definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionResource.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new ResourcesArmOperation(response);
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
        /// This operation creates or updates a policy set definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The policy set definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionPolicySetDefinitionResource>> UpdateAsync(WaitUntil waitUntil, PolicySetDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<SubscriptionPolicySetDefinitionResource>(Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response), response.GetRawResponse()));
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
        /// This operation creates or updates a policy set definition in the given subscription with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicySetDefinitions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The policy set definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionPolicySetDefinitionResource> Update(WaitUntil waitUntil, PolicySetDefinitionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinitionResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new ResourcesArmOperation<SubscriptionPolicySetDefinitionResource>(Response.FromValue(new SubscriptionPolicySetDefinitionResource(Client, response), response.GetRawResponse()));
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