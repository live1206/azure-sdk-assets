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

namespace Azure.ResourceManager.MySql
{
    internal class MySqlServerSecurityAlertPolicyOperationSource : IOperationSource<MySqlServerSecurityAlertPolicyResource>
    {
        private readonly ArmClient _client;

        internal MySqlServerSecurityAlertPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlServerSecurityAlertPolicyResource IOperationSource<MySqlServerSecurityAlertPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlServerSecurityAlertPolicyData.DeserializeMySqlServerSecurityAlertPolicyData(document.RootElement);
            return new MySqlServerSecurityAlertPolicyResource(_client, data);
        }

        async ValueTask<MySqlServerSecurityAlertPolicyResource> IOperationSource<MySqlServerSecurityAlertPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlServerSecurityAlertPolicyData.DeserializeMySqlServerSecurityAlertPolicyData(document.RootElement);
            return new MySqlServerSecurityAlertPolicyResource(_client, data);
        }
    }
}