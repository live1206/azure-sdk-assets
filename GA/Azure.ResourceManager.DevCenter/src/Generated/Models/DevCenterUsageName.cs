// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The Usage Names. </summary>
    public partial class DevCenterUsageName
    {
        /// <summary> Initializes a new instance of DevCenterUsageName. </summary>
        internal DevCenterUsageName()
        {
        }

        /// <summary> Initializes a new instance of DevCenterUsageName. </summary>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        /// <param name="value"> The name of the resource. </param>
        internal DevCenterUsageName(string localizedValue, string value)
        {
            LocalizedValue = localizedValue;
            Value = value;
        }

        /// <summary> The localized name of the resource. </summary>
        public string LocalizedValue { get; }
        /// <summary> The name of the resource. </summary>
        public string Value { get; }
    }
}