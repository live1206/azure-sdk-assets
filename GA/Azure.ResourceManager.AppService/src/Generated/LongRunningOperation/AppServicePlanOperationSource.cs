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

namespace Azure.ResourceManager.AppService
{
    internal class AppServicePlanOperationSource : IOperationSource<AppServicePlanResource>
    {
        private readonly ArmClient _client;

        internal AppServicePlanOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppServicePlanResource IOperationSource<AppServicePlanResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServicePlanData.DeserializeAppServicePlanData(document.RootElement);
            return new AppServicePlanResource(_client, data);
        }

        async ValueTask<AppServicePlanResource> IOperationSource<AppServicePlanResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServicePlanData.DeserializeAppServicePlanData(document.RootElement);
            return new AppServicePlanResource(_client, data);
        }
    }
}