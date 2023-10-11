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
    internal class SqlServerAzureADAdministratorOperationSource : IOperationSource<SqlServerAzureADAdministratorResource>
    {
        private readonly ArmClient _client;

        internal SqlServerAzureADAdministratorOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerAzureADAdministratorResource IOperationSource<SqlServerAzureADAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlServerAzureADAdministratorData.DeserializeSqlServerAzureADAdministratorData(document.RootElement);
            return new SqlServerAzureADAdministratorResource(_client, data);
        }

        async ValueTask<SqlServerAzureADAdministratorResource> IOperationSource<SqlServerAzureADAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlServerAzureADAdministratorData.DeserializeSqlServerAzureADAdministratorData(document.RootElement);
            return new SqlServerAzureADAdministratorResource(_client, data);
        }
    }
}