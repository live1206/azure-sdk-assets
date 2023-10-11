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

namespace Azure.ResourceManager.Qumulo
{
    internal class QumuloFileSystemResourceOperationSource : IOperationSource<QumuloFileSystemResource>
    {
        private readonly ArmClient _client;

        internal QumuloFileSystemResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        QumuloFileSystemResource IOperationSource<QumuloFileSystemResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(document.RootElement);
            return new QumuloFileSystemResource(_client, data);
        }

        async ValueTask<QumuloFileSystemResource> IOperationSource<QumuloFileSystemResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(document.RootElement);
            return new QumuloFileSystemResource(_client, data);
        }
    }
}