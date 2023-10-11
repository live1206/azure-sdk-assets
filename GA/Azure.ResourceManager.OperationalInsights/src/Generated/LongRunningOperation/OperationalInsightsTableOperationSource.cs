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

namespace Azure.ResourceManager.OperationalInsights
{
    internal class OperationalInsightsTableOperationSource : IOperationSource<OperationalInsightsTableResource>
    {
        private readonly ArmClient _client;

        internal OperationalInsightsTableOperationSource(ArmClient client)
        {
            _client = client;
        }

        OperationalInsightsTableResource IOperationSource<OperationalInsightsTableResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = OperationalInsightsTableData.DeserializeOperationalInsightsTableData(document.RootElement);
            return new OperationalInsightsTableResource(_client, data);
        }

        async ValueTask<OperationalInsightsTableResource> IOperationSource<OperationalInsightsTableResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = OperationalInsightsTableData.DeserializeOperationalInsightsTableData(document.RootElement);
            return new OperationalInsightsTableResource(_client, data);
        }
    }
}
