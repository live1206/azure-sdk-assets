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

namespace Azure.ResourceManager.SecurityDevOps
{
    internal class AzureDevOpsConnectorOperationSource : IOperationSource<AzureDevOpsConnectorResource>
    {
        private readonly ArmClient _client;

        internal AzureDevOpsConnectorOperationSource(ArmClient client)
        {
            _client = client;
        }

        AzureDevOpsConnectorResource IOperationSource<AzureDevOpsConnectorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AzureDevOpsConnectorData.DeserializeAzureDevOpsConnectorData(document.RootElement);
            return new AzureDevOpsConnectorResource(_client, data);
        }

        async ValueTask<AzureDevOpsConnectorResource> IOperationSource<AzureDevOpsConnectorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AzureDevOpsConnectorData.DeserializeAzureDevOpsConnectorData(document.RootElement);
            return new AzureDevOpsConnectorResource(_client, data);
        }
    }
}
