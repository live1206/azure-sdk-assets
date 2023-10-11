// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningTableJobOutput. </summary>
    public partial class MachineLearningTableJobOutput : MachineLearningJobOutput
    {
        /// <summary> Initializes a new instance of MachineLearningTableJobOutput. </summary>
        public MachineLearningTableJobOutput()
        {
            JobOutputType = JobOutputType.Mltable;
        }

        /// <summary> Initializes a new instance of MachineLearningTableJobOutput. </summary>
        /// <param name="description"> Description for the output. </param>
        /// <param name="jobOutputType"> [Required] Specifies the type of job. </param>
        /// <param name="mode"> Output Asset Delivery Mode. </param>
        /// <param name="uri"> Output Asset URI. </param>
        internal MachineLearningTableJobOutput(string description, JobOutputType jobOutputType, MachineLearningOutputDeliveryMode? mode, Uri uri) : base(description, jobOutputType)
        {
            Mode = mode;
            Uri = uri;
            JobOutputType = jobOutputType;
        }

        /// <summary> Output Asset Delivery Mode. </summary>
        public MachineLearningOutputDeliveryMode? Mode { get; set; }
        /// <summary> Output Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}