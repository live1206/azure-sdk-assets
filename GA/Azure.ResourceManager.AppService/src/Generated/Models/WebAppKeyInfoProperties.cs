// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Properties of function key info. </summary>
    public partial class WebAppKeyInfoProperties
    {
        /// <summary> Initializes a new instance of WebAppKeyInfoProperties. </summary>
        public WebAppKeyInfoProperties()
        {
        }

        /// <summary> Initializes a new instance of WebAppKeyInfoProperties. </summary>
        /// <param name="name"> Key name. </param>
        /// <param name="value"> Key value. </param>
        internal WebAppKeyInfoProperties(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Key name. </summary>
        public string Name { get; set; }
        /// <summary> Key value. </summary>
        public string Value { get; set; }
    }
}