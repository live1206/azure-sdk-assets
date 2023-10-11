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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VMwareHostOperationSource : IOperationSource<VMwareHostResource>
    {
        private readonly ArmClient _client;

        internal VMwareHostOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareHostResource IOperationSource<VMwareHostResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VMwareHostData.DeserializeVMwareHostData(document.RootElement);
            return new VMwareHostResource(_client, data);
        }

        async ValueTask<VMwareHostResource> IOperationSource<VMwareHostResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VMwareHostData.DeserializeVMwareHostData(document.RootElement);
            return new VMwareHostResource(_client, data);
        }
    }
}