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
using Azure.ResourceManager.DataProtectionBackup.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    internal partial class JobsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of JobsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public JobsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string vaultName)
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
            uri.AppendPath("/providers/Microsoft.DataProtection/backupVaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupJobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns list of jobs belonging to a backup vault. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureBackupJobResourceList>> ListAsync(string subscriptionId, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vaultName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupJobResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureBackupJobResourceList.DeserializeAzureBackupJobResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns list of jobs belonging to a backup vault. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureBackupJobResourceList> List(string subscriptionId, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vaultName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupJobResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureBackupJobResourceList.DeserializeAzureBackupJobResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vaultName, string jobId)
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
            uri.AppendPath("/providers/Microsoft.DataProtection/backupVaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupJobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a job with id in a backup vault. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="jobId"> The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataProtectionBackupJobData>> GetAsync(string subscriptionId, string resourceGroupName, string vaultName, string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, jobId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataProtectionBackupJobData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataProtectionBackupJobData.DeserializeDataProtectionBackupJobData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataProtectionBackupJobData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a job with id in a backup vault. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="jobId"> The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataProtectionBackupJobData> Get(string subscriptionId, string resourceGroupName, string vaultName, string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, jobId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataProtectionBackupJobData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataProtectionBackupJobData.DeserializeDataProtectionBackupJobData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataProtectionBackupJobData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string vaultName)
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

        /// <summary> Returns list of jobs belonging to a backup vault. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureBackupJobResourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, vaultName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupJobResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureBackupJobResourceList.DeserializeAzureBackupJobResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns list of jobs belonging to a backup vault. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureBackupJobResourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, vaultName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupJobResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureBackupJobResourceList.DeserializeAzureBackupJobResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}