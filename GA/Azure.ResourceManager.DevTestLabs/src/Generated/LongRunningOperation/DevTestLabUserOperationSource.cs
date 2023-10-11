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

namespace Azure.ResourceManager.DevTestLabs
{
    internal class DevTestLabUserOperationSource : IOperationSource<DevTestLabUserResource>
    {
        private readonly ArmClient _client;

        internal DevTestLabUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevTestLabUserResource IOperationSource<DevTestLabUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DevTestLabUserData.DeserializeDevTestLabUserData(document.RootElement);
            return new DevTestLabUserResource(_client, data);
        }

        async ValueTask<DevTestLabUserResource> IOperationSource<DevTestLabUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DevTestLabUserData.DeserializeDevTestLabUserData(document.RootElement);
            return new DevTestLabUserResource(_client, data);
        }
    }
}