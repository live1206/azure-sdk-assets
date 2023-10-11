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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    internal partial class EncryptionScopesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of EncryptionScopesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public EncryptionScopesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreatePutRequest(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScopeData data)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/encryptionScopes/", false);
            uri.AppendPath(encryptionScopeName, true);
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

        /// <summary> Synchronously creates or updates an encryption scope under the specified storage account. If an encryption scope is already created and a subsequent request is issued with different properties, the encryption scope properties will be updated per the specified request. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="data"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="encryptionScopeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EncryptionScopeData>> PutAsync(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePutRequest(subscriptionId, resourceGroupName, accountName, encryptionScopeName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        EncryptionScopeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EncryptionScopeData.DeserializeEncryptionScopeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Synchronously creates or updates an encryption scope under the specified storage account. If an encryption scope is already created and a subsequent request is issued with different properties, the encryption scope properties will be updated per the specified request. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="data"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="encryptionScopeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EncryptionScopeData> Put(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePutRequest(subscriptionId, resourceGroupName, accountName, encryptionScopeName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        EncryptionScopeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EncryptionScopeData.DeserializeEncryptionScopeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePatchRequest(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScopeData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/encryptionScopes/", false);
            uri.AppendPath(encryptionScopeName, true);
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

        /// <summary> Update encryption scope properties as specified in the request body. Update fails if the specified encryption scope does not already exist. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="data"> Encryption scope properties to be used for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="encryptionScopeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EncryptionScopeData>> PatchAsync(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePatchRequest(subscriptionId, resourceGroupName, accountName, encryptionScopeName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EncryptionScopeData.DeserializeEncryptionScopeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update encryption scope properties as specified in the request body. Update fails if the specified encryption scope does not already exist. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="data"> Encryption scope properties to be used for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="encryptionScopeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EncryptionScopeData> Patch(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePatchRequest(subscriptionId, resourceGroupName, accountName, encryptionScopeName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EncryptionScopeData.DeserializeEncryptionScopeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/encryptionScopes/", false);
            uri.AppendPath(encryptionScopeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns the properties for the specified encryption scope. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EncryptionScopeData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, encryptionScopeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EncryptionScopeData.DeserializeEncryptionScopeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((EncryptionScopeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the properties for the specified encryption scope. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="encryptionScopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EncryptionScopeData> Get(string subscriptionId, string resourceGroupName, string accountName, string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(encryptionScopeName, nameof(encryptionScopeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, encryptionScopeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EncryptionScopeData.DeserializeEncryptionScopeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((EncryptionScopeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string accountName, int? maxpagesize, string filter, EncryptionScopesIncludeType? include)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/encryptionScopes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", maxpagesize.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (include != null)
            {
                uri.AppendQuery("$include", include.Value.ToString(), true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of encryption scopes that will be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, only encryption scope names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, when specified, will list encryption scopes with the specific state. Defaults to All. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EncryptionScopeListResult>> ListAsync(string subscriptionId, string resourceGroupName, string accountName, int? maxpagesize = null, string filter = null, EncryptionScopesIncludeType? include = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, maxpagesize, filter, include);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EncryptionScopeListResult.DeserializeEncryptionScopeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of encryption scopes that will be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, only encryption scope names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, when specified, will list encryption scopes with the specific state. Defaults to All. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EncryptionScopeListResult> List(string subscriptionId, string resourceGroupName, string accountName, int? maxpagesize = null, string filter = null, EncryptionScopesIncludeType? include = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, maxpagesize, filter, include);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EncryptionScopeListResult.DeserializeEncryptionScopeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, int? maxpagesize, string filter, EncryptionScopesIncludeType? include)
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

        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of encryption scopes that will be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, only encryption scope names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, when specified, will list encryption scopes with the specific state. Defaults to All. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EncryptionScopeListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, int? maxpagesize = null, string filter = null, EncryptionScopesIncludeType? include = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, maxpagesize, filter, include);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EncryptionScopeListResult.DeserializeEncryptionScopeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of encryption scopes that will be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, only encryption scope names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, when specified, will list encryption scopes with the specific state. Defaults to All. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EncryptionScopeListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, int? maxpagesize = null, string filter = null, EncryptionScopesIncludeType? include = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, maxpagesize, filter, include);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EncryptionScopeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EncryptionScopeListResult.DeserializeEncryptionScopeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}