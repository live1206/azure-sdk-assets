// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestHeader match conditions. </summary>
    public partial class RequestHeaderMatchCondition
    {
        /// <summary> Initializes a new instance of RequestHeaderMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="requestHeaderOperator"> Describes operator to be matched. </param>
        public RequestHeaderMatchCondition(RequestHeaderMatchConditionType conditionType, RequestHeaderOperator requestHeaderOperator)
        {
            ConditionType = conditionType;
            RequestHeaderOperator = requestHeaderOperator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of RequestHeaderMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="selector"> Name of Header to be matched. </param>
        /// <param name="requestHeaderOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal RequestHeaderMatchCondition(RequestHeaderMatchConditionType conditionType, string selector, RequestHeaderOperator requestHeaderOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms)
        {
            ConditionType = conditionType;
            Selector = selector;
            RequestHeaderOperator = requestHeaderOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the condition type. </summary>
        public RequestHeaderMatchConditionType ConditionType { get; set; }
        /// <summary> Name of Header to be matched. </summary>
        public string Selector { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RequestHeaderOperator RequestHeaderOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}