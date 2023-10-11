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

namespace Azure.ResourceManager.Batch
{
    internal class BatchPrivateEndpointConnectionOperationSource : IOperationSource<BatchPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal BatchPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        BatchPrivateEndpointConnectionResource IOperationSource<BatchPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BatchPrivateEndpointConnectionData.DeserializeBatchPrivateEndpointConnectionData(document.RootElement);
            return new BatchPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<BatchPrivateEndpointConnectionResource> IOperationSource<BatchPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BatchPrivateEndpointConnectionData.DeserializeBatchPrivateEndpointConnectionData(document.RootElement);
            return new BatchPrivateEndpointConnectionResource(_client, data);
        }
    }
}