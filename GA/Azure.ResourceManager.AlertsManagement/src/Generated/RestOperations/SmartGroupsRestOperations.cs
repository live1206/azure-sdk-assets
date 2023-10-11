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
using Azure.ResourceManager.AlertsManagement.Models;

namespace Azure.ResourceManager.AlertsManagement
{
    internal partial class SmartGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SmartGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SmartGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-05-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetAllRequest(string subscriptionId, string targetResource, string targetResourceGroup, string targetResourceType, MonitorServiceSourceForAlert? monitorService, MonitorCondition? monitorCondition, ServiceAlertSeverity? severity, ServiceAlertState? smartGroupState, TimeRangeFilter? timeRange, long? pageCount, SmartGroupsSortByField? sortBy, AlertsManagementQuerySortOrder? sortOrder)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AlertsManagement/smartGroups", false);
            if (targetResource != null)
            {
                uri.AppendQuery("targetResource", targetResource, true);
            }
            if (targetResourceGroup != null)
            {
                uri.AppendQuery("targetResourceGroup", targetResourceGroup, true);
            }
            if (targetResourceType != null)
            {
                uri.AppendQuery("targetResourceType", targetResourceType, true);
            }
            if (monitorService != null)
            {
                uri.AppendQuery("monitorService", monitorService.Value.ToString(), true);
            }
            if (monitorCondition != null)
            {
                uri.AppendQuery("monitorCondition", monitorCondition.Value.ToString(), true);
            }
            if (severity != null)
            {
                uri.AppendQuery("severity", severity.Value.ToString(), true);
            }
            if (smartGroupState != null)
            {
                uri.AppendQuery("smartGroupState", smartGroupState.Value.ToString(), true);
            }
            if (timeRange != null)
            {
                uri.AppendQuery("timeRange", timeRange.Value.ToString(), true);
            }
            if (pageCount != null)
            {
                uri.AppendQuery("pageCount", pageCount.Value, true);
            }
            if (sortBy != null)
            {
                uri.AppendQuery("sortBy", sortBy.Value.ToString(), true);
            }
            if (sortOrder != null)
            {
                uri.AppendQuery("sortOrder", sortOrder.Value.ToString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all the Smart Groups within a specified subscription. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="targetResource"> Filter by target resource( which is full ARM ID) Default value is select all. </param>
        /// <param name="targetResourceGroup"> Filter by target resource group name. Default value is select all. </param>
        /// <param name="targetResourceType"> Filter by target resource type. Default value is select all. </param>
        /// <param name="monitorService"> Filter by monitor service which generates the alert instance. Default value is select all. </param>
        /// <param name="monitorCondition"> Filter by monitor condition which is either 'Fired' or 'Resolved'. Default value is to select all. </param>
        /// <param name="severity"> Filter by severity.  Default value is select all. </param>
        /// <param name="smartGroupState"> Filter by state of the smart group. Default value is to select all. </param>
        /// <param name="timeRange"> Filter by time range by below listed values. Default value is 1 day. </param>
        /// <param name="pageCount"> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the "includeContent"  filter is selected, maximum value allowed is 25. Default value is 25. </param>
        /// <param name="sortBy"> Sort the query results by input field. Default value is sort by 'lastModifiedDateTime'. </param>
        /// <param name="sortOrder"> Sort the query results order in either ascending or descending.  Default value is 'desc' for time fields and 'asc' for others. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SmartGroupsList>> GetAllAsync(string subscriptionId, string targetResource = null, string targetResourceGroup = null, string targetResourceType = null, MonitorServiceSourceForAlert? monitorService = null, MonitorCondition? monitorCondition = null, ServiceAlertSeverity? severity = null, ServiceAlertState? smartGroupState = null, TimeRangeFilter? timeRange = null, long? pageCount = null, SmartGroupsSortByField? sortBy = null, AlertsManagementQuerySortOrder? sortOrder = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetAllRequest(subscriptionId, targetResource, targetResourceGroup, targetResourceType, monitorService, monitorCondition, severity, smartGroupState, timeRange, pageCount, sortBy, sortOrder);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SmartGroupsList.DeserializeSmartGroupsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all the Smart Groups within a specified subscription. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="targetResource"> Filter by target resource( which is full ARM ID) Default value is select all. </param>
        /// <param name="targetResourceGroup"> Filter by target resource group name. Default value is select all. </param>
        /// <param name="targetResourceType"> Filter by target resource type. Default value is select all. </param>
        /// <param name="monitorService"> Filter by monitor service which generates the alert instance. Default value is select all. </param>
        /// <param name="monitorCondition"> Filter by monitor condition which is either 'Fired' or 'Resolved'. Default value is to select all. </param>
        /// <param name="severity"> Filter by severity.  Default value is select all. </param>
        /// <param name="smartGroupState"> Filter by state of the smart group. Default value is to select all. </param>
        /// <param name="timeRange"> Filter by time range by below listed values. Default value is 1 day. </param>
        /// <param name="pageCount"> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the "includeContent"  filter is selected, maximum value allowed is 25. Default value is 25. </param>
        /// <param name="sortBy"> Sort the query results by input field. Default value is sort by 'lastModifiedDateTime'. </param>
        /// <param name="sortOrder"> Sort the query results order in either ascending or descending.  Default value is 'desc' for time fields and 'asc' for others. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SmartGroupsList> GetAll(string subscriptionId, string targetResource = null, string targetResourceGroup = null, string targetResourceType = null, MonitorServiceSourceForAlert? monitorService = null, MonitorCondition? monitorCondition = null, ServiceAlertSeverity? severity = null, ServiceAlertState? smartGroupState = null, TimeRangeFilter? timeRange = null, long? pageCount = null, SmartGroupsSortByField? sortBy = null, AlertsManagementQuerySortOrder? sortOrder = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetAllRequest(subscriptionId, targetResource, targetResourceGroup, targetResourceType, monitorService, monitorCondition, severity, smartGroupState, timeRange, pageCount, sortBy, sortOrder);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SmartGroupsList.DeserializeSmartGroupsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetByIdRequest(string subscriptionId, Guid smartGroupId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AlertsManagement/smartGroups/", false);
            uri.AppendPath(smartGroupId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get information related to a specific Smart Group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SmartGroupData>> GetByIdAsync(string subscriptionId, Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetByIdRequest(subscriptionId, smartGroupId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SmartGroupData.DeserializeSmartGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SmartGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get information related to a specific Smart Group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SmartGroupData> GetById(string subscriptionId, Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetByIdRequest(subscriptionId, smartGroupId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SmartGroupData.DeserializeSmartGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SmartGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateChangeStateRequest(string subscriptionId, Guid smartGroupId, ServiceAlertState newState)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AlertsManagement/smartGroups/", false);
            uri.AppendPath(smartGroupId, true);
            uri.AppendPath("/changeState", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("newState", newState.ToString(), true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Change the state of a Smart Group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="newState"> New state of the alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SmartGroupData>> ChangeStateAsync(string subscriptionId, Guid smartGroupId, ServiceAlertState newState, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateChangeStateRequest(subscriptionId, smartGroupId, newState);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SmartGroupData.DeserializeSmartGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Change the state of a Smart Group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="newState"> New state of the alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SmartGroupData> ChangeState(string subscriptionId, Guid smartGroupId, ServiceAlertState newState, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateChangeStateRequest(subscriptionId, smartGroupId, newState);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SmartGroupData.DeserializeSmartGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetHistoryRequest(string subscriptionId, Guid smartGroupId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.AlertsManagement/smartGroups/", false);
            uri.AppendPath(smartGroupId, true);
            uri.AppendPath("/history", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the history a smart group, which captures any Smart Group state changes (New/Acknowledged/Closed) . </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SmartGroupModification>> GetHistoryAsync(string subscriptionId, Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetHistoryRequest(subscriptionId, smartGroupId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupModification value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SmartGroupModification.DeserializeSmartGroupModification(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the history a smart group, which captures any Smart Group state changes (New/Acknowledged/Closed) . </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="smartGroupId"> Smart group unique id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SmartGroupModification> GetHistory(string subscriptionId, Guid smartGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetHistoryRequest(subscriptionId, smartGroupId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupModification value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SmartGroupModification.DeserializeSmartGroupModification(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string subscriptionId, string targetResource, string targetResourceGroup, string targetResourceType, MonitorServiceSourceForAlert? monitorService, MonitorCondition? monitorCondition, ServiceAlertSeverity? severity, ServiceAlertState? smartGroupState, TimeRangeFilter? timeRange, long? pageCount, SmartGroupsSortByField? sortBy, AlertsManagementQuerySortOrder? sortOrder)
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

        /// <summary> List all the Smart Groups within a specified subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="targetResource"> Filter by target resource( which is full ARM ID) Default value is select all. </param>
        /// <param name="targetResourceGroup"> Filter by target resource group name. Default value is select all. </param>
        /// <param name="targetResourceType"> Filter by target resource type. Default value is select all. </param>
        /// <param name="monitorService"> Filter by monitor service which generates the alert instance. Default value is select all. </param>
        /// <param name="monitorCondition"> Filter by monitor condition which is either 'Fired' or 'Resolved'. Default value is to select all. </param>
        /// <param name="severity"> Filter by severity.  Default value is select all. </param>
        /// <param name="smartGroupState"> Filter by state of the smart group. Default value is to select all. </param>
        /// <param name="timeRange"> Filter by time range by below listed values. Default value is 1 day. </param>
        /// <param name="pageCount"> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the "includeContent"  filter is selected, maximum value allowed is 25. Default value is 25. </param>
        /// <param name="sortBy"> Sort the query results by input field. Default value is sort by 'lastModifiedDateTime'. </param>
        /// <param name="sortOrder"> Sort the query results order in either ascending or descending.  Default value is 'desc' for time fields and 'asc' for others. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SmartGroupsList>> GetAllNextPageAsync(string nextLink, string subscriptionId, string targetResource = null, string targetResourceGroup = null, string targetResourceType = null, MonitorServiceSourceForAlert? monitorService = null, MonitorCondition? monitorCondition = null, ServiceAlertSeverity? severity = null, ServiceAlertState? smartGroupState = null, TimeRangeFilter? timeRange = null, long? pageCount = null, SmartGroupsSortByField? sortBy = null, AlertsManagementQuerySortOrder? sortOrder = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetAllNextPageRequest(nextLink, subscriptionId, targetResource, targetResourceGroup, targetResourceType, monitorService, monitorCondition, severity, smartGroupState, timeRange, pageCount, sortBy, sortOrder);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SmartGroupsList.DeserializeSmartGroupsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all the Smart Groups within a specified subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="targetResource"> Filter by target resource( which is full ARM ID) Default value is select all. </param>
        /// <param name="targetResourceGroup"> Filter by target resource group name. Default value is select all. </param>
        /// <param name="targetResourceType"> Filter by target resource type. Default value is select all. </param>
        /// <param name="monitorService"> Filter by monitor service which generates the alert instance. Default value is select all. </param>
        /// <param name="monitorCondition"> Filter by monitor condition which is either 'Fired' or 'Resolved'. Default value is to select all. </param>
        /// <param name="severity"> Filter by severity.  Default value is select all. </param>
        /// <param name="smartGroupState"> Filter by state of the smart group. Default value is to select all. </param>
        /// <param name="timeRange"> Filter by time range by below listed values. Default value is 1 day. </param>
        /// <param name="pageCount"> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the "includeContent"  filter is selected, maximum value allowed is 25. Default value is 25. </param>
        /// <param name="sortBy"> Sort the query results by input field. Default value is sort by 'lastModifiedDateTime'. </param>
        /// <param name="sortOrder"> Sort the query results order in either ascending or descending.  Default value is 'desc' for time fields and 'asc' for others. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SmartGroupsList> GetAllNextPage(string nextLink, string subscriptionId, string targetResource = null, string targetResourceGroup = null, string targetResourceType = null, MonitorServiceSourceForAlert? monitorService = null, MonitorCondition? monitorCondition = null, ServiceAlertSeverity? severity = null, ServiceAlertState? smartGroupState = null, TimeRangeFilter? timeRange = null, long? pageCount = null, SmartGroupsSortByField? sortBy = null, AlertsManagementQuerySortOrder? sortOrder = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateGetAllNextPageRequest(nextLink, subscriptionId, targetResource, targetResourceGroup, targetResourceType, monitorService, monitorCondition, severity, smartGroupState, timeRange, pageCount, sortBy, sortOrder);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SmartGroupsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SmartGroupsList.DeserializeSmartGroupsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}