// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for ServerPort match conditions. </summary>
    public partial class ServerPortMatchCondition
    {
        /// <summary> Initializes a new instance of ServerPortMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="serverPortOperator"> Describes operator to be matched. </param>
        public ServerPortMatchCondition(ServerPortMatchConditionType conditionType, ServerPortOperator serverPortOperator)
        {
            ConditionType = conditionType;
            ServerPortOperator = serverPortOperator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of ServerPortMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="serverPortOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal ServerPortMatchCondition(ServerPortMatchConditionType conditionType, ServerPortOperator serverPortOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms)
        {
            ConditionType = conditionType;
            ServerPortOperator = serverPortOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the condition type. </summary>
        public ServerPortMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public ServerPortOperator ServerPortOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}