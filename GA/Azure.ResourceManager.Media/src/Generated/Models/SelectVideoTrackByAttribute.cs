// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Select video tracks from the input by specifying an attribute and an attribute filter. </summary>
    public partial class SelectVideoTrackByAttribute : VideoTrackDescriptor
    {
        /// <summary> Initializes a new instance of SelectVideoTrackByAttribute. </summary>
        /// <param name="attribute"> The TrackAttribute to filter the tracks by. </param>
        /// <param name="filter"> The type of AttributeFilter to apply to the TrackAttribute in order to select the tracks. </param>
        public SelectVideoTrackByAttribute(TrackAttribute attribute, TrackAttributeFilter filter)
        {
            Attribute = attribute;
            Filter = filter;
            OdataType = "#Microsoft.Media.SelectVideoTrackByAttribute";
        }

        /// <summary> Initializes a new instance of SelectVideoTrackByAttribute. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="attribute"> The TrackAttribute to filter the tracks by. </param>
        /// <param name="filter"> The type of AttributeFilter to apply to the TrackAttribute in order to select the tracks. </param>
        /// <param name="filterValue"> The value to filter the tracks by.  Only used when AttributeFilter.ValueEquals is specified for the Filter property. For TrackAttribute.Bitrate, this should be an integer value in bits per second (e.g: '1500000').  The TrackAttribute.Language is not supported for video tracks. </param>
        internal SelectVideoTrackByAttribute(string odataType, TrackAttribute attribute, TrackAttributeFilter filter, string filterValue) : base(odataType)
        {
            Attribute = attribute;
            Filter = filter;
            FilterValue = filterValue;
            OdataType = odataType ?? "#Microsoft.Media.SelectVideoTrackByAttribute";
        }

        /// <summary> The TrackAttribute to filter the tracks by. </summary>
        public TrackAttribute Attribute { get; set; }
        /// <summary> The type of AttributeFilter to apply to the TrackAttribute in order to select the tracks. </summary>
        public TrackAttributeFilter Filter { get; set; }
        /// <summary> The value to filter the tracks by.  Only used when AttributeFilter.ValueEquals is specified for the Filter property. For TrackAttribute.Bitrate, this should be an integer value in bits per second (e.g: '1500000').  The TrackAttribute.Language is not supported for video tracks. </summary>
        public string FilterValue { get; set; }
    }
}