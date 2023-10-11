// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes Compute Resource Usage. </summary>
    public partial class ComputeUsage
    {
        /// <summary> Initializes a new instance of ComputeUsage. </summary>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name of the type of usage. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal ComputeUsage(int currentValue, long limit, ComputeUsageName name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Unit = ComputeUsageUnit.Count;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Initializes a new instance of ComputeUsage. </summary>
        /// <param name="unit"> An enum describing the unit of usage measurement. </param>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name of the type of usage. </param>
        internal ComputeUsage(ComputeUsageUnit unit, int currentValue, long limit, ComputeUsageName name)
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> An enum describing the unit of usage measurement. </summary>
        public ComputeUsageUnit Unit { get; }
        /// <summary> The current usage of the resource. </summary>
        public int CurrentValue { get; }
        /// <summary> The maximum permitted usage of the resource. </summary>
        public long Limit { get; }
        /// <summary> The name of the type of usage. </summary>
        public ComputeUsageName Name { get; }
    }
}