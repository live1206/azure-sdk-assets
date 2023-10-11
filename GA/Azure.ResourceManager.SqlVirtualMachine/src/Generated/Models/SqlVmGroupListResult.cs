// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SqlVirtualMachine;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> A list of SQL virtual machine groups. </summary>
    internal partial class SqlVmGroupListResult
    {
        /// <summary> Initializes a new instance of SqlVmGroupListResult. </summary>
        internal SqlVmGroupListResult()
        {
            Value = new ChangeTrackingList<SqlVmGroupData>();
        }

        /// <summary> Initializes a new instance of SqlVmGroupListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SqlVmGroupListResult(IReadOnlyList<SqlVmGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlVmGroupData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}