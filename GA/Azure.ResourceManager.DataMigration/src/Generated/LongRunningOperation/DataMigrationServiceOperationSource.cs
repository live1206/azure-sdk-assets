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

namespace Azure.ResourceManager.DataMigration
{
    internal class DataMigrationServiceOperationSource : IOperationSource<DataMigrationServiceResource>
    {
        private readonly ArmClient _client;

        internal DataMigrationServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataMigrationServiceResource IOperationSource<DataMigrationServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataMigrationServiceData.DeserializeDataMigrationServiceData(document.RootElement);
            return new DataMigrationServiceResource(_client, data);
        }

        async ValueTask<DataMigrationServiceResource> IOperationSource<DataMigrationServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataMigrationServiceData.DeserializeDataMigrationServiceData(document.RootElement);
            return new DataMigrationServiceResource(_client, data);
        }
    }
}