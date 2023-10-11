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

namespace Azure.ResourceManager.DataShare
{
    internal class DataShareTriggerOperationSource : IOperationSource<DataShareTriggerResource>
    {
        private readonly ArmClient _client;

        internal DataShareTriggerOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataShareTriggerResource IOperationSource<DataShareTriggerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataShareTriggerData.DeserializeDataShareTriggerData(document.RootElement);
            return new DataShareTriggerResource(_client, data);
        }

        async ValueTask<DataShareTriggerResource> IOperationSource<DataShareTriggerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataShareTriggerData.DeserializeDataShareTriggerData(document.RootElement);
            return new DataShareTriggerResource(_client, data);
        }
    }
}