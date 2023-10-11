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
    internal class FailoverGroupOperationSource : IOperationSource<FailoverGroupResource>
    {
        private readonly ArmClient _client;

        internal FailoverGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        FailoverGroupResource IOperationSource<FailoverGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FailoverGroupData.DeserializeFailoverGroupData(document.RootElement);
            return new FailoverGroupResource(_client, data);
        }

        async ValueTask<FailoverGroupResource> IOperationSource<FailoverGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FailoverGroupData.DeserializeFailoverGroupData(document.RootElement);
            return new FailoverGroupResource(_client, data);
        }
    }
}