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

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal class BackupProtectionContainerOperationSource : IOperationSource<BackupProtectionContainerResource>
    {
        private readonly ArmClient _client;

        internal BackupProtectionContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        BackupProtectionContainerResource IOperationSource<BackupProtectionContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BackupProtectionContainerData.DeserializeBackupProtectionContainerData(document.RootElement);
            return new BackupProtectionContainerResource(_client, data);
        }

        async ValueTask<BackupProtectionContainerResource> IOperationSource<BackupProtectionContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BackupProtectionContainerData.DeserializeBackupProtectionContainerData(document.RootElement);
            return new BackupProtectionContainerResource(_client, data);
        }
    }
}