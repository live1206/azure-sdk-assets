// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownForecastHorizon. </summary>
    internal partial class UnknownForecastHorizon : ForecastHorizon
    {
        /// <summary> Initializes a new instance of UnknownForecastHorizon. </summary>
        /// <param name="mode"> [Required] Set forecast horizon value selection mode. </param>
        internal UnknownForecastHorizon(ForecastHorizonMode mode) : base(mode)
        {
            Mode = mode;
        }
    }
}