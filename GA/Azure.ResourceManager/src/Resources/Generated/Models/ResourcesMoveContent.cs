// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Parameters of move resources. </summary>
    public partial class ResourcesMoveContent
    {
        /// <summary> Initializes a new instance of ResourcesMoveContent. </summary>
        public ResourcesMoveContent()
        {
            Resources = new ChangeTrackingList<string>();
        }

        /// <summary> The IDs of the resources. </summary>
        public IList<string> Resources { get; }
        /// <summary> The target resource group. </summary>
        public ResourceIdentifier TargetResourceGroupId { get; set; }
    }
}
