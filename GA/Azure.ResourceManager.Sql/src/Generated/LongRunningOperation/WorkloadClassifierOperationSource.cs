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
    internal class WorkloadClassifierOperationSource : IOperationSource<WorkloadClassifierResource>
    {
        private readonly ArmClient _client;

        internal WorkloadClassifierOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkloadClassifierResource IOperationSource<WorkloadClassifierResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WorkloadClassifierData.DeserializeWorkloadClassifierData(document.RootElement);
            return new WorkloadClassifierResource(_client, data);
        }

        async ValueTask<WorkloadClassifierResource> IOperationSource<WorkloadClassifierResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WorkloadClassifierData.DeserializeWorkloadClassifierData(document.RootElement);
            return new WorkloadClassifierResource(_client, data);
        }
    }
}