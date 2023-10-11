// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningInferenceContainerProperties. </summary>
    public partial class MachineLearningInferenceContainerProperties
    {
        /// <summary> Initializes a new instance of MachineLearningInferenceContainerProperties. </summary>
        public MachineLearningInferenceContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningInferenceContainerProperties. </summary>
        /// <param name="livenessRoute"> The route to check the liveness of the inference server container. </param>
        /// <param name="readinessRoute"> The route to check the readiness of the inference server container. </param>
        /// <param name="scoringRoute"> The port to send the scoring requests to, within the inference server container. </param>
        internal MachineLearningInferenceContainerProperties(MachineLearningInferenceContainerRoute livenessRoute, MachineLearningInferenceContainerRoute readinessRoute, MachineLearningInferenceContainerRoute scoringRoute)
        {
            LivenessRoute = livenessRoute;
            ReadinessRoute = readinessRoute;
            ScoringRoute = scoringRoute;
        }

        /// <summary> The route to check the liveness of the inference server container. </summary>
        public MachineLearningInferenceContainerRoute LivenessRoute { get; set; }
        /// <summary> The route to check the readiness of the inference server container. </summary>
        public MachineLearningInferenceContainerRoute ReadinessRoute { get; set; }
        /// <summary> The port to send the scoring requests to, within the inference server container. </summary>
        public MachineLearningInferenceContainerRoute ScoringRoute { get; set; }
    }
}
