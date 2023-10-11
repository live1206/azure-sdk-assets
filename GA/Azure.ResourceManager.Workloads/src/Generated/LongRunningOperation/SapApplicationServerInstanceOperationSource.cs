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

namespace Azure.ResourceManager.Workloads
{
    internal class SapApplicationServerInstanceOperationSource : IOperationSource<SapApplicationServerInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapApplicationServerInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapApplicationServerInstanceResource IOperationSource<SapApplicationServerInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapApplicationServerInstanceData.DeserializeSapApplicationServerInstanceData(document.RootElement);
            return new SapApplicationServerInstanceResource(_client, data);
        }

        async ValueTask<SapApplicationServerInstanceResource> IOperationSource<SapApplicationServerInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapApplicationServerInstanceData.DeserializeSapApplicationServerInstanceData(document.RootElement);
            return new SapApplicationServerInstanceResource(_client, data);
        }
    }
}