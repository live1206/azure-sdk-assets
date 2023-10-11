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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricNeighborGroupOperationSource : IOperationSource<NetworkFabricNeighborGroupResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricNeighborGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricNeighborGroupResource IOperationSource<NetworkFabricNeighborGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricNeighborGroupData.DeserializeNetworkFabricNeighborGroupData(document.RootElement);
            return new NetworkFabricNeighborGroupResource(_client, data);
        }

        async ValueTask<NetworkFabricNeighborGroupResource> IOperationSource<NetworkFabricNeighborGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricNeighborGroupData.DeserializeNetworkFabricNeighborGroupData(document.RootElement);
            return new NetworkFabricNeighborGroupResource(_client, data);
        }
    }
}