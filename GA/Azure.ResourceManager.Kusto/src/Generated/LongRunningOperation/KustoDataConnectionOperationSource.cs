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

namespace Azure.ResourceManager.Kusto
{
    internal class KustoDataConnectionOperationSource : IOperationSource<KustoDataConnectionResource>
    {
        private readonly ArmClient _client;

        internal KustoDataConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        KustoDataConnectionResource IOperationSource<KustoDataConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = KustoDataConnectionData.DeserializeKustoDataConnectionData(document.RootElement);
            return new KustoDataConnectionResource(_client, data);
        }

        async ValueTask<KustoDataConnectionResource> IOperationSource<KustoDataConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = KustoDataConnectionData.DeserializeKustoDataConnectionData(document.RootElement);
            return new KustoDataConnectionResource(_client, data);
        }
    }
}