// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The result of the sample input request. </summary>
    public partial class StreamAnalyticsSampleInputResult : StreamAnalyticsError
    {
        /// <summary> Initializes a new instance of StreamAnalyticsSampleInputResult. </summary>
        internal StreamAnalyticsSampleInputResult()
        {
            Diagnostics = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of StreamAnalyticsSampleInputResult. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="details"> Error details. </param>
        /// <param name="status"> The status of the sample input request. </param>
        /// <param name="diagnostics"> Diagnostics messages. E.g. message indicating some partitions from the input have no data. </param>
        /// <param name="eventsDownloadUri"> A SAS URL to download the sampled input data. </param>
        /// <param name="lastArrivedOn"> The timestamp for the last event in the data. It is in DateTime format. </param>
        internal StreamAnalyticsSampleInputResult(string code, string message, string target, IReadOnlyList<StreamAnalyticsErrorDetails> details, StreamAnalyticsSampleInputResultStatus? status, IReadOnlyList<string> diagnostics, Uri eventsDownloadUri, DateTimeOffset? lastArrivedOn) : base(code, message, target, details)
        {
            Status = status;
            Diagnostics = diagnostics;
            EventsDownloadUri = eventsDownloadUri;
            LastArrivedOn = lastArrivedOn;
        }

        /// <summary> The status of the sample input request. </summary>
        public StreamAnalyticsSampleInputResultStatus? Status { get; }
        /// <summary> Diagnostics messages. E.g. message indicating some partitions from the input have no data. </summary>
        public IReadOnlyList<string> Diagnostics { get; }
        /// <summary> A SAS URL to download the sampled input data. </summary>
        public Uri EventsDownloadUri { get; }
        /// <summary> The timestamp for the last event in the data. It is in DateTime format. </summary>
        public DateTimeOffset? LastArrivedOn { get; }
    }
}