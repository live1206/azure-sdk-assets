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

namespace Azure.ResourceManager.DataLakeStore
{
    internal class DataLakeStoreAccountOperationSource : IOperationSource<DataLakeStoreAccountResource>
    {
        private readonly ArmClient _client;

        internal DataLakeStoreAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataLakeStoreAccountResource IOperationSource<DataLakeStoreAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataLakeStoreAccountData.DeserializeDataLakeStoreAccountData(document.RootElement);
            return new DataLakeStoreAccountResource(_client, data);
        }

        async ValueTask<DataLakeStoreAccountResource> IOperationSource<DataLakeStoreAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataLakeStoreAccountData.DeserializeDataLakeStoreAccountData(document.RootElement);
            return new DataLakeStoreAccountResource(_client, data);
        }
    }
}