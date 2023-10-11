// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Error details. </summary>
    public partial class ServiceErrorDetail
    {
        /// <summary> Initializes a new instance of ServiceErrorDetail. </summary>
        internal ServiceErrorDetail()
        {
        }

        /// <summary> Initializes a new instance of ServiceErrorDetail. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        internal ServiceErrorDetail(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
    }
}
