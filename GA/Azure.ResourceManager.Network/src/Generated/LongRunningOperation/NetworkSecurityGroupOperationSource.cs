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
    internal class NetworkSecurityGroupOperationSource : IOperationSource<NetworkSecurityGroupResource>
    {
        private readonly ArmClient _client;

        internal NetworkSecurityGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkSecurityGroupResource IOperationSource<NetworkSecurityGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(document.RootElement);
            return new NetworkSecurityGroupResource(_client, data);
        }

        async ValueTask<NetworkSecurityGroupResource> IOperationSource<NetworkSecurityGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(document.RootElement);
            return new NetworkSecurityGroupResource(_client, data);
        }
    }
}