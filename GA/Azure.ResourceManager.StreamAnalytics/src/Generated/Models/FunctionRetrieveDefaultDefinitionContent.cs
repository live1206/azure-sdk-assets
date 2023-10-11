// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Parameters used to specify the type of function to retrieve the default definition for.
    /// Please note <see cref="FunctionRetrieveDefaultDefinitionContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningStudioFunctionRetrieveDefaultDefinitionContent"/>, <see cref="MachineLearningServiceFunctionRetrieveDefaultDefinitionContent"/>, <see cref="CSharpFunctionRetrieveDefaultDefinitionContent"/> and <see cref="JavaScriptFunctionRetrieveDefaultDefinitionContent"/>.
    /// </summary>
    public abstract partial class FunctionRetrieveDefaultDefinitionContent
    {
        /// <summary> Initializes a new instance of FunctionRetrieveDefaultDefinitionContent. </summary>
        protected FunctionRetrieveDefaultDefinitionContent()
        {
        }

        /// <summary> Indicates the function binding type. </summary>
        internal string BindingType { get; set; }
    }
}