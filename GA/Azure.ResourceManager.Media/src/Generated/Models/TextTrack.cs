// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents a text track in an asset. A text track is usually used for sparse data related to the audio or video tracks. </summary>
    public partial class TextTrack : MediaAssetTrackBase
    {
        /// <summary> Initializes a new instance of TextTrack. </summary>
        public TextTrack()
        {
            OdataType = "#Microsoft.Media.TextTrack";
        }

        /// <summary> Initializes a new instance of TextTrack. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="fileName"> The file name to the source file. This file is located in the storage container of the asset. </param>
        /// <param name="displayName"> The display name of the text track on a video player. In HLS, this maps to the NAME attribute of EXT-X-MEDIA. </param>
        /// <param name="languageCode"> The RFC5646 language code for the text track. </param>
        /// <param name="playerVisibility"> When PlayerVisibility is set to "Visible", the text track will be present in the DASH manifest or HLS playlist when requested by a client. When the PlayerVisibility is set to "Hidden", the text will not be available to the client. The default value is "Visible". </param>
        /// <param name="hlsSettings"> The HLS specific setting for the text track. </param>
        internal TextTrack(string odataType, string fileName, string displayName, string languageCode, PlayerVisibility? playerVisibility, HlsSettings hlsSettings) : base(odataType)
        {
            FileName = fileName;
            DisplayName = displayName;
            LanguageCode = languageCode;
            PlayerVisibility = playerVisibility;
            HlsSettings = hlsSettings;
            OdataType = odataType ?? "#Microsoft.Media.TextTrack";
        }

        /// <summary> The file name to the source file. This file is located in the storage container of the asset. </summary>
        public string FileName { get; set; }
        /// <summary> The display name of the text track on a video player. In HLS, this maps to the NAME attribute of EXT-X-MEDIA. </summary>
        public string DisplayName { get; set; }
        /// <summary> The RFC5646 language code for the text track. </summary>
        public string LanguageCode { get; }
        /// <summary> When PlayerVisibility is set to "Visible", the text track will be present in the DASH manifest or HLS playlist when requested by a client. When the PlayerVisibility is set to "Hidden", the text will not be available to the client. The default value is "Visible". </summary>
        public PlayerVisibility? PlayerVisibility { get; set; }
        /// <summary> The HLS specific setting for the text track. </summary>
        public HlsSettings HlsSettings { get; set; }
    }
}