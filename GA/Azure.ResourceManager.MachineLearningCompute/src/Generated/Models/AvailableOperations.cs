// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Available operation list. </summary>
    internal partial class AvailableOperations
    {
        /// <summary> Initializes a new instance of AvailableOperations. </summary>
        internal AvailableOperations()
        {
            Value = new ChangeTrackingList<ResourceOperation>();
        }

        /// <summary> Initializes a new instance of AvailableOperations. </summary>
        /// <param name="value"> An array of available operations. </param>
        internal AvailableOperations(IReadOnlyList<ResourceOperation> value)
        {
            Value = value;
        }

        /// <summary> An array of available operations. </summary>
        public IReadOnlyList<ResourceOperation> Value { get; }
    }
}