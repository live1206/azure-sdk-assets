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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal class SiteRecoveryPolicyOperationSource : IOperationSource<SiteRecoveryPolicyResource>
    {
        private readonly ArmClient _client;

        internal SiteRecoveryPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteRecoveryPolicyResource IOperationSource<SiteRecoveryPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteRecoveryPolicyData.DeserializeSiteRecoveryPolicyData(document.RootElement);
            return new SiteRecoveryPolicyResource(_client, data);
        }

        async ValueTask<SiteRecoveryPolicyResource> IOperationSource<SiteRecoveryPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteRecoveryPolicyData.DeserializeSiteRecoveryPolicyData(document.RootElement);
            return new SiteRecoveryPolicyResource(_client, data);
        }
    }
}