// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of Desktop definitions. </summary>
    internal partial class DesktopList
    {
        /// <summary> Initializes a new instance of DesktopList. </summary>
        internal DesktopList()
        {
            Value = new ChangeTrackingList<VirtualDesktopData>();
        }

        /// <summary> Initializes a new instance of DesktopList. </summary>
        /// <param name="value"> List of Desktop definitions. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal DesktopList(IReadOnlyList<VirtualDesktopData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Desktop definitions. </summary>
        public IReadOnlyList<VirtualDesktopData> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}