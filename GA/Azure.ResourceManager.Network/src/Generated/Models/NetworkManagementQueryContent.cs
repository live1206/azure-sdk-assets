// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Query Request Options. </summary>
    public partial class NetworkManagementQueryContent
    {
        /// <summary> Initializes a new instance of NetworkManagementQueryContent. </summary>
        public NetworkManagementQueryContent()
        {
        }

        /// <summary> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </summary>
        public string SkipToken { get; set; }
    }
}
