// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> OS option property. </summary>
    public partial class ContainerServiceOSOptionProperty
    {
        /// <summary> Initializes a new instance of ContainerServiceOSOptionProperty. </summary>
        /// <param name="osType"> The OS type. </param>
        /// <param name="enableFipsImage"> Whether the image is FIPS-enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osType"/> is null. </exception>
        internal ContainerServiceOSOptionProperty(string osType, bool enableFipsImage)
        {
            Argument.AssertNotNull(osType, nameof(osType));

            OSType = osType;
            EnableFipsImage = enableFipsImage;
        }

        /// <summary> The OS type. </summary>
        public string OSType { get; }
        /// <summary> Whether the image is FIPS-enabled. </summary>
        public bool EnableFipsImage { get; }
    }
}
