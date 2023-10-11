// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The HLS setting for a track. </summary>
    public partial class HlsSettings
    {
        /// <summary> Initializes a new instance of HlsSettings. </summary>
        public HlsSettings()
        {
        }

        /// <summary> Initializes a new instance of HlsSettings. </summary>
        /// <param name="isDefault"> The default for the HLS setting. </param>
        /// <param name="isForced"> The forced for the HLS setting. </param>
        /// <param name="characteristics"> The characteristics for the HLS setting. </param>
        internal HlsSettings(bool? isDefault, bool? isForced, string characteristics)
        {
            IsDefault = isDefault;
            IsForced = isForced;
            Characteristics = characteristics;
        }

        /// <summary> The default for the HLS setting. </summary>
        public bool? IsDefault { get; set; }
        /// <summary> The forced for the HLS setting. </summary>
        public bool? IsForced { get; set; }
        /// <summary> The characteristics for the HLS setting. </summary>
        public string Characteristics { get; set; }
    }
}