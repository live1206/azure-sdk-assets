// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    internal partial class ProviderHubRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ProviderHubRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ProviderHubRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-20";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGenerateManifestRequest(string subscriptionId, string providerNamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/generateManifest", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Generates the manifest for the given provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceProviderManifest>> GenerateManifestAsync(string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateGenerateManifestRequest(subscriptionId, providerNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceProviderManifest value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceProviderManifest.DeserializeResourceProviderManifest(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Generates the manifest for the given provider. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceProviderManifest> GenerateManifest(string subscriptionId, string providerNamespace, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));

            using var message = CreateGenerateManifestRequest(subscriptionId, providerNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceProviderManifest value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceProviderManifest.DeserializeResourceProviderManifest(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCheckinManifestRequest(string subscriptionId, string providerNamespace, CheckinManifestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ProviderHub/providerRegistrations/", false);
            uri.AppendPath(providerNamespace, true);
            uri.AppendPath("/checkinManifest", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Checkin the manifest. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="content"> The required body parameters supplied to the checkin manifest operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CheckinManifestInfo>> CheckinManifestAsync(string subscriptionId, string providerNamespace, CheckinManifestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckinManifestRequest(subscriptionId, providerNamespace, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckinManifestInfo value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CheckinManifestInfo.DeserializeCheckinManifestInfo(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Checkin the manifest. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="providerNamespace"> The name of the resource provider hosted within ProviderHub. </param>
        /// <param name="content"> The required body parameters supplied to the checkin manifest operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="providerNamespace"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="providerNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CheckinManifestInfo> CheckinManifest(string subscriptionId, string providerNamespace, CheckinManifestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(providerNamespace, nameof(providerNamespace));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckinManifestRequest(subscriptionId, providerNamespace, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CheckinManifestInfo value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CheckinManifestInfo.DeserializeCheckinManifestInfo(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}