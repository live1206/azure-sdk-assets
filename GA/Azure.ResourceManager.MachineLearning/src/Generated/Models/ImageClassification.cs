// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Image Classification. Multi-class image classification is used when an image is classified with only a single label
    /// from a set of classes - e.g. each image is classified as either an image of a 'cat' or a 'dog' or a 'duck'.
    /// </summary>
    public partial class ImageClassification : AutoMLVertical
    {
        /// <summary> Initializes a new instance of ImageClassification. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="limitSettings"> [Required] Limit settings for the AutoML job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> or <paramref name="limitSettings"/> is null. </exception>
        public ImageClassification(MachineLearningTableJobInput trainingData, ImageLimitSettings limitSettings) : base(trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));
            Argument.AssertNotNull(limitSettings, nameof(limitSettings));

            SearchSpace = new ChangeTrackingList<ImageModelDistributionSettingsClassification>();
            LimitSettings = limitSettings;
            TaskType = TaskType.ImageClassification;
        }

        /// <summary> Initializes a new instance of ImageClassification. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="primaryMetric"> Primary metric to optimize for this task. </param>
        /// <param name="modelSettings"> Settings used for training the model. </param>
        /// <param name="searchSpace"> Search space for sampling different combinations of models and their hyperparameters. </param>
        /// <param name="limitSettings"> [Required] Limit settings for the AutoML job. </param>
        /// <param name="sweepSettings"> Model sweeping and hyperparameter sweeping related settings. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        /// <param name="validationDataSize">
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </param>
        internal ImageClassification(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, ClassificationPrimaryMetric? primaryMetric, ImageModelSettingsClassification modelSettings, IList<ImageModelDistributionSettingsClassification> searchSpace, ImageLimitSettings limitSettings, ImageSweepSettings sweepSettings, MachineLearningTableJobInput validationData, double? validationDataSize) : base(logVerbosity, targetColumnName, taskType, trainingData)
        {
            PrimaryMetric = primaryMetric;
            ModelSettings = modelSettings;
            SearchSpace = searchSpace;
            LimitSettings = limitSettings;
            SweepSettings = sweepSettings;
            ValidationData = validationData;
            ValidationDataSize = validationDataSize;
            TaskType = taskType;
        }

        /// <summary> Primary metric to optimize for this task. </summary>
        public ClassificationPrimaryMetric? PrimaryMetric { get; set; }
        /// <summary> Settings used for training the model. </summary>
        public ImageModelSettingsClassification ModelSettings { get; set; }
        /// <summary> Search space for sampling different combinations of models and their hyperparameters. </summary>
        public IList<ImageModelDistributionSettingsClassification> SearchSpace { get; set; }
        /// <summary> [Required] Limit settings for the AutoML job. </summary>
        public ImageLimitSettings LimitSettings { get; set; }
        /// <summary> Model sweeping and hyperparameter sweeping related settings. </summary>
        public ImageSweepSettings SweepSettings { get; set; }
        /// <summary> Validation data inputs. </summary>
        public MachineLearningTableJobInput ValidationData { get; set; }
        /// <summary>
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </summary>
        public double? ValidationDataSize { get; set; }
    }
}