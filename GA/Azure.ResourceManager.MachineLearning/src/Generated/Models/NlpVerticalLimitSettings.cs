// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job execution constraints. </summary>
    public partial class NlpVerticalLimitSettings
    {
        /// <summary> Initializes a new instance of NlpVerticalLimitSettings. </summary>
        public NlpVerticalLimitSettings()
        {
        }

        /// <summary> Initializes a new instance of NlpVerticalLimitSettings. </summary>
        /// <param name="maxConcurrentTrials"> Maximum Concurrent AutoML iterations. </param>
        /// <param name="maxTrials"> Number of AutoML iterations. </param>
        /// <param name="timeout"> AutoML job timeout. </param>
        internal NlpVerticalLimitSettings(int? maxConcurrentTrials, int? maxTrials, TimeSpan? timeout)
        {
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxTrials = maxTrials;
            Timeout = timeout;
        }

        /// <summary> Maximum Concurrent AutoML iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Number of AutoML iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}