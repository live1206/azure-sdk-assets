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
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    internal partial class ConnectorMappingsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConnectorMappingsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConnectorMappingsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2017-04-26";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, ConnectorMappingResourceFormatData data)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/connectors/", false);
            uri.AppendPath(connectorName, true);
            uri.AppendPath("/mappings/", false);
            uri.AppendPath(mappingName, true);
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

        /// <summary> Creates a connector mapping or updates an existing connector mapping in the connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Connector Mapping operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/>, <paramref name="mappingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectorMappingResourceFormatData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, ConnectorMappingResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, hubName, connectorName, mappingName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ConnectorMappingResourceFormatData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectorMappingResourceFormatData.DeserializeConnectorMappingResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a connector mapping or updates an existing connector mapping in the connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Connector Mapping operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/>, <paramref name="mappingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectorMappingResourceFormatData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, ConnectorMappingResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, hubName, connectorName, mappingName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ConnectorMappingResourceFormatData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectorMappingResourceFormatData.DeserializeConnectorMappingResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/connectors/", false);
            uri.AppendPath(connectorName, true);
            uri.AppendPath("/mappings/", false);
            uri.AppendPath(mappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a connector mapping in the connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectorMappingResourceFormatData>> GetAsync(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, hubName, connectorName, mappingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectorMappingResourceFormatData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectorMappingResourceFormatData.DeserializeConnectorMappingResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ConnectorMappingResourceFormatData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a connector mapping in the connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectorMappingResourceFormatData> Get(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, hubName, connectorName, mappingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectorMappingResourceFormatData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectorMappingResourceFormatData.DeserializeConnectorMappingResourceFormatData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ConnectorMappingResourceFormatData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/connectors/", false);
            uri.AppendPath(connectorName, true);
            uri.AppendPath("/mappings/", false);
            uri.AppendPath(mappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a connector mapping in the connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, hubName, connectorName, mappingName);
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

        /// <summary> Deletes a connector mapping in the connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/>, <paramref name="connectorName"/> or <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string hubName, string connectorName, string mappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));
            Argument.AssertNotNullOrEmpty(mappingName, nameof(mappingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, hubName, connectorName, mappingName);
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

        internal HttpMessage CreateListByConnectorRequest(string subscriptionId, string resourceGroupName, string hubName, string connectorName)
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
            uri.AppendPath("/providers/Microsoft.CustomerInsights/hubs/", false);
            uri.AppendPath(hubName, true);
            uri.AppendPath("/connectors/", false);
            uri.AppendPath(connectorName, true);
            uri.AppendPath("/mappings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all the connector mappings in the specified connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectorMappingListResult>> ListByConnectorAsync(string subscriptionId, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));

            using var message = CreateListByConnectorRequest(subscriptionId, resourceGroupName, hubName, connectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectorMappingListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectorMappingListResult.DeserializeConnectorMappingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all the connector mappings in the specified connector. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectorMappingListResult> ListByConnector(string subscriptionId, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));

            using var message = CreateListByConnectorRequest(subscriptionId, resourceGroupName, hubName, connectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectorMappingListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectorMappingListResult.DeserializeConnectorMappingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByConnectorNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string hubName, string connectorName)
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

        /// <summary> Gets all the connector mappings in the specified connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectorMappingListResult>> ListByConnectorNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));

            using var message = CreateListByConnectorNextPageRequest(nextLink, subscriptionId, resourceGroupName, hubName, connectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectorMappingListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectorMappingListResult.DeserializeConnectorMappingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all the connector mappings in the specified connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="connectorName"> The name of the connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hubName"/> or <paramref name="connectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectorMappingListResult> ListByConnectorNextPage(string nextLink, string subscriptionId, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNullOrEmpty(connectorName, nameof(connectorName));

            using var message = CreateListByConnectorNextPageRequest(nextLink, subscriptionId, resourceGroupName, hubName, connectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectorMappingListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectorMappingListResult.DeserializeConnectorMappingListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}