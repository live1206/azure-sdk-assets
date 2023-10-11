// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Input to get top query statistics. </summary>
    public partial class MySqlTopQueryStatisticsInput
    {
        /// <summary> Initializes a new instance of MySqlTopQueryStatisticsInput. </summary>
        /// <param name="numberOfTopQueries"> Max number of top queries to return. </param>
        /// <param name="aggregationFunction"> Aggregation function name. </param>
        /// <param name="observedMetric"> Observed metric name. </param>
        /// <param name="observationStartOn"> Observation start time. </param>
        /// <param name="observationEndOn"> Observation end time. </param>
        /// <param name="aggregationWindow"> Aggregation interval type in ISO 8601 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregationFunction"/>, <paramref name="observedMetric"/> or <paramref name="aggregationWindow"/> is null. </exception>
        public MySqlTopQueryStatisticsInput(int numberOfTopQueries, string aggregationFunction, string observedMetric, DateTimeOffset observationStartOn, DateTimeOffset observationEndOn, string aggregationWindow)
        {
            Argument.AssertNotNull(aggregationFunction, nameof(aggregationFunction));
            Argument.AssertNotNull(observedMetric, nameof(observedMetric));
            Argument.AssertNotNull(aggregationWindow, nameof(aggregationWindow));

            NumberOfTopQueries = numberOfTopQueries;
            AggregationFunction = aggregationFunction;
            ObservedMetric = observedMetric;
            ObservationStartOn = observationStartOn;
            ObservationEndOn = observationEndOn;
            AggregationWindow = aggregationWindow;
        }

        /// <summary> Max number of top queries to return. </summary>
        public int NumberOfTopQueries { get; }
        /// <summary> Aggregation function name. </summary>
        public string AggregationFunction { get; }
        /// <summary> Observed metric name. </summary>
        public string ObservedMetric { get; }
        /// <summary> Observation start time. </summary>
        public DateTimeOffset ObservationStartOn { get; }
        /// <summary> Observation end time. </summary>
        public DateTimeOffset ObservationEndOn { get; }
        /// <summary> Aggregation interval type in ISO 8601 format. </summary>
        public string AggregationWindow { get; }
    }
}