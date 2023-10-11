// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> List of EnabledResourceTypes definition. </summary>
    internal partial class CustomLocationEnabledResourceTypesResult
    {
        /// <summary> Initializes a new instance of CustomLocationEnabledResourceTypesResult. </summary>
        internal CustomLocationEnabledResourceTypesResult()
        {
            Value = new ChangeTrackingList<CustomLocationEnabledResourceType>();
        }

        /// <summary> Initializes a new instance of CustomLocationEnabledResourceTypesResult. </summary>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="value"> The list of EnabledResourceTypes available for a customLocation. </param>
        internal CustomLocationEnabledResourceTypesResult(string nextLink, IReadOnlyList<CustomLocationEnabledResourceType> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
        /// <summary> The list of EnabledResourceTypes available for a customLocation. </summary>
        public IReadOnlyList<CustomLocationEnabledResourceType> Value { get; }
    }
}