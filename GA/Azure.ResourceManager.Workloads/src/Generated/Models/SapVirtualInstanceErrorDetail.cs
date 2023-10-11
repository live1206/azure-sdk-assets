// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Error definition. </summary>
    public partial class SapVirtualInstanceErrorDetail
    {
        /// <summary> Initializes a new instance of SapVirtualInstanceErrorDetail. </summary>
        internal SapVirtualInstanceErrorDetail()
        {
            Details = new ChangeTrackingList<SapVirtualInstanceErrorDetail>();
        }

        /// <summary> Initializes a new instance of SapVirtualInstanceErrorDetail. </summary>
        /// <param name="code"> Service specific error code which serves as the substatus for the HTTP error code. </param>
        /// <param name="message"> Description of the error. </param>
        /// <param name="details"> Internal error details. </param>
        internal SapVirtualInstanceErrorDetail(string code, string message, IReadOnlyList<SapVirtualInstanceErrorDetail> details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary> Service specific error code which serves as the substatus for the HTTP error code. </summary>
        public string Code { get; }
        /// <summary> Description of the error. </summary>
        public string Message { get; }
        /// <summary> Internal error details. </summary>
        public IReadOnlyList<SapVirtualInstanceErrorDetail> Details { get; }
    }
}