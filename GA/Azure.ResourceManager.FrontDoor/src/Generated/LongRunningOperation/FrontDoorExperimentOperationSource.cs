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

namespace Azure.ResourceManager.FrontDoor
{
    internal class FrontDoorExperimentOperationSource : IOperationSource<FrontDoorExperimentResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorExperimentOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorExperimentResource IOperationSource<FrontDoorExperimentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FrontDoorExperimentData.DeserializeFrontDoorExperimentData(document.RootElement);
            return new FrontDoorExperimentResource(_client, data);
        }

        async ValueTask<FrontDoorExperimentResource> IOperationSource<FrontDoorExperimentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FrontDoorExperimentData.DeserializeFrontDoorExperimentData(document.RootElement);
            return new FrontDoorExperimentResource(_client, data);
        }
    }
}