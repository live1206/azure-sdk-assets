// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SqlVirtualMachine;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> A list of SQL virtual machines. </summary>
    internal partial class SqlVmListResult
    {
        /// <summary> Initializes a new instance of SqlVmListResult. </summary>
        internal SqlVmListResult()
        {
            Value = new ChangeTrackingList<SqlVmData>();
        }

        /// <summary> Initializes a new instance of SqlVmListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SqlVmListResult(IReadOnlyList<SqlVmData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlVmData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}