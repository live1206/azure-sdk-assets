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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class WorkflowRunActionRequestHistoriesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkflowRunActionRequestHistoriesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkflowRunActionRequestHistoriesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName)
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
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/requestHistories", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List a workflow run request history. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowRequestHistoryListResult>> ListAsync(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRequestHistoryListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowRequestHistoryListResult.DeserializeLogicWorkflowRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List a workflow run request history. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowRequestHistoryListResult> List(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRequestHistoryListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicWorkflowRequestHistoryListResult.DeserializeLogicWorkflowRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string requestHistoryName)
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
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/requestHistories/", false);
            uri.AppendPath(requestHistoryName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a workflow run request history. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowRequestHistoryData>> GetAsync(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName, requestHistoryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRequestHistoryData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowRequestHistoryData.DeserializeLogicWorkflowRequestHistoryData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((LogicWorkflowRequestHistoryData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a workflow run request history. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowRequestHistoryData> Get(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName, requestHistoryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRequestHistoryData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicWorkflowRequestHistoryData.DeserializeLogicWorkflowRequestHistoryData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((LogicWorkflowRequestHistoryData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName)
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

        /// <summary> List a workflow run request history. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowRequestHistoryListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workflowName, runName, actionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRequestHistoryListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowRequestHistoryListResult.DeserializeLogicWorkflowRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List a workflow run request history. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowRequestHistoryListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workflowName, runName, actionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRequestHistoryListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicWorkflowRequestHistoryListResult.DeserializeLogicWorkflowRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}