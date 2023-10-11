// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ApiManagementGlobalSchemaOperationSource : IOperationSource<ApiManagementGlobalSchemaResource>
    {
        private readonly ArmClient _client;

        internal ApiManagementGlobalSchemaOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApiManagementGlobalSchemaResource IOperationSource<ApiManagementGlobalSchemaResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApiManagementGlobalSchemaData.DeserializeApiManagementGlobalSchemaData(document.RootElement);
            return new ApiManagementGlobalSchemaResource(_client, data);
        }

        async ValueTask<ApiManagementGlobalSchemaResource> IOperationSource<ApiManagementGlobalSchemaResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApiManagementGlobalSchemaData.DeserializeApiManagementGlobalSchemaData(document.RootElement);
            return new ApiManagementGlobalSchemaResource(_client, data);
        }
    }
}