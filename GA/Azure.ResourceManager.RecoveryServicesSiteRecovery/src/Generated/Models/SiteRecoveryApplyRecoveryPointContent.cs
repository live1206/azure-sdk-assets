// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input to apply recovery point. </summary>
    public partial class SiteRecoveryApplyRecoveryPointContent
    {
        /// <summary> Initializes a new instance of SiteRecoveryApplyRecoveryPointContent. </summary>
        /// <param name="properties"> The input properties to apply recovery point. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryApplyRecoveryPointContent(SiteRecoveryApplyRecoveryPointProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> The input properties to apply recovery point. </summary>
        public SiteRecoveryApplyRecoveryPointProperties Properties { get; }
    }
}