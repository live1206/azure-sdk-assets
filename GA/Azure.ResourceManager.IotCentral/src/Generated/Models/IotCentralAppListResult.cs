// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotCentral;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> A list of IoT Central Applications with a next link. </summary>
    internal partial class IotCentralAppListResult
    {
        /// <summary> Initializes a new instance of IotCentralAppListResult. </summary>
        internal IotCentralAppListResult()
        {
            Value = new ChangeTrackingList<IotCentralAppData>();
        }

        /// <summary> Initializes a new instance of IotCentralAppListResult. </summary>
        /// <param name="nextLink"> The link used to get the next page of IoT Central Applications. </param>
        /// <param name="value"> A list of IoT Central Applications. </param>
        internal IotCentralAppListResult(string nextLink, IReadOnlyList<IotCentralAppData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of IoT Central Applications. </summary>
        public string NextLink { get; }
        /// <summary> A list of IoT Central Applications. </summary>
        public IReadOnlyList<IotCentralAppData> Value { get; }
    }
}