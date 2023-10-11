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
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    internal partial class LotsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of LotsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public LotsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByBillingProfileRequest(string billingAccountId, string billingProfileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingProfiles/", false);
            uri.AppendPath(billingProfileId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/lots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all Azure credits for a billing account or a billing profile. The API is only supported for Microsoft Customer Agreements (MCA) billing accounts. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Lots>> ListByBillingProfileAsync(string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));

            using var message = CreateListByBillingProfileRequest(billingAccountId, billingProfileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Azure credits for a billing account or a billing profile. The API is only supported for Microsoft Customer Agreements (MCA) billing accounts. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Lots> ListByBillingProfile(string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));

            using var message = CreateListByBillingProfileRequest(billingAccountId, billingProfileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBillingAccountRequest(string billingAccountId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/lots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all Microsoft Azure consumption commitments for a billing account. The API is only supported for Microsoft Customer Agreements (MCA) and Direct Enterprise Agreement (EA)  billing accounts. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Lots>> ListByBillingAccountAsync(string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountRequest(billingAccountId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Microsoft Azure consumption commitments for a billing account. The API is only supported for Microsoft Customer Agreements (MCA) and Direct Enterprise Agreement (EA)  billing accounts. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Lots> ListByBillingAccount(string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountRequest(billingAccountId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByCustomerRequest(string billingAccountId, string customerId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/customers/", false);
            uri.AppendPath(customerId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/lots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all Azure credits for a customer. The API is only supported for Microsoft Partner  Agreements (MPA) billing accounts. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="customerId"> Customer ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="customerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="customerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Lots>> ListByCustomerAsync(string billingAccountId, string customerId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(customerId, nameof(customerId));

            using var message = CreateListByCustomerRequest(billingAccountId, customerId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Azure credits for a customer. The API is only supported for Microsoft Partner  Agreements (MPA) billing accounts. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="customerId"> Customer ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="customerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="customerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Lots> ListByCustomer(string billingAccountId, string customerId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(customerId, nameof(customerId));

            using var message = CreateListByCustomerRequest(billingAccountId, customerId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBillingProfileNextPageRequest(string nextLink, string billingAccountId, string billingProfileId)
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

        /// <summary> Lists all Azure credits for a billing account or a billing profile. The API is only supported for Microsoft Customer Agreements (MCA) billing accounts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Lots>> ListByBillingProfileNextPageAsync(string nextLink, string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));

            using var message = CreateListByBillingProfileNextPageRequest(nextLink, billingAccountId, billingProfileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Azure credits for a billing account or a billing profile. The API is only supported for Microsoft Customer Agreements (MCA) billing accounts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Lots> ListByBillingProfileNextPage(string nextLink, string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingProfileId, nameof(billingProfileId));

            using var message = CreateListByBillingProfileNextPageRequest(nextLink, billingAccountId, billingProfileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBillingAccountNextPageRequest(string nextLink, string billingAccountId, string filter)
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

        /// <summary> Lists all Microsoft Azure consumption commitments for a billing account. The API is only supported for Microsoft Customer Agreements (MCA) and Direct Enterprise Agreement (EA)  billing accounts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Lots>> ListByBillingAccountNextPageAsync(string nextLink, string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Microsoft Azure consumption commitments for a billing account. The API is only supported for Microsoft Customer Agreements (MCA) and Direct Enterprise Agreement (EA)  billing accounts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Lots> ListByBillingAccountNextPage(string nextLink, string billingAccountId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByCustomerNextPageRequest(string nextLink, string billingAccountId, string customerId, string filter)
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

        /// <summary> Lists all Azure credits for a customer. The API is only supported for Microsoft Partner  Agreements (MPA) billing accounts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="customerId"> Customer ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/> or <paramref name="customerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="customerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Lots>> ListByCustomerNextPageAsync(string nextLink, string billingAccountId, string customerId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(customerId, nameof(customerId));

            using var message = CreateListByCustomerNextPageRequest(nextLink, billingAccountId, customerId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all Azure credits for a customer. The API is only supported for Microsoft Partner  Agreements (MPA) billing accounts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="customerId"> Customer ID. </param>
        /// <param name="filter"> May be used to filter the lots by Status, Source etc. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. Tag filter is a key value pair string where key and value is separated by a colon (:). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="billingAccountId"/> or <paramref name="customerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="customerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Lots> ListByCustomerNextPage(string nextLink, string billingAccountId, string customerId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(customerId, nameof(customerId));

            using var message = CreateListByCustomerNextPageRequest(nextLink, billingAccountId, customerId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Lots value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Lots.DeserializeLots(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}