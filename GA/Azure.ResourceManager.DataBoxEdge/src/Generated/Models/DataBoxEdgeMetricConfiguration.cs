// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Metric configuration. </summary>
    public partial class DataBoxEdgeMetricConfiguration
    {
        /// <summary> Initializes a new instance of DataBoxEdgeMetricConfiguration. </summary>
        /// <param name="resourceId"> The Resource ID on which the metrics should be pushed. </param>
        /// <param name="counterSets"> Host name for the IoT hub associated to the device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="counterSets"/> is null. </exception>
        public DataBoxEdgeMetricConfiguration(ResourceIdentifier resourceId, IEnumerable<DataBoxEdgeMetricCounterSet> counterSets)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNull(counterSets, nameof(counterSets));

            ResourceId = resourceId;
            CounterSets = counterSets.ToList();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeMetricConfiguration. </summary>
        /// <param name="resourceId"> The Resource ID on which the metrics should be pushed. </param>
        /// <param name="mdmAccount"> The MDM account to which the counters should be pushed. </param>
        /// <param name="metricNameSpace"> The MDM namespace to which the counters should be pushed. This is required if MDMAccount is specified. </param>
        /// <param name="counterSets"> Host name for the IoT hub associated to the device. </param>
        internal DataBoxEdgeMetricConfiguration(ResourceIdentifier resourceId, string mdmAccount, string metricNameSpace, IList<DataBoxEdgeMetricCounterSet> counterSets)
        {
            ResourceId = resourceId;
            MdmAccount = mdmAccount;
            MetricNameSpace = metricNameSpace;
            CounterSets = counterSets;
        }

        /// <summary> The Resource ID on which the metrics should be pushed. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The MDM account to which the counters should be pushed. </summary>
        public string MdmAccount { get; set; }
        /// <summary> The MDM namespace to which the counters should be pushed. This is required if MDMAccount is specified. </summary>
        public string MetricNameSpace { get; set; }
        /// <summary> Host name for the IoT hub associated to the device. </summary>
        public IList<DataBoxEdgeMetricCounterSet> CounterSets { get; }
    }
}