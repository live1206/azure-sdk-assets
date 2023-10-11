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

namespace Azure.ResourceManager.DigitalTwins
{
    internal class TimeSeriesDatabaseConnectionOperationSource : IOperationSource<TimeSeriesDatabaseConnectionResource>
    {
        private readonly ArmClient _client;

        internal TimeSeriesDatabaseConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        TimeSeriesDatabaseConnectionResource IOperationSource<TimeSeriesDatabaseConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = TimeSeriesDatabaseConnectionData.DeserializeTimeSeriesDatabaseConnectionData(document.RootElement);
            return new TimeSeriesDatabaseConnectionResource(_client, data);
        }

        async ValueTask<TimeSeriesDatabaseConnectionResource> IOperationSource<TimeSeriesDatabaseConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = TimeSeriesDatabaseConnectionData.DeserializeTimeSeriesDatabaseConnectionData(document.RootElement);
            return new TimeSeriesDatabaseConnectionResource(_client, data);
        }
    }
}