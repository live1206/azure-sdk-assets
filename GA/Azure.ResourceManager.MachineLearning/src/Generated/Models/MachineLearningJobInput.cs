// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Command job definition.
    /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
    /// </summary>
    public abstract partial class MachineLearningJobInput
    {
        /// <summary> Initializes a new instance of MachineLearningJobInput. </summary>
        protected MachineLearningJobInput()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningJobInput. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        internal MachineLearningJobInput(string description, JobInputType jobInputType)
        {
            Description = description;
            JobInputType = jobInputType;
        }

        /// <summary> Description for the input. </summary>
        public string Description { get; set; }
        /// <summary> [Required] Specifies the type of job. </summary>
        internal JobInputType JobInputType { get; set; }
    }
}