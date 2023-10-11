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

namespace Azure.ResourceManager.Network
{
    internal class NetworkVirtualApplianceConnectionOperationSource : IOperationSource<NetworkVirtualApplianceConnectionResource>
    {
        private readonly ArmClient _client;

        internal NetworkVirtualApplianceConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkVirtualApplianceConnectionResource IOperationSource<NetworkVirtualApplianceConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkVirtualApplianceConnectionData.DeserializeNetworkVirtualApplianceConnectionData(document.RootElement);
            return new NetworkVirtualApplianceConnectionResource(_client, data);
        }

        async ValueTask<NetworkVirtualApplianceConnectionResource> IOperationSource<NetworkVirtualApplianceConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkVirtualApplianceConnectionData.DeserializeNetworkVirtualApplianceConnectionData(document.RootElement);
            return new NetworkVirtualApplianceConnectionResource(_client, data);
        }
    }
}