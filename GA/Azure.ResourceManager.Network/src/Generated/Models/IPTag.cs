// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains the IpTag associated with the object. </summary>
    public partial class IPTag
    {
        /// <summary> Initializes a new instance of IPTag. </summary>
        public IPTag()
        {
        }

        /// <summary> Initializes a new instance of IPTag. </summary>
        /// <param name="ipTagType"> The IP tag type. Example: FirstPartyUsage. </param>
        /// <param name="tag"> The value of the IP tag associated with the public IP. Example: SQL. </param>
        internal IPTag(string ipTagType, string tag)
        {
            IPTagType = ipTagType;
            Tag = tag;
        }

        /// <summary> The IP tag type. Example: FirstPartyUsage. </summary>
        public string IPTagType { get; set; }
        /// <summary> The value of the IP tag associated with the public IP. Example: SQL. </summary>
        public string Tag { get; set; }
    }
}