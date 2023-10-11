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
using Azure.ResourceManager.ContainerService.Models;

namespace Azure.ResourceManager.ContainerService
{
    internal partial class TrustedAccessRoleBindingsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TrustedAccessRoleBindingsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TrustedAccessRoleBindingsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-02-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerService/managedClusters/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/trustedAccessRoleBindings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List trusted access role bindings. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TrustedAccessRoleBindingListResult>> ListAsync(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TrustedAccessRoleBindingListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TrustedAccessRoleBindingListResult.DeserializeTrustedAccessRoleBindingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List trusted access role bindings. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TrustedAccessRoleBindingListResult> List(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TrustedAccessRoleBindingListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TrustedAccessRoleBindingListResult.DeserializeTrustedAccessRoleBindingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerService/managedClusters/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/trustedAccessRoleBindings/", false);
            uri.AppendPath(trustedAccessRoleBindingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a trusted access role binding. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerServiceTrustedAccessRoleBindingData>> GetAsync(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, trustedAccessRoleBindingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerServiceTrustedAccessRoleBindingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ContainerServiceTrustedAccessRoleBindingData.DeserializeContainerServiceTrustedAccessRoleBindingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ContainerServiceTrustedAccessRoleBindingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a trusted access role binding. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerServiceTrustedAccessRoleBindingData> Get(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, trustedAccessRoleBindingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerServiceTrustedAccessRoleBindingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ContainerServiceTrustedAccessRoleBindingData.DeserializeContainerServiceTrustedAccessRoleBindingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ContainerServiceTrustedAccessRoleBindingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, ContainerServiceTrustedAccessRoleBindingData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerService/managedClusters/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/trustedAccessRoleBindings/", false);
            uri.AppendPath(trustedAccessRoleBindingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a trusted access role binding. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="data"> A trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="trustedAccessRoleBindingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerServiceTrustedAccessRoleBindingData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, ContainerServiceTrustedAccessRoleBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, resourceName, trustedAccessRoleBindingName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerServiceTrustedAccessRoleBindingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ContainerServiceTrustedAccessRoleBindingData.DeserializeContainerServiceTrustedAccessRoleBindingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a trusted access role binding. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="data"> A trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="trustedAccessRoleBindingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerServiceTrustedAccessRoleBindingData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, ContainerServiceTrustedAccessRoleBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, resourceName, trustedAccessRoleBindingName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerServiceTrustedAccessRoleBindingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ContainerServiceTrustedAccessRoleBindingData.DeserializeContainerServiceTrustedAccessRoleBindingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ContainerService/managedClusters/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/trustedAccessRoleBindings/", false);
            uri.AppendPath(trustedAccessRoleBindingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a trusted access role binding. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, trustedAccessRoleBindingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a trusted access role binding. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, trustedAccessRoleBindingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceName)
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

        /// <summary> List trusted access role bindings. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TrustedAccessRoleBindingListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TrustedAccessRoleBindingListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TrustedAccessRoleBindingListResult.DeserializeTrustedAccessRoleBindingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List trusted access role bindings. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TrustedAccessRoleBindingListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TrustedAccessRoleBindingListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TrustedAccessRoleBindingListResult.DeserializeTrustedAccessRoleBindingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
