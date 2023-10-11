// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The UnknownContentKeyPolicyPlayReadyContentKeyLocation. </summary>
    internal partial class UnknownContentKeyPolicyPlayReadyContentKeyLocation : ContentKeyPolicyPlayReadyContentKeyLocation
    {
        /// <summary> Initializes a new instance of UnknownContentKeyPolicyPlayReadyContentKeyLocation. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal UnknownContentKeyPolicyPlayReadyContentKeyLocation(string odataType) : base(odataType)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}