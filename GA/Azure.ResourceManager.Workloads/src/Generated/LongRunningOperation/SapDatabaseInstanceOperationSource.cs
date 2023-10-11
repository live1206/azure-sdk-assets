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

namespace Azure.ResourceManager.Workloads
{
    internal class SapDatabaseInstanceOperationSource : IOperationSource<SapDatabaseInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapDatabaseInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapDatabaseInstanceResource IOperationSource<SapDatabaseInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapDatabaseInstanceData.DeserializeSapDatabaseInstanceData(document.RootElement);
            return new SapDatabaseInstanceResource(_client, data);
        }

        async ValueTask<SapDatabaseInstanceResource> IOperationSource<SapDatabaseInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapDatabaseInstanceData.DeserializeSapDatabaseInstanceData(document.RootElement);
            return new SapDatabaseInstanceResource(_client, data);
        }
    }
}