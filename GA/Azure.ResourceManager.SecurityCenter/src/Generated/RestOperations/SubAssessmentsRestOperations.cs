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
    internal partial class SubAssessmentsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SubAssessmentsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SubAssessmentsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-01-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListAllRequest(string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Security/subAssessments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get security sub-assessments on all your scanned resources inside a subscription scope. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<SecuritySubAssessmentList>> ListAllAsync(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListAllRequest(scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get security sub-assessments on all your scanned resources inside a subscription scope. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<SecuritySubAssessmentList> ListAll(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListAllRequest(scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string scope, string assessmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendPath("/subAssessments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get security sub-assessments on all your scanned resources inside a scope. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecuritySubAssessmentList>> ListAsync(string scope, string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListRequest(scope, assessmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get security sub-assessments on all your scanned resources inside a scope. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecuritySubAssessmentList> List(string scope, string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListRequest(scope, assessmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string scope, string assessmentName, string subAssessmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Security/assessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendPath("/subAssessments/", false);
            uri.AppendPath(subAssessmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a security sub-assessment on your scanned resource. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="assessmentName"/> or <paramref name="subAssessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> or <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecuritySubAssessmentData>> GetAsync(string scope, string assessmentName, string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var message = CreateGetRequest(scope, assessmentName, subAssessmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecuritySubAssessmentData.DeserializeSecuritySubAssessmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecuritySubAssessmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a security sub-assessment on your scanned resource. </summary>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="assessmentName"/> or <paramref name="subAssessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> or <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecuritySubAssessmentData> Get(string scope, string assessmentName, string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var message = CreateGetRequest(scope, assessmentName, subAssessmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecuritySubAssessmentData.DeserializeSecuritySubAssessmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecuritySubAssessmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListAllNextPageRequest(string nextLink, string scope)
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

        /// <summary> Get security sub-assessments on all your scanned resources inside a subscription scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<SecuritySubAssessmentList>> ListAllNextPageAsync(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListAllNextPageRequest(nextLink, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get security sub-assessments on all your scanned resources inside a subscription scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<SecuritySubAssessmentList> ListAllNextPage(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListAllNextPageRequest(nextLink, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scope, string assessmentName)
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

        /// <summary> Get security sub-assessments on all your scanned resources inside a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="scope"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecuritySubAssessmentList>> ListNextPageAsync(string nextLink, string scope, string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListNextPageRequest(nextLink, scope, assessmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get security sub-assessments on all your scanned resources inside a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName). </param>
        /// <param name="assessmentName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="scope"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecuritySubAssessmentList> ListNextPage(string nextLink, string scope, string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListNextPageRequest(nextLink, scope, assessmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecuritySubAssessmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecuritySubAssessmentList.DeserializeSecuritySubAssessmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}