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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    internal class PostgreSqlFlexibleServerConfigurationOperationSource : IOperationSource<PostgreSqlFlexibleServerConfigurationResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlFlexibleServerConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlFlexibleServerConfigurationResource IOperationSource<PostgreSqlFlexibleServerConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlFlexibleServerConfigurationData.DeserializePostgreSqlFlexibleServerConfigurationData(document.RootElement);
            return new PostgreSqlFlexibleServerConfigurationResource(_client, data);
        }

        async ValueTask<PostgreSqlFlexibleServerConfigurationResource> IOperationSource<PostgreSqlFlexibleServerConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlFlexibleServerConfigurationData.DeserializePostgreSqlFlexibleServerConfigurationData(document.RootElement);
            return new PostgreSqlFlexibleServerConfigurationResource(_client, data);
        }
    }
}