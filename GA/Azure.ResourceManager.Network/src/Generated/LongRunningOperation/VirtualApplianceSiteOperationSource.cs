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
    internal class VirtualApplianceSiteOperationSource : IOperationSource<VirtualApplianceSiteResource>
    {
        private readonly ArmClient _client;

        internal VirtualApplianceSiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualApplianceSiteResource IOperationSource<VirtualApplianceSiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(document.RootElement);
            return new VirtualApplianceSiteResource(_client, data);
        }

        async ValueTask<VirtualApplianceSiteResource> IOperationSource<VirtualApplianceSiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(document.RootElement);
            return new VirtualApplianceSiteResource(_client, data);
        }
    }
}