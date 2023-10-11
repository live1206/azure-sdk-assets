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

namespace Azure.ResourceManager.Network
{
    internal class DscpConfigurationOperationSource : IOperationSource<DscpConfigurationResource>
    {
        private readonly ArmClient _client;

        internal DscpConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        DscpConfigurationResource IOperationSource<DscpConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DscpConfigurationData.DeserializeDscpConfigurationData(document.RootElement);
            return new DscpConfigurationResource(_client, data);
        }

        async ValueTask<DscpConfigurationResource> IOperationSource<DscpConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DscpConfigurationData.DeserializeDscpConfigurationData(document.RootElement);
            return new DscpConfigurationResource(_client, data);
        }
    }
}