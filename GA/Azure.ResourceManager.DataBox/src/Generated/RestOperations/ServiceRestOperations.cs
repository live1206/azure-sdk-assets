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
using Azure.ResourceManager.DataBox.Models;

namespace Azure.ResourceManager.DataBox
{
    internal partial class ServiceRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ServiceRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ServiceRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListAvailableSkusByResourceGroupRequest(string subscriptionId, string resourceGroupName, AzureLocation location, AvailableSkusContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBox/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/availableSkus", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This method provides the list of available skus for the given subscription, resource group and location. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvailableSkusResult>> ListAvailableSkusByResourceGroupAsync(string subscriptionId, string resourceGroupName, AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateListAvailableSkusByResourceGroupRequest(subscriptionId, resourceGroupName, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailableSkusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailableSkusResult.DeserializeAvailableSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method provides the list of available skus for the given subscription, resource group and location. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvailableSkusResult> ListAvailableSkusByResourceGroup(string subscriptionId, string resourceGroupName, AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateListAvailableSkusByResourceGroupRequest(subscriptionId, resourceGroupName, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailableSkusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailableSkusResult.DeserializeAvailableSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidateAddressRequest(string subscriptionId, AzureLocation location, DataBoxValidateAddressContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DataBox/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/validateAddress", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AddressValidationOutput>> ValidateAddressAsync(string subscriptionId, AzureLocation location, DataBoxValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateValidateAddressRequest(subscriptionId, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddressValidationOutput value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AddressValidationOutput.DeserializeAddressValidationOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AddressValidationOutput> ValidateAddress(string subscriptionId, AzureLocation location, DataBoxValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateValidateAddressRequest(subscriptionId, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddressValidationOutput value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AddressValidationOutput.DeserializeAddressValidationOutput(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidateInputsByResourceGroupRequest(string subscriptionId, string resourceGroupName, AzureLocation location, DataBoxValidationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBox/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/validateInputs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This method does all necessary pre-job creation validation under resource group. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataBoxValidationResult>> ValidateInputsByResourceGroupAsync(string subscriptionId, string resourceGroupName, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateValidateInputsByResourceGroupRequest(subscriptionId, resourceGroupName, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataBoxValidationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataBoxValidationResult.DeserializeDataBoxValidationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method does all necessary pre-job creation validation under resource group. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataBoxValidationResult> ValidateInputsByResourceGroup(string subscriptionId, string resourceGroupName, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateValidateInputsByResourceGroupRequest(subscriptionId, resourceGroupName, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataBoxValidationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataBoxValidationResult.DeserializeDataBoxValidationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateValidateInputsRequest(string subscriptionId, AzureLocation location, DataBoxValidationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DataBox/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/validateInputs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This method does all necessary pre-job creation validation under subscription. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataBoxValidationResult>> ValidateInputsAsync(string subscriptionId, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateValidateInputsRequest(subscriptionId, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataBoxValidationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataBoxValidationResult.DeserializeDataBoxValidationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method does all necessary pre-job creation validation under subscription. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataBoxValidationResult> ValidateInputs(string subscriptionId, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateValidateInputsRequest(subscriptionId, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataBoxValidationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataBoxValidationResult.DeserializeDataBoxValidationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRegionConfigurationRequest(string subscriptionId, AzureLocation location, RegionConfigurationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DataBox/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/regionConfiguration", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This API provides configuration details specific to given region/location at Subscription level. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RegionConfigurationResult>> RegionConfigurationAsync(string subscriptionId, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRegionConfigurationRequest(subscriptionId, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegionConfigurationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RegionConfigurationResult.DeserializeRegionConfigurationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This API provides configuration details specific to given region/location at Subscription level. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RegionConfigurationResult> RegionConfiguration(string subscriptionId, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRegionConfigurationRequest(subscriptionId, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegionConfigurationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RegionConfigurationResult.DeserializeRegionConfigurationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRegionConfigurationByResourceGroupRequest(string subscriptionId, string resourceGroupName, AzureLocation location, RegionConfigurationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataBox/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/regionConfiguration", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This API provides configuration details specific to given region/location at Resource group level. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RegionConfigurationResult>> RegionConfigurationByResourceGroupAsync(string subscriptionId, string resourceGroupName, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRegionConfigurationByResourceGroupRequest(subscriptionId, resourceGroupName, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegionConfigurationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RegionConfigurationResult.DeserializeRegionConfigurationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This API provides configuration details specific to given region/location at Resource group level. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RegionConfigurationResult> RegionConfigurationByResourceGroup(string subscriptionId, string resourceGroupName, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateRegionConfigurationByResourceGroupRequest(subscriptionId, resourceGroupName, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegionConfigurationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RegionConfigurationResult.DeserializeRegionConfigurationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListAvailableSkusByResourceGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, AzureLocation location, AvailableSkusContent content)
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

        /// <summary> This method provides the list of available skus for the given subscription, resource group and location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvailableSkusResult>> ListAvailableSkusByResourceGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateListAvailableSkusByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailableSkusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailableSkusResult.DeserializeAvailableSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method provides the list of available skus for the given subscription, resource group and location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvailableSkusResult> ListAvailableSkusByResourceGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateListAvailableSkusByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailableSkusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailableSkusResult.DeserializeAvailableSkusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}