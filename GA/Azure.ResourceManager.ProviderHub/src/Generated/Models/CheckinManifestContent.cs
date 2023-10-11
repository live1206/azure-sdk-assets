// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckinManifestContent. </summary>
    public partial class CheckinManifestContent
    {
        /// <summary> Initializes a new instance of CheckinManifestContent. </summary>
        /// <param name="environment"> The environment supplied to the checkin manifest operation. </param>
        /// <param name="baselineArmManifestLocation"> The baseline ARM manifest location supplied to the checkin manifest operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environment"/> is null. </exception>
        public CheckinManifestContent(string environment, AzureLocation baselineArmManifestLocation)
        {
            Argument.AssertNotNull(environment, nameof(environment));

            Environment = environment;
            BaselineArmManifestLocation = baselineArmManifestLocation;
        }

        /// <summary> The environment supplied to the checkin manifest operation. </summary>
        public string Environment { get; }
        /// <summary> The baseline ARM manifest location supplied to the checkin manifest operation. </summary>
        public AzureLocation BaselineArmManifestLocation { get; }
    }
}