// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of listing benefit recommendations. </summary>
    internal partial class BenefitRecommendationsListResult
    {
        /// <summary> Initializes a new instance of BenefitRecommendationsListResult. </summary>
        internal BenefitRecommendationsListResult()
        {
            Value = new ChangeTrackingList<BenefitRecommendationModel>();
        }

        /// <summary> Initializes a new instance of BenefitRecommendationsListResult. </summary>
        /// <param name="value"> The list of benefit recommendations. </param>
        /// <param name="nextLink"> The link (URL) to the next page of results. </param>
        internal BenefitRecommendationsListResult(IReadOnlyList<BenefitRecommendationModel> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of benefit recommendations. </summary>
        public IReadOnlyList<BenefitRecommendationModel> Value { get; }
        /// <summary> The link (URL) to the next page of results. </summary>
        public Uri NextLink { get; }
    }
}