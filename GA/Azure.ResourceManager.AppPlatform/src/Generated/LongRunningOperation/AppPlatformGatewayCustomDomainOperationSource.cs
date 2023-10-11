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

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformGatewayCustomDomainOperationSource : IOperationSource<AppPlatformGatewayCustomDomainResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformGatewayCustomDomainOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformGatewayCustomDomainResource IOperationSource<AppPlatformGatewayCustomDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppPlatformGatewayCustomDomainData.DeserializeAppPlatformGatewayCustomDomainData(document.RootElement);
            return new AppPlatformGatewayCustomDomainResource(_client, data);
        }

        async ValueTask<AppPlatformGatewayCustomDomainResource> IOperationSource<AppPlatformGatewayCustomDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppPlatformGatewayCustomDomainData.DeserializeAppPlatformGatewayCustomDomainData(document.RootElement);
            return new AppPlatformGatewayCustomDomainResource(_client, data);
        }
    }
}