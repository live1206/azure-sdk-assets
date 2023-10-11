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

namespace Azure.ResourceManager.ArcScVmm
{
    internal class ScVmmServerOperationSource : IOperationSource<ScVmmServerResource>
    {
        private readonly ArmClient _client;

        internal ScVmmServerOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScVmmServerResource IOperationSource<ScVmmServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScVmmServerData.DeserializeScVmmServerData(document.RootElement);
            return new ScVmmServerResource(_client, data);
        }

        async ValueTask<ScVmmServerResource> IOperationSource<ScVmmServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScVmmServerData.DeserializeScVmmServerData(document.RootElement);
            return new ScVmmServerResource(_client, data);
        }
    }
}