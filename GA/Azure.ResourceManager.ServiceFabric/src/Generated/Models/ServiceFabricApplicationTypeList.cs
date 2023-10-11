// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of application type names. </summary>
    internal partial class ServiceFabricApplicationTypeList
    {
        /// <summary> Initializes a new instance of ServiceFabricApplicationTypeList. </summary>
        internal ServiceFabricApplicationTypeList()
        {
            Value = new ChangeTrackingList<ServiceFabricApplicationTypeData>();
        }

        /// <summary> Initializes a new instance of ServiceFabricApplicationTypeList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of application type list results if there are any. </param>
        internal ServiceFabricApplicationTypeList(IReadOnlyList<ServiceFabricApplicationTypeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceFabricApplicationTypeData> Value { get; }
        /// <summary> URL to get the next set of application type list results if there are any. </summary>
        public string NextLink { get; }
    }
}