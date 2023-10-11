// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> HTTPHeader describes a custom header to be used in HTTP probes. </summary>
    public partial class ContainerAppHttpHeaderInfo
    {
        /// <summary> Initializes a new instance of ContainerAppHttpHeaderInfo. </summary>
        /// <param name="name"> The header field name. </param>
        /// <param name="value"> The header field value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public ContainerAppHttpHeaderInfo(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> The header field name. </summary>
        public string Name { get; set; }
        /// <summary> The header field value. </summary>
        public string Value { get; set; }
    }
}