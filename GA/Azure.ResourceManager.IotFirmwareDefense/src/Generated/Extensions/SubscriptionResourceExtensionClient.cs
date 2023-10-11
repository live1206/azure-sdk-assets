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

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _firmwareWorkspaceWorkspacesClientDiagnostics;
        private WorkspacesRestOperations _firmwareWorkspaceWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FirmwareWorkspaceWorkspacesClientDiagnostics => _firmwareWorkspaceWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IotFirmwareDefense", FirmwareWorkspaceResource.ResourceType.Namespace, Diagnostics);
        private WorkspacesRestOperations FirmwareWorkspaceWorkspacesRestClient => _firmwareWorkspaceWorkspacesRestClient ??= new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FirmwareWorkspaceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all of the firmware analysis workspaces in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTFirmwareDefense/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirmwareWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirmwareWorkspaceResource> GetFirmwareWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FirmwareWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FirmwareWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FirmwareWorkspaceResource(Client, FirmwareWorkspaceData.DeserializeFirmwareWorkspaceData(e)), FirmwareWorkspaceWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetFirmwareWorkspaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the firmware analysis workspaces in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTFirmwareDefense/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirmwareWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirmwareWorkspaceResource> GetFirmwareWorkspaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FirmwareWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FirmwareWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FirmwareWorkspaceResource(Client, FirmwareWorkspaceData.DeserializeFirmwareWorkspaceData(e)), FirmwareWorkspaceWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetFirmwareWorkspaces", "value", "nextLink", cancellationToken);
        }
    }
}