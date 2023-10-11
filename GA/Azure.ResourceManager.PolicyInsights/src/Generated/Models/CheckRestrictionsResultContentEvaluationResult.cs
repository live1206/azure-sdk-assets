// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Evaluation results for the provided partial resource content. </summary>
    internal partial class CheckRestrictionsResultContentEvaluationResult
    {
        /// <summary> Initializes a new instance of CheckRestrictionsResultContentEvaluationResult. </summary>
        internal CheckRestrictionsResultContentEvaluationResult()
        {
            PolicyEvaluations = new ChangeTrackingList<PolicyEvaluationResult>();
        }

        /// <summary> Initializes a new instance of CheckRestrictionsResultContentEvaluationResult. </summary>
        /// <param name="policyEvaluations"> Policy evaluation results against the given resource content. This will indicate if the partial content that was provided will be denied as-is. </param>
        internal CheckRestrictionsResultContentEvaluationResult(IReadOnlyList<PolicyEvaluationResult> policyEvaluations)
        {
            PolicyEvaluations = policyEvaluations;
        }

        /// <summary> Policy evaluation results against the given resource content. This will indicate if the partial content that was provided will be denied as-is. </summary>
        public IReadOnlyList<PolicyEvaluationResult> PolicyEvaluations { get; }
    }
}