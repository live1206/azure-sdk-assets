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
    internal class RouteTableOperationSource : IOperationSource<RouteTableResource>
    {
        private readonly ArmClient _client;

        internal RouteTableOperationSource(ArmClient client)
        {
            _client = client;
        }

        RouteTableResource IOperationSource<RouteTableResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RouteTableData.DeserializeRouteTableData(document.RootElement);
            return new RouteTableResource(_client, data);
        }

        async ValueTask<RouteTableResource> IOperationSource<RouteTableResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RouteTableData.DeserializeRouteTableData(document.RootElement);
            return new RouteTableResource(_client, data);
        }
    }
}