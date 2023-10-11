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
using Azure.ResourceManager.ManagementPartner.Models;

namespace Azure.ResourceManager.ManagementPartner
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _operationClientDiagnostics;
        private OperationRestOperations _operationRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics OperationClientDiagnostics => _operationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ManagementPartner", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationRestOperations OperationRestClient => _operationRestClient ??= new OperationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PartnerResponseResources in the TenantResource. </summary>
        /// <returns> An object representing collection of PartnerResponseResources and their operations over a PartnerResponseResource. </returns>
        public virtual PartnerResponseCollection GetPartnerResponses()
        {
            return GetCachedClient(Client => new PartnerResponseCollection(Client, Id));
        }

        /// <summary>
        /// List all the operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operation_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationResponse" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationResponse> GetOperationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, OperationResponse.DeserializeOperationResponse, OperationClientDiagnostics, Pipeline, "TenantResourceExtensionClient.GetOperations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operation_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationResponse" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationResponse> GetOperations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, OperationResponse.DeserializeOperationResponse, OperationClientDiagnostics, Pipeline, "TenantResourceExtensionClient.GetOperations", "value", "nextLink", cancellationToken);
        }
    }
}