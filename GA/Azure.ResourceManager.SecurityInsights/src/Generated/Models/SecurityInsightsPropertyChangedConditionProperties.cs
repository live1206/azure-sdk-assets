// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes an automation rule condition that evaluates a property's value change. </summary>
    public partial class SecurityInsightsPropertyChangedConditionProperties : SecurityInsightsAutomationRuleCondition
    {
        /// <summary> Initializes a new instance of SecurityInsightsPropertyChangedConditionProperties. </summary>
        public SecurityInsightsPropertyChangedConditionProperties()
        {
            ConditionType = ConditionType.PropertyChanged;
        }

        /// <summary> Initializes a new instance of SecurityInsightsPropertyChangedConditionProperties. </summary>
        /// <param name="conditionType"></param>
        /// <param name="conditionProperties"></param>
        internal SecurityInsightsPropertyChangedConditionProperties(ConditionType conditionType, AutomationRulePropertyValuesChangedCondition conditionProperties) : base(conditionType)
        {
            ConditionProperties = conditionProperties;
            ConditionType = conditionType;
        }

        /// <summary> Gets or sets the condition properties. </summary>
        public AutomationRulePropertyValuesChangedCondition ConditionProperties { get; set; }
    }
}