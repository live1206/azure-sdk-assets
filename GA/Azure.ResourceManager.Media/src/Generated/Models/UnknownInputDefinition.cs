// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The UnknownInputDefinition. </summary>
    internal partial class UnknownInputDefinition : MediaJobInputDefinition
    {
        /// <summary> Initializes a new instance of UnknownInputDefinition. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="includedTracks">
        /// The list of TrackDescriptors which define the metadata and selection of tracks in the input.
        /// Please note <see cref="TrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioTrackDescriptor"/>, <see cref="SelectAudioTrackByAttribute"/>, <see cref="SelectAudioTrackById"/>, <see cref="SelectVideoTrackByAttribute"/>, <see cref="SelectVideoTrackById"/> and <see cref="VideoTrackDescriptor"/>.
        /// </param>
        internal UnknownInputDefinition(string odataType, IList<TrackDescriptor> includedTracks) : base(odataType, includedTracks)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}