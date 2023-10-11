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

namespace Azure.ResourceManager.EventGrid
{
    internal class EventGridDomainPrivateEndpointConnectionOperationSource : IOperationSource<EventGridDomainPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal EventGridDomainPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridDomainPrivateEndpointConnectionResource IOperationSource<EventGridDomainPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventGridPrivateEndpointConnectionData.DeserializeEventGridPrivateEndpointConnectionData(document.RootElement);
            return new EventGridDomainPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<EventGridDomainPrivateEndpointConnectionResource> IOperationSource<EventGridDomainPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventGridPrivateEndpointConnectionData.DeserializeEventGridPrivateEndpointConnectionData(document.RootElement);
            return new EventGridDomainPrivateEndpointConnectionResource(_client, data);
        }
    }
}
