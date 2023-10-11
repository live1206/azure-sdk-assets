// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Error response of an operation failure. </summary>
    public partial class AutomationResponseError
    {
        /// <summary> Initializes a new instance of AutomationResponseError. </summary>
        public AutomationResponseError()
        {
        }

        /// <summary> Initializes a new instance of AutomationResponseError. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message indicating why the operation failed. </param>
        internal AutomationResponseError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; set; }
        /// <summary> Error message indicating why the operation failed. </summary>
        public string Message { get; set; }
    }
}