// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> An update to a SQL virtual machine. </summary>
    public partial class SqlVmPatch
    {
        /// <summary> Initializes a new instance of SqlVmPatch. </summary>
        public SqlVmPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}