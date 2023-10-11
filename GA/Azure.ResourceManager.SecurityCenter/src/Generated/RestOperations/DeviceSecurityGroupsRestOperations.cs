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
    internal partial class DeviceSecurityGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DeviceSecurityGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DeviceSecurityGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string resourceId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/deviceSecurityGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Use this method get the list of device security groups for the specified IoT Hub resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public async Task<Response<DeviceSecurityGroupList>> ListAsync(string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListRequest(resourceId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceSecurityGroupList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceSecurityGroupList.DeserializeDeviceSecurityGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Use this method get the list of device security groups for the specified IoT Hub resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public Response<DeviceSecurityGroupList> List(string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListRequest(resourceId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceSecurityGroupList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceSecurityGroupList.DeserializeDeviceSecurityGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceId, string deviceSecurityGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/deviceSecurityGroups/", false);
            uri.AppendPath(deviceSecurityGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Use this method to get the device security group for the specified IoT Hub resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="deviceSecurityGroupName"> The name of the device security group. Note that the name of the device security group is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="deviceSecurityGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DeviceSecurityGroupData>> GetAsync(string resourceId, string deviceSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(deviceSecurityGroupName, nameof(deviceSecurityGroupName));

            using var message = CreateGetRequest(resourceId, deviceSecurityGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceSecurityGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceSecurityGroupData.DeserializeDeviceSecurityGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DeviceSecurityGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Use this method to get the device security group for the specified IoT Hub resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="deviceSecurityGroupName"> The name of the device security group. Note that the name of the device security group is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="deviceSecurityGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DeviceSecurityGroupData> Get(string resourceId, string deviceSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(deviceSecurityGroupName, nameof(deviceSecurityGroupName));

            using var message = CreateGetRequest(resourceId, deviceSecurityGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceSecurityGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceSecurityGroupData.DeserializeDeviceSecurityGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DeviceSecurityGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceId, string deviceSecurityGroupName, DeviceSecurityGroupData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/deviceSecurityGroups/", false);
            uri.AppendPath(deviceSecurityGroupName, true);
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

        /// <summary> Use this method to creates or updates the device security group on a specified IoT Hub resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="deviceSecurityGroupName"> The name of the device security group. Note that the name of the device security group is case insensitive. </param>
        /// <param name="data"> Security group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="deviceSecurityGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DeviceSecurityGroupData>> CreateOrUpdateAsync(string resourceId, string deviceSecurityGroupName, DeviceSecurityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(deviceSecurityGroupName, nameof(deviceSecurityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(resourceId, deviceSecurityGroupName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DeviceSecurityGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceSecurityGroupData.DeserializeDeviceSecurityGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Use this method to creates or updates the device security group on a specified IoT Hub resource. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="deviceSecurityGroupName"> The name of the device security group. Note that the name of the device security group is case insensitive. </param>
        /// <param name="data"> Security group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="deviceSecurityGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DeviceSecurityGroupData> CreateOrUpdate(string resourceId, string deviceSecurityGroupName, DeviceSecurityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(deviceSecurityGroupName, nameof(deviceSecurityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(resourceId, deviceSecurityGroupName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DeviceSecurityGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceSecurityGroupData.DeserializeDeviceSecurityGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceId, string deviceSecurityGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/deviceSecurityGroups/", false);
            uri.AppendPath(deviceSecurityGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> User this method to deletes the device security group. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="deviceSecurityGroupName"> The name of the device security group. Note that the name of the device security group is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="deviceSecurityGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string resourceId, string deviceSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(deviceSecurityGroupName, nameof(deviceSecurityGroupName));

            using var message = CreateDeleteRequest(resourceId, deviceSecurityGroupName);
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

        /// <summary> User this method to deletes the device security group. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="deviceSecurityGroupName"> The name of the device security group. Note that the name of the device security group is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="deviceSecurityGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deviceSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string resourceId, string deviceSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(deviceSecurityGroupName, nameof(deviceSecurityGroupName));

            using var message = CreateDeleteRequest(resourceId, deviceSecurityGroupName);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceId)
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

        /// <summary> Use this method get the list of device security groups for the specified IoT Hub resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceId"/> is null. </exception>
        public async Task<Response<DeviceSecurityGroupList>> ListNextPageAsync(string nextLink, string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListNextPageRequest(nextLink, resourceId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceSecurityGroupList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceSecurityGroupList.DeserializeDeviceSecurityGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Use this method get the list of device security groups for the specified IoT Hub resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceId"/> is null. </exception>
        public Response<DeviceSecurityGroupList> ListNextPage(string nextLink, string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListNextPageRequest(nextLink, resourceId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceSecurityGroupList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceSecurityGroupList.DeserializeDeviceSecurityGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}