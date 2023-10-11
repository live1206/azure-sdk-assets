// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The localizable string class. </summary>
    public partial class MonitorLocalizableString
    {
        /// <summary> Initializes a new instance of MonitorLocalizableString. </summary>
        /// <param name="value"> the invariant value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal MonitorLocalizableString(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of MonitorLocalizableString. </summary>
        /// <param name="value"> the invariant value. </param>
        /// <param name="localizedValue"> the locale specific value. </param>
        internal MonitorLocalizableString(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> the invariant value. </summary>
        public string Value { get; }
        /// <summary> the locale specific value. </summary>
        public string LocalizedValue { get; }
    }
}
