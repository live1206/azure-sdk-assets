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

namespace Azure.ResourceManager.Compute
{
    internal class GalleryApplicationVersionOperationSource : IOperationSource<GalleryApplicationVersionResource>
    {
        private readonly ArmClient _client;

        internal GalleryApplicationVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        GalleryApplicationVersionResource IOperationSource<GalleryApplicationVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GalleryApplicationVersionData.DeserializeGalleryApplicationVersionData(document.RootElement);
            return new GalleryApplicationVersionResource(_client, data);
        }

        async ValueTask<GalleryApplicationVersionResource> IOperationSource<GalleryApplicationVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GalleryApplicationVersionData.DeserializeGalleryApplicationVersionData(document.RootElement);
            return new GalleryApplicationVersionResource(_client, data);
        }
    }
}
