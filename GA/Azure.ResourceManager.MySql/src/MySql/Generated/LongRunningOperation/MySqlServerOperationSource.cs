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

namespace Azure.ResourceManager.MySql
{
    internal class MySqlServerOperationSource : IOperationSource<MySqlServerResource>
    {
        private readonly ArmClient _client;

        internal MySqlServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlServerResource IOperationSource<MySqlServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlServerData.DeserializeMySqlServerData(document.RootElement);
            return new MySqlServerResource(_client, data);
        }

        async ValueTask<MySqlServerResource> IOperationSource<MySqlServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlServerData.DeserializeMySqlServerData(document.RootElement);
            return new MySqlServerResource(_client, data);
        }
    }
}