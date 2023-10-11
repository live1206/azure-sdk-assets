// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the activity parameter. </summary>
    public partial class AutomationActivityParameterDefinition
    {
        /// <summary> Initializes a new instance of AutomationActivityParameterDefinition. </summary>
        internal AutomationActivityParameterDefinition()
        {
            ValidationSet = new ChangeTrackingList<AutomationActivityParameterValidationSet>();
        }

        /// <summary> Initializes a new instance of AutomationActivityParameterDefinition. </summary>
        /// <param name="name"> Gets or sets the name of the activity parameter. </param>
        /// <param name="activityParameterType"> Gets or sets the type of the activity parameter. </param>
        /// <param name="isMandatory"> Gets or sets a Boolean value that indicates true if the parameter is required. If the value is false, the parameter is optional. </param>
        /// <param name="isDynamic"> Gets or sets a Boolean value that indicates true if the parameter is dynamic. </param>
        /// <param name="position"> Gets or sets the position of the activity parameter. </param>
        /// <param name="canTakeValueFromPipeline"> Gets or sets a Boolean value that indicates true if the parameter can take values from the incoming pipeline objects. This setting is used if the cmdlet must access the complete input object. false indicates that the parameter cannot take values from the complete input object. </param>
        /// <param name="canTakeValueFromPipelineByPropertyName"> Gets or sets a Boolean value that indicates true if the parameter can be filled from a property of the incoming pipeline object that has the same name as this parameter. false indicates that the parameter cannot be filled from the incoming pipeline object property with the same name. </param>
        /// <param name="canTakeValueValueFromRemainingArguments"> Gets or sets a Boolean value that indicates true if the cmdlet parameter accepts all the remaining command-line arguments that are associated with this parameter in the form of an array. false if the cmdlet parameter does not accept all the remaining argument values. </param>
        /// <param name="description"> Gets or sets the description of the activity parameter. </param>
        /// <param name="validationSet"> Gets or sets the validation set of activity parameter. </param>
        internal AutomationActivityParameterDefinition(string name, string activityParameterType, bool? isMandatory, bool? isDynamic, long? position, bool? canTakeValueFromPipeline, bool? canTakeValueFromPipelineByPropertyName, bool? canTakeValueValueFromRemainingArguments, string description, IReadOnlyList<AutomationActivityParameterValidationSet> validationSet)
        {
            Name = name;
            ActivityParameterType = activityParameterType;
            IsMandatory = isMandatory;
            IsDynamic = isDynamic;
            Position = position;
            CanTakeValueFromPipeline = canTakeValueFromPipeline;
            CanTakeValueFromPipelineByPropertyName = canTakeValueFromPipelineByPropertyName;
            CanTakeValueValueFromRemainingArguments = canTakeValueValueFromRemainingArguments;
            Description = description;
            ValidationSet = validationSet;
        }

        /// <summary> Gets or sets the name of the activity parameter. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the type of the activity parameter. </summary>
        public string ActivityParameterType { get; }
        /// <summary> Gets or sets a Boolean value that indicates true if the parameter is required. If the value is false, the parameter is optional. </summary>
        public bool? IsMandatory { get; }
        /// <summary> Gets or sets a Boolean value that indicates true if the parameter is dynamic. </summary>
        public bool? IsDynamic { get; }
        /// <summary> Gets or sets the position of the activity parameter. </summary>
        public long? Position { get; }
        /// <summary> Gets or sets a Boolean value that indicates true if the parameter can take values from the incoming pipeline objects. This setting is used if the cmdlet must access the complete input object. false indicates that the parameter cannot take values from the complete input object. </summary>
        public bool? CanTakeValueFromPipeline { get; }
        /// <summary> Gets or sets a Boolean value that indicates true if the parameter can be filled from a property of the incoming pipeline object that has the same name as this parameter. false indicates that the parameter cannot be filled from the incoming pipeline object property with the same name. </summary>
        public bool? CanTakeValueFromPipelineByPropertyName { get; }
        /// <summary> Gets or sets a Boolean value that indicates true if the cmdlet parameter accepts all the remaining command-line arguments that are associated with this parameter in the form of an array. false if the cmdlet parameter does not accept all the remaining argument values. </summary>
        public bool? CanTakeValueValueFromRemainingArguments { get; }
        /// <summary> Gets or sets the description of the activity parameter. </summary>
        public string Description { get; }
        /// <summary> Gets or sets the validation set of activity parameter. </summary>
        public IReadOnlyList<AutomationActivityParameterValidationSet> ValidationSet { get; }
    }
}
