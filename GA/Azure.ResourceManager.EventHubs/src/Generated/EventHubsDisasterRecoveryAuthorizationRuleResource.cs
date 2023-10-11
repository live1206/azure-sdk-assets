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
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A Class representing an EventHubsDisasterRecoveryAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEventHubsDisasterRecoveryAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventHubsDisasterRecoveryResource" /> using the GetEventHubsDisasterRecoveryAuthorizationRule method.
    /// </summary>
    public partial class EventHubsDisasterRecoveryAuthorizationRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{@alias}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient;
        private readonly EventHubsAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource"/> class for mocking. </summary>
        protected EventHubsDisasterRecoveryAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EventHubsDisasterRecoveryAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventHubsDisasterRecoveryAuthorizationRuleResource(ArmClient client, EventHubsAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventHubsDisasterRecoveryAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventHub/namespaces/disasterRecoveryConfigs/authorizationRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventHubsAuthorizationRuleData Data
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
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventHubsDisasterRecoveryAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventHubsDisasterRecoveryAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the primary and secondary connection strings for the Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_ListKeys</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventHubsAccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the primary and secondary connection strings for the Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_ListKeys</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventHubsAccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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