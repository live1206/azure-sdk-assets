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

namespace Azure.ResourceManager.Dynatrace
{
    internal class DynatraceTagRuleOperationSource : IOperationSource<DynatraceTagRuleResource>
    {
        private readonly ArmClient _client;

        internal DynatraceTagRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        DynatraceTagRuleResource IOperationSource<DynatraceTagRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DynatraceTagRuleData.DeserializeDynatraceTagRuleData(document.RootElement);
            return new DynatraceTagRuleResource(_client, data);
        }

        async ValueTask<DynatraceTagRuleResource> IOperationSource<DynatraceTagRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DynatraceTagRuleData.DeserializeDynatraceTagRuleData(document.RootElement);
            return new DynatraceTagRuleResource(_client, data);
        }
    }
}