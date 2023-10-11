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

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBAccountOperationSource : IOperationSource<CosmosDBAccountResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBAccountResource IOperationSource<CosmosDBAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBAccountData.DeserializeCosmosDBAccountData(document.RootElement);
            return new CosmosDBAccountResource(_client, data);
        }

        async ValueTask<CosmosDBAccountResource> IOperationSource<CosmosDBAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBAccountData.DeserializeCosmosDBAccountData(document.RootElement);
            return new CosmosDBAccountResource(_client, data);
        }
    }
}