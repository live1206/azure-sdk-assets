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

namespace Azure.ResourceManager.Elastic
{
    internal class ElasticMonitorResourceOperationSource : IOperationSource<ElasticMonitorResource>
    {
        private readonly ArmClient _client;

        internal ElasticMonitorResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ElasticMonitorResource IOperationSource<ElasticMonitorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ElasticMonitorResourceData.DeserializeElasticMonitorResourceData(document.RootElement);
            return new ElasticMonitorResource(_client, data);
        }

        async ValueTask<ElasticMonitorResource> IOperationSource<ElasticMonitorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ElasticMonitorResourceData.DeserializeElasticMonitorResourceData(document.RootElement);
            return new ElasticMonitorResource(_client, data);
        }
    }
}