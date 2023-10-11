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
    internal class NetworkTapRuleOperationSource : IOperationSource<NetworkTapRuleResource>
    {
        private readonly ArmClient _client;

        internal NetworkTapRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkTapRuleResource IOperationSource<NetworkTapRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkTapRuleData.DeserializeNetworkTapRuleData(document.RootElement);
            return new NetworkTapRuleResource(_client, data);
        }

        async ValueTask<NetworkTapRuleResource> IOperationSource<NetworkTapRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkTapRuleData.DeserializeNetworkTapRuleData(document.RootElement);
            return new NetworkTapRuleResource(_client, data);
        }
    }
}