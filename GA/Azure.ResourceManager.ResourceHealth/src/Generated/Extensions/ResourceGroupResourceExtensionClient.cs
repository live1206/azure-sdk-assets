// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _availabilityStatusesClientDiagnostics;
        private AvailabilityStatusesRestOperations _availabilityStatusesRestClient;

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

        private ClientDiagnostics AvailabilityStatusesClientDiagnostics => _availabilityStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailabilityStatusesRestOperations AvailabilityStatusesRestClient => _availabilityStatusesRestClient ??= new AvailabilityStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the current availability status for all the resources in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceHealth/availabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesByResourceGroupAsync(string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailabilityStatusesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailabilityStatusesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, AvailabilityStatusesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetAvailabilityStatusesByResourceGroup", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the current availability status for all the resources in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceHealth/availabilityStatuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilityStatuses_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthAvailabilityStatus" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesByResourceGroup(string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailabilityStatusesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailabilityStatusesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus, AvailabilityStatusesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetAvailabilityStatusesByResourceGroup", "value", "nextLink", cancellationToken);
        }
    }
}