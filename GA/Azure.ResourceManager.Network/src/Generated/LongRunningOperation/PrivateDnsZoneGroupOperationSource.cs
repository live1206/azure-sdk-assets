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
    internal class PrivateDnsZoneGroupOperationSource : IOperationSource<PrivateDnsZoneGroupResource>
    {
        private readonly ArmClient _client;

        internal PrivateDnsZoneGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateDnsZoneGroupResource IOperationSource<PrivateDnsZoneGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateDnsZoneGroupData.DeserializePrivateDnsZoneGroupData(document.RootElement);
            return new PrivateDnsZoneGroupResource(_client, data);
        }

        async ValueTask<PrivateDnsZoneGroupResource> IOperationSource<PrivateDnsZoneGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateDnsZoneGroupData.DeserializePrivateDnsZoneGroupData(document.RootElement);
            return new PrivateDnsZoneGroupResource(_client, data);
        }
    }
}