// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> The properties that define a step. </summary>
    public partial class PrePostStep
    {
        /// <summary> Initializes a new instance of PrePostStep. </summary>
        /// <param name="stepId"> The resource Id of the step to be run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepId"/> is null. </exception>
        public PrePostStep(string stepId)
        {
            Argument.AssertNotNull(stepId, nameof(stepId));

            StepId = stepId;
        }

        /// <summary> The resource Id of the step to be run. </summary>
        public string StepId { get; set; }
    }
}