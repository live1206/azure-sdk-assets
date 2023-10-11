// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container Apps Job Secrets Collection ARM resource. </summary>
    internal partial class JobSecretsCollection
    {
        /// <summary> Initializes a new instance of JobSecretsCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal JobSecretsCollection(IEnumerable<ContainerAppWritableSecret> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of JobSecretsCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        internal JobSecretsCollection(IReadOnlyList<ContainerAppWritableSecret> value)
        {
            Value = value;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<ContainerAppWritableSecret> Value { get; }
    }
}