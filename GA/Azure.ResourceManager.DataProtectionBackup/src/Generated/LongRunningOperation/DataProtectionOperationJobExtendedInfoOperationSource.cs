// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    internal class DataProtectionOperationJobExtendedInfoOperationSource : IOperationSource<DataProtectionOperationJobExtendedInfo>
    {
        DataProtectionOperationJobExtendedInfo IOperationSource<DataProtectionOperationJobExtendedInfo>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataProtectionOperationJobExtendedInfo.DeserializeDataProtectionOperationJobExtendedInfo(document.RootElement);
        }

        async ValueTask<DataProtectionOperationJobExtendedInfo> IOperationSource<DataProtectionOperationJobExtendedInfo>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataProtectionOperationJobExtendedInfo.DeserializeDataProtectionOperationJobExtendedInfo(document.RootElement);
        }
    }
}