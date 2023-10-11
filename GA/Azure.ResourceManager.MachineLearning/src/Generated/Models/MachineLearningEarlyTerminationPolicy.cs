// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Early termination policies enable canceling poor-performing runs before they complete
    /// Please note <see cref="MachineLearningEarlyTerminationPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BanditPolicy"/>, <see cref="MedianStoppingPolicy"/> and <see cref="TruncationSelectionPolicy"/>.
    /// </summary>
    public abstract partial class MachineLearningEarlyTerminationPolicy
    {
        /// <summary> Initializes a new instance of MachineLearningEarlyTerminationPolicy. </summary>
        protected MachineLearningEarlyTerminationPolicy()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningEarlyTerminationPolicy. </summary>
        /// <param name="delayEvaluation"> Number of intervals by which to delay the first evaluation. </param>
        /// <param name="evaluationInterval"> Interval (number of runs) between policy evaluations. </param>
        /// <param name="policyType"> [Required] Name of policy configuration. </param>
        internal MachineLearningEarlyTerminationPolicy(int? delayEvaluation, int? evaluationInterval, EarlyTerminationPolicyType policyType)
        {
            DelayEvaluation = delayEvaluation;
            EvaluationInterval = evaluationInterval;
            PolicyType = policyType;
        }

        /// <summary> Number of intervals by which to delay the first evaluation. </summary>
        public int? DelayEvaluation { get; set; }
        /// <summary> Interval (number of runs) between policy evaluations. </summary>
        public int? EvaluationInterval { get; set; }
        /// <summary> [Required] Name of policy configuration. </summary>
        internal EarlyTerminationPolicyType PolicyType { get; set; }
    }
}
