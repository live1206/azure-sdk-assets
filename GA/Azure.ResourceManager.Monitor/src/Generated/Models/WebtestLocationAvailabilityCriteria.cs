// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the metric alert rule criteria for a web test resource. </summary>
    public partial class WebtestLocationAvailabilityCriteria : MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of WebtestLocationAvailabilityCriteria. </summary>
        /// <param name="webTestId"> The Application Insights web test Id. </param>
        /// <param name="componentId"> The Application Insights resource Id. </param>
        /// <param name="failedLocationCount"> The number of failed locations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestId"/> or <paramref name="componentId"/> is null. </exception>
        public WebtestLocationAvailabilityCriteria(ResourceIdentifier webTestId, ResourceIdentifier componentId, float failedLocationCount)
        {
            Argument.AssertNotNull(webTestId, nameof(webTestId));
            Argument.AssertNotNull(componentId, nameof(componentId));

            WebTestId = webTestId;
            ComponentId = componentId;
            FailedLocationCount = failedLocationCount;
            OdataType = MonitorOdataType.MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria;
        }

        /// <summary> Initializes a new instance of WebtestLocationAvailabilityCriteria. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="webTestId"> The Application Insights web test Id. </param>
        /// <param name="componentId"> The Application Insights resource Id. </param>
        /// <param name="failedLocationCount"> The number of failed locations. </param>
        internal WebtestLocationAvailabilityCriteria(MonitorOdataType odataType, IDictionary<string, BinaryData> additionalProperties, ResourceIdentifier webTestId, ResourceIdentifier componentId, float failedLocationCount) : base(odataType, additionalProperties)
        {
            WebTestId = webTestId;
            ComponentId = componentId;
            FailedLocationCount = failedLocationCount;
            OdataType = odataType;
        }

        /// <summary> The Application Insights web test Id. </summary>
        public ResourceIdentifier WebTestId { get; set; }
        /// <summary> The Application Insights resource Id. </summary>
        public ResourceIdentifier ComponentId { get; set; }
        /// <summary> The number of failed locations. </summary>
        public float FailedLocationCount { get; set; }
    }
}