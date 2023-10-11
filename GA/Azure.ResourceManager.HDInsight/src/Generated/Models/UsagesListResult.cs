// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The response for the operation to get regional usages for a subscription. </summary>
    internal partial class UsagesListResult
    {
        /// <summary> Initializes a new instance of UsagesListResult. </summary>
        internal UsagesListResult()
        {
            Value = new ChangeTrackingList<HDInsightUsage>();
        }

        /// <summary> Initializes a new instance of UsagesListResult. </summary>
        /// <param name="value"> The list of usages. </param>
        internal UsagesListResult(IReadOnlyList<HDInsightUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of usages. </summary>
        public IReadOnlyList<HDInsightUsage> Value { get; }
    }
}