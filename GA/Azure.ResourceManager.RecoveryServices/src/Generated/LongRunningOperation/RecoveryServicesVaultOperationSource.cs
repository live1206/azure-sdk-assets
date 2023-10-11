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

namespace Azure.ResourceManager.RecoveryServices
{
    internal class RecoveryServicesVaultOperationSource : IOperationSource<RecoveryServicesVaultResource>
    {
        private readonly ArmClient _client;

        internal RecoveryServicesVaultOperationSource(ArmClient client)
        {
            _client = client;
        }

        RecoveryServicesVaultResource IOperationSource<RecoveryServicesVaultResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RecoveryServicesVaultData.DeserializeRecoveryServicesVaultData(document.RootElement);
            return new RecoveryServicesVaultResource(_client, data);
        }

        async ValueTask<RecoveryServicesVaultResource> IOperationSource<RecoveryServicesVaultResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RecoveryServicesVaultData.DeserializeRecoveryServicesVaultData(document.RootElement);
            return new RecoveryServicesVaultResource(_client, data);
        }
    }
}