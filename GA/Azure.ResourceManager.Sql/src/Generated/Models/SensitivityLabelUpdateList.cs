// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of sensitivity label update operations. </summary>
    public partial class SensitivityLabelUpdateList
    {
        /// <summary> Initializes a new instance of SensitivityLabelUpdateList. </summary>
        public SensitivityLabelUpdateList()
        {
            Operations = new ChangeTrackingList<SensitivityLabelUpdate>();
        }

        /// <summary> Gets the operations. </summary>
        public IList<SensitivityLabelUpdate> Operations { get; }
    }
}