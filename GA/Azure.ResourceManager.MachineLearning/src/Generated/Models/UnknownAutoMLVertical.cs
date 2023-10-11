// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownAutoMLVertical. </summary>
    internal partial class UnknownAutoMLVertical : AutoMLVertical
    {
        /// <summary> Initializes a new instance of UnknownAutoMLVertical. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        internal UnknownAutoMLVertical(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData) : base(logVerbosity, targetColumnName, taskType, trainingData)
        {
            TaskType = taskType;
        }
    }
}
