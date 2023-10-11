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

namespace Azure.ResourceManager.MachineLearningCompute
{
    internal class OperationalizationClusterOperationSource : IOperationSource<OperationalizationClusterResource>
    {
        private readonly ArmClient _client;

        internal OperationalizationClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        OperationalizationClusterResource IOperationSource<OperationalizationClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = OperationalizationClusterData.DeserializeOperationalizationClusterData(document.RootElement);
            return new OperationalizationClusterResource(_client, data);
        }

        async ValueTask<OperationalizationClusterResource> IOperationSource<OperationalizationClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = OperationalizationClusterData.DeserializeOperationalizationClusterData(document.RootElement);
            return new OperationalizationClusterResource(_client, data);
        }
    }
}
