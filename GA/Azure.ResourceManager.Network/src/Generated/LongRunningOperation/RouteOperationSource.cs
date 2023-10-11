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
    internal class RouteOperationSource : IOperationSource<RouteResource>
    {
        private readonly ArmClient _client;

        internal RouteOperationSource(ArmClient client)
        {
            _client = client;
        }

        RouteResource IOperationSource<RouteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RouteData.DeserializeRouteData(document.RootElement);
            return new RouteResource(_client, data);
        }

        async ValueTask<RouteResource> IOperationSource<RouteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RouteData.DeserializeRouteData(document.RootElement);
            return new RouteResource(_client, data);
        }
    }
}