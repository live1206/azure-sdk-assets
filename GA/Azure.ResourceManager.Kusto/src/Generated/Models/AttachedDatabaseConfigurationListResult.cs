// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list attached database configurations operation response. </summary>
    internal partial class AttachedDatabaseConfigurationListResult
    {
        /// <summary> Initializes a new instance of AttachedDatabaseConfigurationListResult. </summary>
        internal AttachedDatabaseConfigurationListResult()
        {
            Value = new ChangeTrackingList<KustoAttachedDatabaseConfigurationData>();
        }

        /// <summary> Initializes a new instance of AttachedDatabaseConfigurationListResult. </summary>
        /// <param name="value"> The list of attached database configurations. </param>
        internal AttachedDatabaseConfigurationListResult(IReadOnlyList<KustoAttachedDatabaseConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> The list of attached database configurations. </summary>
        public IReadOnlyList<KustoAttachedDatabaseConfigurationData> Value { get; }
    }
}