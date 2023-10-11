// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Security services list response. </summary>
    public partial class RulestackSecurityServiceListResult
    {
        /// <summary> Initializes a new instance of RulestackSecurityServiceListResult. </summary>
        /// <param name="value"> response value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RulestackSecurityServiceListResult(RulestackSecurityServiceTypeList value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of RulestackSecurityServiceListResult. </summary>
        /// <param name="value"> response value. </param>
        /// <param name="nextLink"> next link. </param>
        internal RulestackSecurityServiceListResult(RulestackSecurityServiceTypeList value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> response value. </summary>
        public RulestackSecurityServiceTypeList Value { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
    }
}