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

namespace Azure.ResourceManager.DevCenter
{
    internal class DevCenterNetworkConnectionOperationSource : IOperationSource<DevCenterNetworkConnectionResource>
    {
        private readonly ArmClient _client;

        internal DevCenterNetworkConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevCenterNetworkConnectionResource IOperationSource<DevCenterNetworkConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DevCenterNetworkConnectionData.DeserializeDevCenterNetworkConnectionData(document.RootElement);
            return new DevCenterNetworkConnectionResource(_client, data);
        }

        async ValueTask<DevCenterNetworkConnectionResource> IOperationSource<DevCenterNetworkConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DevCenterNetworkConnectionData.DeserializeDevCenterNetworkConnectionData(document.RootElement);
            return new DevCenterNetworkConnectionResource(_client, data);
        }
    }
}