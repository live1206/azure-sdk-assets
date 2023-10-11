// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Address properties. </summary>
    public partial class SourceAddressInfo
    {
        /// <summary> Initializes a new instance of SourceAddressInfo. </summary>
        public SourceAddressInfo()
        {
            Cidrs = new ChangeTrackingList<string>();
            Countries = new ChangeTrackingList<string>();
            Feeds = new ChangeTrackingList<string>();
            PrefixLists = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SourceAddressInfo. </summary>
        /// <param name="cidrs"> special value 'any'. </param>
        /// <param name="countries"> list of countries. </param>
        /// <param name="feeds"> list of feeds. </param>
        /// <param name="prefixLists"> prefix list. </param>
        internal SourceAddressInfo(IList<string> cidrs, IList<string> countries, IList<string> feeds, IList<string> prefixLists)
        {
            Cidrs = cidrs;
            Countries = countries;
            Feeds = feeds;
            PrefixLists = prefixLists;
        }

        /// <summary> special value 'any'. </summary>
        public IList<string> Cidrs { get; }
        /// <summary> list of countries. </summary>
        public IList<string> Countries { get; }
        /// <summary> list of feeds. </summary>
        public IList<string> Feeds { get; }
        /// <summary> prefix list. </summary>
        public IList<string> PrefixLists { get; }
    }
}