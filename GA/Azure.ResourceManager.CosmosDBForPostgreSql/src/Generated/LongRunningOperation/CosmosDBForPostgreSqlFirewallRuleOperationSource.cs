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

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    internal class CosmosDBForPostgreSqlFirewallRuleOperationSource : IOperationSource<CosmosDBForPostgreSqlFirewallRuleResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBForPostgreSqlFirewallRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBForPostgreSqlFirewallRuleResource IOperationSource<CosmosDBForPostgreSqlFirewallRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBForPostgreSqlFirewallRuleData.DeserializeCosmosDBForPostgreSqlFirewallRuleData(document.RootElement);
            return new CosmosDBForPostgreSqlFirewallRuleResource(_client, data);
        }

        async ValueTask<CosmosDBForPostgreSqlFirewallRuleResource> IOperationSource<CosmosDBForPostgreSqlFirewallRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBForPostgreSqlFirewallRuleData.DeserializeCosmosDBForPostgreSqlFirewallRuleData(document.RootElement);
            return new CosmosDBForPostgreSqlFirewallRuleResource(_client, data);
        }
    }
}