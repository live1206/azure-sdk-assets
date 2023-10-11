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

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudClusterMetricsConfigurationOperationSource : IOperationSource<NetworkCloudClusterMetricsConfigurationResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudClusterMetricsConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudClusterMetricsConfigurationResource IOperationSource<NetworkCloudClusterMetricsConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkCloudClusterMetricsConfigurationData.DeserializeNetworkCloudClusterMetricsConfigurationData(document.RootElement);
            return new NetworkCloudClusterMetricsConfigurationResource(_client, data);
        }

        async ValueTask<NetworkCloudClusterMetricsConfigurationResource> IOperationSource<NetworkCloudClusterMetricsConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkCloudClusterMetricsConfigurationData.DeserializeNetworkCloudClusterMetricsConfigurationData(document.RootElement);
            return new NetworkCloudClusterMetricsConfigurationResource(_client, data);
        }
    }
}