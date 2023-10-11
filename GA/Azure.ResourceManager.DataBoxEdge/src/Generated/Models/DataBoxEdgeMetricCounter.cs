// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The metric counter. </summary>
    public partial class DataBoxEdgeMetricCounter
    {
        /// <summary> Initializes a new instance of DataBoxEdgeMetricCounter. </summary>
        /// <param name="name"> The counter name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataBoxEdgeMetricCounter(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            DimensionFilter = new ChangeTrackingList<DataBoxEdgeMetricDimension>();
            AdditionalDimensions = new ChangeTrackingList<DataBoxEdgeMetricDimension>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeMetricCounter. </summary>
        /// <param name="name"> The counter name. </param>
        /// <param name="instance"> The instance from which counter should be collected. </param>
        /// <param name="dimensionFilter"> The dimension filter. </param>
        /// <param name="additionalDimensions"> The additional dimensions to be added to metric. </param>
        internal DataBoxEdgeMetricCounter(string name, string instance, IList<DataBoxEdgeMetricDimension> dimensionFilter, IList<DataBoxEdgeMetricDimension> additionalDimensions)
        {
            Name = name;
            Instance = instance;
            DimensionFilter = dimensionFilter;
            AdditionalDimensions = additionalDimensions;
        }

        /// <summary> The counter name. </summary>
        public string Name { get; set; }
        /// <summary> The instance from which counter should be collected. </summary>
        public string Instance { get; set; }
        /// <summary> The dimension filter. </summary>
        public IList<DataBoxEdgeMetricDimension> DimensionFilter { get; }
        /// <summary> The additional dimensions to be added to metric. </summary>
        public IList<DataBoxEdgeMetricDimension> AdditionalDimensions { get; }
    }
}