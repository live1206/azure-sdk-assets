// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The retry history. </summary>
    public partial class LogicWorkRetryHistory
    {
        /// <summary> Initializes a new instance of LogicWorkRetryHistory. </summary>
        public LogicWorkRetryHistory()
        {
        }

        /// <summary> Initializes a new instance of LogicWorkRetryHistory. </summary>
        /// <param name="startOn"> Gets the start time. </param>
        /// <param name="endOn"> Gets the end time. </param>
        /// <param name="code"> Gets the status code. </param>
        /// <param name="clientRequestId"> Gets the client request Id. </param>
        /// <param name="serviceRequestId"> Gets the service request Id. </param>
        /// <param name="error"> Gets the error response. </param>
        internal LogicWorkRetryHistory(DateTimeOffset? startOn, DateTimeOffset? endOn, string code, string clientRequestId, string serviceRequestId, LogicErrorResponse error)
        {
            StartOn = startOn;
            EndOn = endOn;
            Code = code;
            ClientRequestId = clientRequestId;
            ServiceRequestId = serviceRequestId;
            Error = error;
        }

        /// <summary> Gets the start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Gets the end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Gets the status code. </summary>
        public string Code { get; set; }
        /// <summary> Gets the client request Id. </summary>
        public string ClientRequestId { get; set; }
        /// <summary> Gets the service request Id. </summary>
        public string ServiceRequestId { get; set; }
        /// <summary> Gets the error response. </summary>
        public LogicErrorResponse Error { get; set; }
    }
}