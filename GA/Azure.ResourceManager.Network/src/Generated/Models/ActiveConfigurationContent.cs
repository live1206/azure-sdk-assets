// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Effective Virtual Networks Parameter. </summary>
    public partial class ActiveConfigurationContent
    {
        /// <summary> Initializes a new instance of ActiveConfigurationContent. </summary>
        public ActiveConfigurationContent()
        {
            Regions = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> List of regions. </summary>
        public IList<AzureLocation> Regions { get; }
        /// <summary> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </summary>
        public string SkipToken { get; set; }
    }
}