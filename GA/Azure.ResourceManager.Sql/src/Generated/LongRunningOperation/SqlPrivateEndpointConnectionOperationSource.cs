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
    internal class SqlPrivateEndpointConnectionOperationSource : IOperationSource<SqlPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal SqlPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlPrivateEndpointConnectionResource IOperationSource<SqlPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlPrivateEndpointConnectionData.DeserializeSqlPrivateEndpointConnectionData(document.RootElement);
            return new SqlPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<SqlPrivateEndpointConnectionResource> IOperationSource<SqlPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlPrivateEndpointConnectionData.DeserializeSqlPrivateEndpointConnectionData(document.RootElement);
            return new SqlPrivateEndpointConnectionResource(_client, data);
        }
    }
}