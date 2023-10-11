// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The UnknownAction. </summary>
    internal partial class UnknownAction : AlertProcessingRuleAction
    {
        /// <summary> Initializes a new instance of UnknownAction. </summary>
        /// <param name="actionType"> Action that should be applied. </param>
        internal UnknownAction(AlertProcessingRuleActionType actionType) : base(actionType)
        {
            ActionType = actionType;
        }
    }
}