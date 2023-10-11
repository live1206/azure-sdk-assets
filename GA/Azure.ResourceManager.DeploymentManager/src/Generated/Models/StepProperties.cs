// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary>
    /// The properties of a step resource.
    /// Please note <see cref="StepProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="HealthCheckStepProperties"/> and <see cref="WaitStepProperties"/>.
    /// </summary>
    public abstract partial class StepProperties
    {
        /// <summary> Initializes a new instance of StepProperties. </summary>
        protected StepProperties()
        {
        }

        /// <summary> Initializes a new instance of StepProperties. </summary>
        /// <param name="stepType"> The type of step. </param>
        internal StepProperties(StepType stepType)
        {
            StepType = stepType;
        }

        /// <summary> The type of step. </summary>
        internal StepType StepType { get; set; }
    }
}