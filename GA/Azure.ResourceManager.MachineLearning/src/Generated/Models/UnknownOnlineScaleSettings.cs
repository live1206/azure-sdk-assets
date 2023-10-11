// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownOnlineScaleSettings. </summary>
    internal partial class UnknownOnlineScaleSettings : MachineLearningOnlineScaleSettings
    {
        /// <summary> Initializes a new instance of UnknownOnlineScaleSettings. </summary>
        /// <param name="scaleType"> [Required] Type of deployment scaling algorithm. </param>
        internal UnknownOnlineScaleSettings(ScaleType scaleType) : base(scaleType)
        {
            ScaleType = scaleType;
        }
    }
}