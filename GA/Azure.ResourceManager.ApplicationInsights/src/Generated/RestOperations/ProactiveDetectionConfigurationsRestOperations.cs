// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ApplicationInsights.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    internal partial class ProactiveDetectionConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ProactiveDetectionConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ProactiveDetectionConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2015-05-01";
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/ProactiveDetectionConfigs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of ProactiveDetection configurations of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<ApplicationInsightsComponentProactiveDetectionConfiguration>>> ListAsync(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
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
                        IReadOnlyList<ApplicationInsightsComponentProactiveDetectionConfiguration> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<ApplicationInsightsComponentProactiveDetectionConfiguration> array = new List<ApplicationInsightsComponentProactiveDetectionConfiguration>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ApplicationInsightsComponentProactiveDetectionConfiguration.DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of ProactiveDetection configurations of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<ApplicationInsightsComponentProactiveDetectionConfiguration>> List(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
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
                        IReadOnlyList<ApplicationInsightsComponentProactiveDetectionConfiguration> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<ApplicationInsightsComponentProactiveDetectionConfiguration> array = new List<ApplicationInsightsComponentProactiveDetectionConfiguration>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ApplicationInsightsComponentProactiveDetectionConfiguration.DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceName, string configurationId)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/ProactiveDetectionConfigs/", false);
            uri.AppendPath(configurationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the ProactiveDetection configuration for this configuration id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="configurationId"> The ProactiveDetection configuration ID. This is unique within a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="configurationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="configurationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ApplicationInsightsComponentProactiveDetectionConfiguration>> GetAsync(string subscriptionId, string resourceGroupName, string resourceName, string configurationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(configurationId, nameof(configurationId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, configurationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationInsightsComponentProactiveDetectionConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationInsightsComponentProactiveDetectionConfiguration.DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the ProactiveDetection configuration for this configuration id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="configurationId"> The ProactiveDetection configuration ID. This is unique within a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="configurationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="configurationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ApplicationInsightsComponentProactiveDetectionConfiguration> Get(string subscriptionId, string resourceGroupName, string resourceName, string configurationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(configurationId, nameof(configurationId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, configurationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationInsightsComponentProactiveDetectionConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationInsightsComponentProactiveDetectionConfiguration.DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string resourceName, string configurationId, ApplicationInsightsComponentProactiveDetectionConfiguration proactiveDetectionProperties)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/ProactiveDetectionConfigs/", false);
            uri.AppendPath(configurationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(proactiveDetectionProperties);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update the ProactiveDetection configuration for this configuration id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="configurationId"> The ProactiveDetection configuration ID. This is unique within a Application Insights component. </param>
        /// <param name="proactiveDetectionProperties"> Properties that need to be specified to update the ProactiveDetection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="configurationId"/> or <paramref name="proactiveDetectionProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="configurationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ApplicationInsightsComponentProactiveDetectionConfiguration>> UpdateAsync(string subscriptionId, string resourceGroupName, string resourceName, string configurationId, ApplicationInsightsComponentProactiveDetectionConfiguration proactiveDetectionProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(configurationId, nameof(configurationId));
            Argument.AssertNotNull(proactiveDetectionProperties, nameof(proactiveDetectionProperties));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, resourceName, configurationId, proactiveDetectionProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationInsightsComponentProactiveDetectionConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationInsightsComponentProactiveDetectionConfiguration.DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update the ProactiveDetection configuration for this configuration id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="configurationId"> The ProactiveDetection configuration ID. This is unique within a Application Insights component. </param>
        /// <param name="proactiveDetectionProperties"> Properties that need to be specified to update the ProactiveDetection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="configurationId"/> or <paramref name="proactiveDetectionProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="configurationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ApplicationInsightsComponentProactiveDetectionConfiguration> Update(string subscriptionId, string resourceGroupName, string resourceName, string configurationId, ApplicationInsightsComponentProactiveDetectionConfiguration proactiveDetectionProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(configurationId, nameof(configurationId));
            Argument.AssertNotNull(proactiveDetectionProperties, nameof(proactiveDetectionProperties));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, resourceName, configurationId, proactiveDetectionProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationInsightsComponentProactiveDetectionConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationInsightsComponentProactiveDetectionConfiguration.DeserializeApplicationInsightsComponentProactiveDetectionConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}