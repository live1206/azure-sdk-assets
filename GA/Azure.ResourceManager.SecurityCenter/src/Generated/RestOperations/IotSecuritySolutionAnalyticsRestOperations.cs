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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class IotSecuritySolutionAnalyticsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IotSecuritySolutionAnalyticsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IotSecuritySolutionAnalyticsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string solutionName)
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
            uri.AppendPath("/providers/Microsoft.Security/iotSecuritySolutions/", false);
            uri.AppendPath(solutionName, true);
            uri.AppendPath("/analyticsModels", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Use this method to get IoT security Analytics metrics in an array. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IotSecuritySolutionAnalyticsModelList>> ListAsync(string subscriptionId, string resourceGroupName, string solutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(solutionName, nameof(solutionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, solutionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotSecuritySolutionAnalyticsModelList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IotSecuritySolutionAnalyticsModelList.DeserializeIotSecuritySolutionAnalyticsModelList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Use this method to get IoT security Analytics metrics in an array. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IotSecuritySolutionAnalyticsModelList> List(string subscriptionId, string resourceGroupName, string solutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(solutionName, nameof(solutionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, solutionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotSecuritySolutionAnalyticsModelList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IotSecuritySolutionAnalyticsModelList.DeserializeIotSecuritySolutionAnalyticsModelList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string solutionName)
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
            uri.AppendPath("/providers/Microsoft.Security/iotSecuritySolutions/", false);
            uri.AppendPath(solutionName, true);
            uri.AppendPath("/analyticsModels/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Use this method to get IoT Security Analytics metrics. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IotSecuritySolutionAnalyticsModelData>> GetAsync(string subscriptionId, string resourceGroupName, string solutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(solutionName, nameof(solutionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, solutionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotSecuritySolutionAnalyticsModelData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IotSecuritySolutionAnalyticsModelData.DeserializeIotSecuritySolutionAnalyticsModelData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IotSecuritySolutionAnalyticsModelData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Use this method to get IoT Security Analytics metrics. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IotSecuritySolutionAnalyticsModelData> Get(string subscriptionId, string resourceGroupName, string solutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(solutionName, nameof(solutionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, solutionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotSecuritySolutionAnalyticsModelData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IotSecuritySolutionAnalyticsModelData.DeserializeIotSecuritySolutionAnalyticsModelData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IotSecuritySolutionAnalyticsModelData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}