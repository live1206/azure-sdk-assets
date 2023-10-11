// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    internal class NamespaceSharedAccessKeysOperationSource : IOperationSource<NamespaceSharedAccessKeys>
    {
        NamespaceSharedAccessKeys IOperationSource<NamespaceSharedAccessKeys>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return NamespaceSharedAccessKeys.DeserializeNamespaceSharedAccessKeys(document.RootElement);
        }

        async ValueTask<NamespaceSharedAccessKeys> IOperationSource<NamespaceSharedAccessKeys>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return NamespaceSharedAccessKeys.DeserializeNamespaceSharedAccessKeys(document.RootElement);
        }
    }
}