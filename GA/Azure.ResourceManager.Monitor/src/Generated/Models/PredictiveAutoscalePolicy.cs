// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The parameters for enabling predictive autoscale. </summary>
    public partial class PredictiveAutoscalePolicy
    {
        /// <summary> Initializes a new instance of PredictiveAutoscalePolicy. </summary>
        /// <param name="scaleMode"> the predictive autoscale mode. </param>
        public PredictiveAutoscalePolicy(PredictiveAutoscalePolicyScaleMode scaleMode)
        {
            ScaleMode = scaleMode;
        }

        /// <summary> Initializes a new instance of PredictiveAutoscalePolicy. </summary>
        /// <param name="scaleMode"> the predictive autoscale mode. </param>
        /// <param name="scaleLookAheadTime"> the amount of time to specify by which instances are launched in advance. It must be between 1 minute and 60 minutes in ISO 8601 format. </param>
        internal PredictiveAutoscalePolicy(PredictiveAutoscalePolicyScaleMode scaleMode, TimeSpan? scaleLookAheadTime)
        {
            ScaleMode = scaleMode;
            ScaleLookAheadTime = scaleLookAheadTime;
        }

        /// <summary> the predictive autoscale mode. </summary>
        public PredictiveAutoscalePolicyScaleMode ScaleMode { get; set; }
        /// <summary> the amount of time to specify by which instances are launched in advance. It must be between 1 minute and 60 minutes in ISO 8601 format. </summary>
        public TimeSpan? ScaleLookAheadTime { get; set; }
    }
}