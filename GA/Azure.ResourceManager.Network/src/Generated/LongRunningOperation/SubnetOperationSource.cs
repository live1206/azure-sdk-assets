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
    internal class SubnetOperationSource : IOperationSource<SubnetResource>
    {
        private readonly ArmClient _client;

        internal SubnetOperationSource(ArmClient client)
        {
            _client = client;
        }

        SubnetResource IOperationSource<SubnetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SubnetData.DeserializeSubnetData(document.RootElement);
            return new SubnetResource(_client, data);
        }

        async ValueTask<SubnetResource> IOperationSource<SubnetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SubnetData.DeserializeSubnetData(document.RootElement);
            return new SubnetResource(_client, data);
        }
    }
}
