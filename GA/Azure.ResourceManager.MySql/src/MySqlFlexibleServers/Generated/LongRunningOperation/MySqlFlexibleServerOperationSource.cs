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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerOperationSource : IOperationSource<MySqlFlexibleServerResource>
    {
        private readonly ArmClient _client;

        internal MySqlFlexibleServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFlexibleServerResource IOperationSource<MySqlFlexibleServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFlexibleServerData.DeserializeMySqlFlexibleServerData(document.RootElement);
            return new MySqlFlexibleServerResource(_client, data);
        }

        async ValueTask<MySqlFlexibleServerResource> IOperationSource<MySqlFlexibleServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFlexibleServerData.DeserializeMySqlFlexibleServerData(document.RootElement);
            return new MySqlFlexibleServerResource(_client, data);
        }
    }
}