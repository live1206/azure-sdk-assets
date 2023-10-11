// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Country Description. </summary>
    public partial class RulestackCountry
    {
        /// <summary> Initializes a new instance of RulestackCountry. </summary>
        /// <param name="code"> country code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> is null. </exception>
        internal RulestackCountry(string code)
        {
            Argument.AssertNotNull(code, nameof(code));

            Code = code;
        }

        /// <summary> Initializes a new instance of RulestackCountry. </summary>
        /// <param name="code"> country code. </param>
        /// <param name="description"> code description. </param>
        internal RulestackCountry(string code, string description)
        {
            Code = code;
            Description = description;
        }

        /// <summary> country code. </summary>
        public string Code { get; }
        /// <summary> code description. </summary>
        public string Description { get; }
    }
}