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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal partial class CommunityGalleryImageVersionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CommunityGalleryImageVersionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CommunityGalleryImageVersionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-03";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, string galleryImageVersionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/communityGalleries/", false);
            uri.AppendPath(publicGalleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a community gallery image version. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="galleryImageVersionName"> The name of the community gallery image version. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/>, <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/>, <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CommunityGalleryImageVersionData>> GetAsync(string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var message = CreateGetRequest(subscriptionId, location, publicGalleryName, galleryImageName, galleryImageVersionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunityGalleryImageVersionData.DeserializeCommunityGalleryImageVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CommunityGalleryImageVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a community gallery image version. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="galleryImageVersionName"> The name of the community gallery image version. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/>, <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/>, <paramref name="galleryImageName"/> or <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CommunityGalleryImageVersionData> Get(string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var message = CreateGetRequest(subscriptionId, location, publicGalleryName, galleryImageName, galleryImageVersionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunityGalleryImageVersionData.DeserializeCommunityGalleryImageVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CommunityGalleryImageVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/communityGalleries/", false);
            uri.AppendPath(publicGalleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List community gallery image versions inside an image. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CommunityGalleryImageVersionList>> ListAsync(string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var message = CreateListRequest(subscriptionId, location, publicGalleryName, galleryImageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunityGalleryImageVersionList.DeserializeCommunityGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List community gallery image versions inside an image. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CommunityGalleryImageVersionList> List(string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var message = CreateListRequest(subscriptionId, location, publicGalleryName, galleryImageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunityGalleryImageVersionList.DeserializeCommunityGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List community gallery image versions inside an image. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CommunityGalleryImageVersionList>> ListNextPageAsync(string nextLink, string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, location, publicGalleryName, galleryImageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunityGalleryImageVersionList.DeserializeCommunityGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List community gallery image versions inside an image. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="publicGalleryName"/> or <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CommunityGalleryImageVersionList> ListNextPage(string nextLink, string subscriptionId, AzureLocation location, string publicGalleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(publicGalleryName, nameof(publicGalleryName));
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, location, publicGalleryName, galleryImageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunityGalleryImageVersionList.DeserializeCommunityGalleryImageVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
