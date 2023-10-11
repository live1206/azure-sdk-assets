// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The metric dimension name and value. </summary>
    public partial class MonitorMetricSingleDimension
    {
        /// <summary> Initializes a new instance of MonitorMetricSingleDimension. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="value"> Value of the dimension. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        internal MonitorMetricSingleDimension(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> Name of the dimension. </summary>
        public string Name { get; }
        /// <summary> Value of the dimension. </summary>
        public string Value { get; }
    }
}