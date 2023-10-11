// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// A TrackSelection to select audio tracks.
    /// Please note <see cref="AudioTrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SelectAudioTrackByAttribute"/> and <see cref="SelectAudioTrackById"/>.
    /// </summary>
    public partial class AudioTrackDescriptor : TrackDescriptor
    {
        /// <summary> Initializes a new instance of AudioTrackDescriptor. </summary>
        public AudioTrackDescriptor()
        {
            OdataType = "#Microsoft.Media.AudioTrackDescriptor";
        }

        /// <summary> Initializes a new instance of AudioTrackDescriptor. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="channelMapping"> Optional designation for single channel audio tracks.  Can be used to combine the tracks into stereo or multi-channel audio tracks. </param>
        internal AudioTrackDescriptor(string odataType, ChannelMapping? channelMapping) : base(odataType)
        {
            ChannelMapping = channelMapping;
            OdataType = odataType ?? "#Microsoft.Media.AudioTrackDescriptor";
        }

        /// <summary> Optional designation for single channel audio tracks.  Can be used to combine the tracks into stereo or multi-channel audio tracks. </summary>
        public ChannelMapping? ChannelMapping { get; set; }
    }
}