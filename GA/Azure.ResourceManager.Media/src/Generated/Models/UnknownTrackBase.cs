// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The UnknownTrackBase. </summary>
    internal partial class UnknownTrackBase : MediaAssetTrackBase
    {
        /// <summary> Initializes a new instance of UnknownTrackBase. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal UnknownTrackBase(string odataType) : base(odataType)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}