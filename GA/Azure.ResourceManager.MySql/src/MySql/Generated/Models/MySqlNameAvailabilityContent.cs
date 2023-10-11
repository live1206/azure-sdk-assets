// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Request from client to check resource name availability. </summary>
    public partial class MySqlNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of MySqlNameAvailabilityContent. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MySqlNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Resource name to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
