// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _privateLinkScopeOperationStatusClientDiagnostics;
        private PrivateLinkScopeOperationStatusRestOperations _privateLinkScopeOperationStatusRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PrivateLinkScopeOperationStatusClientDiagnostics => _privateLinkScopeOperationStatusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Monitor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PrivateLinkScopeOperationStatusRestOperations PrivateLinkScopeOperationStatusRestClient => _privateLinkScopeOperationStatusRestClient ??= new PrivateLinkScopeOperationStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AutoscaleSettingResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AutoscaleSettingResources and their operations over a AutoscaleSettingResource. </returns>
        public virtual AutoscaleSettingCollection GetAutoscaleSettings()
        {
            return GetCachedClient(Client => new AutoscaleSettingCollection(Client, Id));
        }

        /// <summary> Gets a collection of AlertRuleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AlertRuleResources and their operations over a AlertRuleResource. </returns>
        public virtual AlertRuleCollection GetAlertRules()
        {
            return GetCachedClient(Client => new AlertRuleCollection(Client, Id));
        }

        /// <summary> Gets a collection of ActionGroupResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ActionGroupResources and their operations over a ActionGroupResource. </returns>
        public virtual ActionGroupCollection GetActionGroups()
        {
            return GetCachedClient(Client => new ActionGroupCollection(Client, Id));
        }

        /// <summary> Gets a collection of MetricAlertResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MetricAlertResources and their operations over a MetricAlertResource. </returns>
        public virtual MetricAlertCollection GetMetricAlerts()
        {
            return GetCachedClient(Client => new MetricAlertCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScheduledQueryRuleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScheduledQueryRuleResources and their operations over a ScheduledQueryRuleResource. </returns>
        public virtual ScheduledQueryRuleCollection GetScheduledQueryRules()
        {
            return GetCachedClient(Client => new ScheduledQueryRuleCollection(Client, Id));
        }

        /// <summary> Gets a collection of MonitorPrivateLinkScopeResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MonitorPrivateLinkScopeResources and their operations over a MonitorPrivateLinkScopeResource. </returns>
        public virtual MonitorPrivateLinkScopeCollection GetMonitorPrivateLinkScopes()
        {
            return GetCachedClient(Client => new MonitorPrivateLinkScopeCollection(Client, Id));
        }

        /// <summary> Gets a collection of ActivityLogAlertResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ActivityLogAlertResources and their operations over a ActivityLogAlertResource. </returns>
        public virtual ActivityLogAlertCollection GetActivityLogAlerts()
        {
            return GetCachedClient(Client => new ActivityLogAlertCollection(Client, Id));
        }

        /// <summary> Gets a collection of DataCollectionEndpointResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataCollectionEndpointResources and their operations over a DataCollectionEndpointResource. </returns>
        public virtual DataCollectionEndpointCollection GetDataCollectionEndpoints()
        {
            return GetCachedClient(Client => new DataCollectionEndpointCollection(Client, Id));
        }

        /// <summary> Gets a collection of DataCollectionRuleResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataCollectionRuleResources and their operations over a DataCollectionRuleResource. </returns>
        public virtual DataCollectionRuleCollection GetDataCollectionRules()
        {
            return GetCachedClient(Client => new DataCollectionRuleCollection(Client, Id));
        }

        /// <summary> Gets a collection of MonitorWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MonitorWorkspaceResources and their operations over a MonitorWorkspaceResource. </returns>
        public virtual MonitorWorkspaceResourceCollection GetMonitorWorkspaceResources()
        {
            return GetCachedClient(Client => new MonitorWorkspaceResourceCollection(Client, Id));
        }

        /// <summary>
        /// Get the status of an azure asynchronous operation associated with a private link scope operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopeOperationStatuses/{asyncOperationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopeOperationStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="asyncOperationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MonitorPrivateLinkScopeOperationStatus>> GetPrivateLinkScopeOperationStatusAsync(string asyncOperationId, CancellationToken cancellationToken = default)
        {
            using var scope = PrivateLinkScopeOperationStatusClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPrivateLinkScopeOperationStatus");
            scope.Start();
            try
            {
                var response = await PrivateLinkScopeOperationStatusRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, asyncOperationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the status of an azure asynchronous operation associated with a private link scope operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopeOperationStatuses/{asyncOperationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopeOperationStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="asyncOperationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MonitorPrivateLinkScopeOperationStatus> GetPrivateLinkScopeOperationStatus(string asyncOperationId, CancellationToken cancellationToken = default)
        {
            using var scope = PrivateLinkScopeOperationStatusClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPrivateLinkScopeOperationStatus");
            scope.Start();
            try
            {
                var response = PrivateLinkScopeOperationStatusRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, asyncOperationId, cancellationToken);
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