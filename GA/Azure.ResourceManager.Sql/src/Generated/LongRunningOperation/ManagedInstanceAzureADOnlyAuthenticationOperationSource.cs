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

namespace Azure.ResourceManager.Sql
{
    internal class ManagedInstanceAzureADOnlyAuthenticationOperationSource : IOperationSource<ManagedInstanceAzureADOnlyAuthenticationResource>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceAzureADOnlyAuthenticationOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceAzureADOnlyAuthenticationResource IOperationSource<ManagedInstanceAzureADOnlyAuthenticationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedInstanceAzureADOnlyAuthenticationData.DeserializeManagedInstanceAzureADOnlyAuthenticationData(document.RootElement);
            return new ManagedInstanceAzureADOnlyAuthenticationResource(_client, data);
        }

        async ValueTask<ManagedInstanceAzureADOnlyAuthenticationResource> IOperationSource<ManagedInstanceAzureADOnlyAuthenticationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedInstanceAzureADOnlyAuthenticationData.DeserializeManagedInstanceAzureADOnlyAuthenticationData(document.RootElement);
            return new ManagedInstanceAzureADOnlyAuthenticationResource(_client, data);
        }
    }
}