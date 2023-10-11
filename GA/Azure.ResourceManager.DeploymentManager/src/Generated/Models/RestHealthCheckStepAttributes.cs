// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Defines the REST health check step properties. </summary>
    public partial class RestHealthCheckStepAttributes : HealthCheckStepAttributes
    {
        /// <summary> Initializes a new instance of RestHealthCheckStepAttributes. </summary>
        /// <param name="healthyStateDuration"> The duration in ISO 8601 format for which the resource is expected to be continuously healthy. If maxElasticDuration is specified, healthy state duration is enforced after the detection of first healthy signal. </param>
        public RestHealthCheckStepAttributes(TimeSpan healthyStateDuration) : base(healthyStateDuration)
        {
            HealthChecks = new ChangeTrackingList<RestHealthCheck>();
            HealthCheckStepAttributesType = "REST";
        }

        /// <summary> Initializes a new instance of RestHealthCheckStepAttributes. </summary>
        /// <param name="healthCheckStepAttributesType"> The type of health check. </param>
        /// <param name="waitDuration"> The duration in ISO 8601 format for which health check waits idly without any checks. </param>
        /// <param name="maxElasticDuration"> The duration in ISO 8601 format for which the health check waits for the resource to become healthy. Health check fails if it doesn't. Health check starts to enforce healthyStateDuration once resource becomes healthy. </param>
        /// <param name="healthyStateDuration"> The duration in ISO 8601 format for which the resource is expected to be continuously healthy. If maxElasticDuration is specified, healthy state duration is enforced after the detection of first healthy signal. </param>
        /// <param name="healthChecks"> The list of checks that form the health check step. </param>
        internal RestHealthCheckStepAttributes(string healthCheckStepAttributesType, TimeSpan? waitDuration, TimeSpan? maxElasticDuration, TimeSpan healthyStateDuration, IList<RestHealthCheck> healthChecks) : base(healthCheckStepAttributesType, waitDuration, maxElasticDuration, healthyStateDuration)
        {
            HealthChecks = healthChecks;
            HealthCheckStepAttributesType = healthCheckStepAttributesType ?? "REST";
        }

        /// <summary> The list of checks that form the health check step. </summary>
        public IList<RestHealthCheck> HealthChecks { get; }
    }
}