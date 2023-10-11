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
    internal class EventGridTopicOperationSource : IOperationSource<EventGridTopicResource>
    {
        private readonly ArmClient _client;

        internal EventGridTopicOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridTopicResource IOperationSource<EventGridTopicResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventGridTopicData.DeserializeEventGridTopicData(document.RootElement);
            return new EventGridTopicResource(_client, data);
        }

        async ValueTask<EventGridTopicResource> IOperationSource<EventGridTopicResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventGridTopicData.DeserializeEventGridTopicData(document.RootElement);
            return new EventGridTopicResource(_client, data);
        }
    }
}