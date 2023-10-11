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

namespace Azure.ResourceManager.PostgreSql
{
    internal class PostgreSqlServerOperationSource : IOperationSource<PostgreSqlServerResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlServerResource IOperationSource<PostgreSqlServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlServerData.DeserializePostgreSqlServerData(document.RootElement);
            return new PostgreSqlServerResource(_client, data);
        }

        async ValueTask<PostgreSqlServerResource> IOperationSource<PostgreSqlServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlServerData.DeserializePostgreSqlServerData(document.RootElement);
            return new PostgreSqlServerResource(_client, data);
        }
    }
}