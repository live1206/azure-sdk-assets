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
    internal class SiteRecoveryServicesProviderOperationSource : IOperationSource<SiteRecoveryServicesProviderResource>
    {
        private readonly ArmClient _client;

        internal SiteRecoveryServicesProviderOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteRecoveryServicesProviderResource IOperationSource<SiteRecoveryServicesProviderResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteRecoveryServicesProviderData.DeserializeSiteRecoveryServicesProviderData(document.RootElement);
            return new SiteRecoveryServicesProviderResource(_client, data);
        }

        async ValueTask<SiteRecoveryServicesProviderResource> IOperationSource<SiteRecoveryServicesProviderResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteRecoveryServicesProviderData.DeserializeSiteRecoveryServicesProviderData(document.RootElement);
            return new SiteRecoveryServicesProviderResource(_client, data);
        }
    }
}