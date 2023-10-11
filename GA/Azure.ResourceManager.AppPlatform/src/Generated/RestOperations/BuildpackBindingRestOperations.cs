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
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    internal partial class BuildpackBindingRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BuildpackBindingRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BuildpackBindingRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/builders/", false);
            uri.AppendPath(builderName, true);
            uri.AppendPath("/buildpackBindings/", false);
            uri.AppendPath(buildpackBindingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a buildpack binding by name. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppPlatformBuildpackBindingData>> GetAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppPlatformBuildpackBindingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppPlatformBuildpackBindingData.DeserializeAppPlatformBuildpackBindingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppPlatformBuildpackBindingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a buildpack binding by name. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppPlatformBuildpackBindingData> Get(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppPlatformBuildpackBindingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppPlatformBuildpackBindingData.DeserializeAppPlatformBuildpackBindingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppPlatformBuildpackBindingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, AppPlatformBuildpackBindingData data)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/builders/", false);
            uri.AppendPath(builderName, true);
            uri.AppendPath("/buildpackBindings/", false);
            uri.AppendPath(buildpackBindingName, true);
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

        /// <summary> Create or update a buildpack binding. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="data"> The target buildpack binding for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/>, <paramref name="buildpackBindingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, AppPlatformBuildpackBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a buildpack binding. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="data"> The target buildpack binding for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/>, <paramref name="buildpackBindingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, AppPlatformBuildpackBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/builders/", false);
            uri.AppendPath(builderName, true);
            uri.AppendPath("/buildpackBindings/", false);
            uri.AppendPath(buildpackBindingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Operation to delete a Buildpack Binding. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Operation to delete a Buildpack Binding. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="buildpackBindingName"> The name of the Buildpack Binding Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="builderName"/> or <paramref name="buildpackBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNullOrEmpty(buildpackBindingName, nameof(buildpackBindingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/builders/", false);
            uri.AppendPath(builderName, true);
            uri.AppendPath("/buildpackBindings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Handles requests to list all buildpack bindings in a builder. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BuildpackBindingResourceList>> ListAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildpackBindingResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BuildpackBindingResourceList.DeserializeBuildpackBindingResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Handles requests to list all buildpack bindings in a builder. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BuildpackBindingResourceList> List(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildpackBindingResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BuildpackBindingResourceList.DeserializeBuildpackBindingResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName)
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

        /// <summary> Handles requests to list all buildpack bindings in a builder. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BuildpackBindingResourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildpackBindingResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BuildpackBindingResourceList.DeserializeBuildpackBindingResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Handles requests to list all buildpack bindings in a builder. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BuildpackBindingResourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, serviceName, buildServiceName, builderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildpackBindingResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BuildpackBindingResourceList.DeserializeBuildpackBindingResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}