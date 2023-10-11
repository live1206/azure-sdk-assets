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

namespace Azure.ResourceManager.Communication
{
    internal class EmailServiceResourceOperationSource : IOperationSource<EmailServiceResource>
    {
        private readonly ArmClient _client;

        internal EmailServiceResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        EmailServiceResource IOperationSource<EmailServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EmailServiceResourceData.DeserializeEmailServiceResourceData(document.RootElement);
            return new EmailServiceResource(_client, data);
        }

        async ValueTask<EmailServiceResource> IOperationSource<EmailServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EmailServiceResourceData.DeserializeEmailServiceResourceData(document.RootElement);
            return new EmailServiceResource(_client, data);
        }
    }
}