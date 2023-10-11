// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> List of Updates. </summary>
    internal partial class HciUpdateList
    {
        /// <summary> Initializes a new instance of HciUpdateList. </summary>
        internal HciUpdateList()
        {
            Value = new ChangeTrackingList<UpdateData>();
        }

        /// <summary> Initializes a new instance of HciUpdateList. </summary>
        /// <param name="value"> List of Updates. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal HciUpdateList(IReadOnlyList<UpdateData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Updates. </summary>
        public IReadOnlyList<UpdateData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}