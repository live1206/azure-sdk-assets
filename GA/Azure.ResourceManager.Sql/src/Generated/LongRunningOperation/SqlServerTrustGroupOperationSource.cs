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
    internal class SqlServerTrustGroupOperationSource : IOperationSource<SqlServerTrustGroupResource>
    {
        private readonly ArmClient _client;

        internal SqlServerTrustGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerTrustGroupResource IOperationSource<SqlServerTrustGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlServerTrustGroupData.DeserializeSqlServerTrustGroupData(document.RootElement);
            return new SqlServerTrustGroupResource(_client, data);
        }

        async ValueTask<SqlServerTrustGroupResource> IOperationSource<SqlServerTrustGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlServerTrustGroupData.DeserializeSqlServerTrustGroupData(document.RootElement);
            return new SqlServerTrustGroupResource(_client, data);
        }
    }
}