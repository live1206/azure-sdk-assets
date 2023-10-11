// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for PostArgs match conditions. </summary>
    public partial class PostArgsMatchCondition
    {
        /// <summary> Initializes a new instance of PostArgsMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="postArgsOperator"> Describes operator to be matched. </param>
        public PostArgsMatchCondition(PostArgsMatchConditionType conditionType, PostArgsOperator postArgsOperator)
        {
            ConditionType = conditionType;
            PostArgsOperator = postArgsOperator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of PostArgsMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="selector"> Name of PostArg to be matched. </param>
        /// <param name="postArgsOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal PostArgsMatchCondition(PostArgsMatchConditionType conditionType, string selector, PostArgsOperator postArgsOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms)
        {
            ConditionType = conditionType;
            Selector = selector;
            PostArgsOperator = postArgsOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the condition type. </summary>
        public PostArgsMatchConditionType ConditionType { get; set; }
        /// <summary> Name of PostArg to be matched. </summary>
        public string Selector { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public PostArgsOperator PostArgsOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}