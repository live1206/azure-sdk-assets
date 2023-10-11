// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes a parameter in fabric settings of the cluster. </summary>
    public partial class SettingsParameterDescription
    {
        /// <summary> Initializes a new instance of SettingsParameterDescription. </summary>
        /// <param name="name"> The parameter name of fabric setting. </param>
        /// <param name="value"> The parameter value of fabric setting. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public SettingsParameterDescription(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> The parameter name of fabric setting. </summary>
        public string Name { get; set; }
        /// <summary> The parameter value of fabric setting. </summary>
        public string Value { get; set; }
    }
}
