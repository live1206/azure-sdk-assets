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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class LocalRulestackFqdnOperationSource : IOperationSource<LocalRulestackFqdnResource>
    {
        private readonly ArmClient _client;

        internal LocalRulestackFqdnOperationSource(ArmClient client)
        {
            _client = client;
        }

        LocalRulestackFqdnResource IOperationSource<LocalRulestackFqdnResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LocalRulestackFqdnData.DeserializeLocalRulestackFqdnData(document.RootElement);
            return new LocalRulestackFqdnResource(_client, data);
        }

        async ValueTask<LocalRulestackFqdnResource> IOperationSource<LocalRulestackFqdnResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LocalRulestackFqdnData.DeserializeLocalRulestackFqdnData(document.RootElement);
            return new LocalRulestackFqdnResource(_client, data);
        }
    }
}