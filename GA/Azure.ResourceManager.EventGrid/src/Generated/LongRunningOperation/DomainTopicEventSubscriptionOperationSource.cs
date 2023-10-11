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
    internal class DomainTopicEventSubscriptionOperationSource : IOperationSource<DomainTopicEventSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal DomainTopicEventSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        DomainTopicEventSubscriptionResource IOperationSource<DomainTopicEventSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventGridSubscriptionData.DeserializeEventGridSubscriptionData(document.RootElement);
            return new DomainTopicEventSubscriptionResource(_client, data);
        }

        async ValueTask<DomainTopicEventSubscriptionResource> IOperationSource<DomainTopicEventSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventGridSubscriptionData.DeserializeEventGridSubscriptionData(document.RootElement);
            return new DomainTopicEventSubscriptionResource(_client, data);
        }
    }
}