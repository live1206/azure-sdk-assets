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

namespace Azure.ResourceManager.Sql
{
    internal class VirtualClusterOperationSource : IOperationSource<VirtualClusterResource>
    {
        private readonly ArmClient _client;

        internal VirtualClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualClusterResource IOperationSource<VirtualClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualClusterData.DeserializeVirtualClusterData(document.RootElement);
            return new VirtualClusterResource(_client, data);
        }

        async ValueTask<VirtualClusterResource> IOperationSource<VirtualClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualClusterData.DeserializeVirtualClusterData(document.RootElement);
            return new VirtualClusterResource(_client, data);
        }
    }
}