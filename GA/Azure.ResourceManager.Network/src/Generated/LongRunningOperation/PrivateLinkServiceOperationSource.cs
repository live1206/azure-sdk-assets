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
    internal class PrivateLinkServiceOperationSource : IOperationSource<PrivateLinkServiceResource>
    {
        private readonly ArmClient _client;

        internal PrivateLinkServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateLinkServiceResource IOperationSource<PrivateLinkServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateLinkServiceData.DeserializePrivateLinkServiceData(document.RootElement);
            return new PrivateLinkServiceResource(_client, data);
        }

        async ValueTask<PrivateLinkServiceResource> IOperationSource<PrivateLinkServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateLinkServiceData.DeserializePrivateLinkServiceData(document.RootElement);
            return new PrivateLinkServiceResource(_client, data);
        }
    }
}