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
    internal partial class ReservationsSummariesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReservationsSummariesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReservationsSummariesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByReservationOrderRequest(string reservationOrderId, ReservationSummaryDataGrain grain, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationorders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationSummaries", false);
            uri.AppendQuery("grain", grain.ToString(), true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderAsync(string reservationOrderId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateListByReservationOrderRequest(reservationOrderId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrder(string reservationOrderId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateListByReservationOrderRequest(reservationOrderId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderAndReservationRequest(string reservationOrderId, string reservationId, ReservationSummaryDataGrain grain, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationorders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/reservations/", false);
            uri.AppendPath(reservationId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationSummaries", false);
            uri.AppendQuery("grain", grain.ToString(), true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderAndReservationAsync(string reservationOrderId, string reservationId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));

            using var message = CreateListByReservationOrderAndReservationRequest(reservationOrderId, reservationId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrderAndReservation(string reservationOrderId, string reservationId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));

            using var message = CreateListByReservationOrderAndReservationRequest(reservationOrderId, reservationId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceScope, ReservationSummaryDataGrain grain, string startDate, string endDate, string filter, string reservationId, string reservationOrderId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationSummaries", false);
            uri.AppendQuery("grain", grain.ToString(), true);
            if (startDate != null)
            {
                uri.AppendQuery("startDate", startDate, true);
            }
            if (endDate != null)
            {
                uri.AppendQuery("endDate", endDate, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (reservationId != null)
            {
                uri.AppendQuery("reservationId", reservationId, true);
            }
            if (reservationOrderId != null)
            {
                uri.AppendQuery("reservationOrderId", reservationOrderId, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="resourceScope"> The scope associated with reservations summaries operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListAsync(string resourceScope, ReservationSummaryDataGrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListRequest(resourceScope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="resourceScope"> The scope associated with reservations summaries operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> is null. </exception>
        public Response<ReservationSummariesListResult> List(string resourceScope, ReservationSummaryDataGrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListRequest(resourceScope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderNextPageRequest(string nextLink, string reservationOrderId, ReservationSummaryDataGrain grain, string filter)
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

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderNextPageAsync(string nextLink, string reservationOrderId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateListByReservationOrderNextPageRequest(nextLink, reservationOrderId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrderNextPage(string nextLink, string reservationOrderId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateListByReservationOrderNextPageRequest(nextLink, reservationOrderId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderAndReservationNextPageRequest(string nextLink, string reservationOrderId, string reservationId, ReservationSummaryDataGrain grain, string filter)
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

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListByReservationOrderAndReservationNextPageAsync(string nextLink, string reservationOrderId, string reservationId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));

            using var message = CreateListByReservationOrderAndReservationNextPageRequest(nextLink, reservationOrderId, reservationId, grain, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations summaries for daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationSummariesListResult> ListByReservationOrderAndReservationNextPage(string nextLink, string reservationOrderId, string reservationId, ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));

            using var message = CreateListByReservationOrderAndReservationNextPageRequest(nextLink, reservationOrderId, reservationId, grain, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceScope, ReservationSummaryDataGrain grain, string startDate, string endDate, string filter, string reservationId, string reservationOrderId)
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

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope associated with reservations summaries operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceScope"/> is null. </exception>
        public async Task<Response<ReservationSummariesListResult>> ListNextPageAsync(string nextLink, string resourceScope, ReservationSummaryDataGrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListNextPageRequest(nextLink, resourceScope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations summaries for the defined scope daily or monthly grain. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope associated with reservations summaries operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceScope"/> is null. </exception>
        public Response<ReservationSummariesListResult> ListNextPage(string nextLink, string resourceScope, ReservationSummaryDataGrain grain, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListNextPageRequest(nextLink, resourceScope, grain, startDate, endDate, filter, reservationId, reservationOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationSummariesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationSummariesListResult.DeserializeReservationSummariesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}