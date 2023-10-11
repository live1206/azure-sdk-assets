// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Collection of Storage for Environments. </summary>
    internal partial class ManagedEnvironmentStoragesCollection
    {
        /// <summary> Initializes a new instance of ManagedEnvironmentStoragesCollection. </summary>
        /// <param name="value"> Collection of storage resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ManagedEnvironmentStoragesCollection(IEnumerable<ContainerAppManagedEnvironmentStorageData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ManagedEnvironmentStoragesCollection. </summary>
        /// <param name="value"> Collection of storage resources. </param>
        internal ManagedEnvironmentStoragesCollection(IReadOnlyList<ContainerAppManagedEnvironmentStorageData> value)
        {
            Value = value;
        }

        /// <summary> Collection of storage resources. </summary>
        public IReadOnlyList<ContainerAppManagedEnvironmentStorageData> Value { get; }
    }
}