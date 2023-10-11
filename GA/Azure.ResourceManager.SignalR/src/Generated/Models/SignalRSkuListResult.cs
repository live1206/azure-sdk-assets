// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> The list skus operation response. </summary>
    internal partial class SignalRSkuListResult
    {
        /// <summary> Initializes a new instance of SignalRSkuListResult. </summary>
        internal SignalRSkuListResult()
        {
            Value = new ChangeTrackingList<SignalRSku>();
        }

        /// <summary> Initializes a new instance of SignalRSkuListResult. </summary>
        /// <param name="value"> The list of skus available for the resource. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal SignalRSkuListResult(IReadOnlyList<SignalRSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of skus available for the resource. </summary>
        public IReadOnlyList<SignalRSku> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}