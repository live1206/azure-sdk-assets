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

namespace Azure.ResourceManager.Hci
{
    internal class HciClusterOperationSource : IOperationSource<HciClusterResource>
    {
        private readonly ArmClient _client;

        internal HciClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        HciClusterResource IOperationSource<HciClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HciClusterData.DeserializeHciClusterData(document.RootElement);
            return new HciClusterResource(_client, data);
        }

        async ValueTask<HciClusterResource> IOperationSource<HciClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HciClusterData.DeserializeHciClusterData(document.RootElement);
            return new HciClusterResource(_client, data);
        }
    }
}
