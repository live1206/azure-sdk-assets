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
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary> A class to add extension methods to ManagementGroupResource. </summary>
    internal partial class ManagementGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _aggregatedCostClientDiagnostics;
        private AggregatedCostRestOperations _aggregatedCostRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ManagementGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AggregatedCostClientDiagnostics => _aggregatedCostClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AggregatedCostRestOperations AggregatedCostRestClient => _aggregatedCostRestClient ??= new AggregatedCostRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Provides the aggregate cost of a management group and all child management groups by current billing period.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Consumption/aggregatedcost</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AggregatedCost_GetByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter aggregated cost by properties/usageStart (Utc time), properties/usageEnd (Utc time). The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConsumptionAggregatedCostResult>> GetAggregatedCostAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = AggregatedCostClientDiagnostics.CreateScope("ManagementGroupResourceExtensionClient.GetAggregatedCost");
            scope.Start();
            try
            {
                var response = await AggregatedCostRestClient.GetByManagementGroupAsync(Id.Name, filter, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the aggregate cost of a management group and all child management groups by current billing period.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Consumption/aggregatedcost</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AggregatedCost_GetByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter aggregated cost by properties/usageStart (Utc time), properties/usageEnd (Utc time). The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConsumptionAggregatedCostResult> GetAggregatedCost(string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = AggregatedCostClientDiagnostics.CreateScope("ManagementGroupResourceExtensionClient.GetAggregatedCost");
            scope.Start();
            try
            {
                var response = AggregatedCostRestClient.GetByManagementGroup(Id.Name, filter, cancellationToken);
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