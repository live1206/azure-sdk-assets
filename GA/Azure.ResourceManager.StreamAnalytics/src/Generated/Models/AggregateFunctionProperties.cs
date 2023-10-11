// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The properties that are associated with an aggregate function. </summary>
    public partial class AggregateFunctionProperties : StreamingJobFunctionProperties
    {
        /// <summary> Initializes a new instance of AggregateFunctionProperties. </summary>
        public AggregateFunctionProperties()
        {
            FunctionPropertiesType = "Aggregate";
        }

        /// <summary> Initializes a new instance of AggregateFunctionProperties. </summary>
        /// <param name="functionPropertiesType"> Indicates the type of function. </param>
        /// <param name="etag"> The current entity tag for the function. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        /// <param name="inputs"></param>
        /// <param name="output"> Describes the output of a function. </param>
        /// <param name="binding">
        /// The physical binding of the function. For example, in the Azure Machine Learning web service’s case, this describes the endpoint.
        /// Please note <see cref="StreamingJobFunctionBinding"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EMachineLearningStudioFunctionBinding"/>, <see cref="MachineLearningServiceFunctionBinding"/>, <see cref="CSharpFunctionBinding"/> and <see cref="JavaScriptFunctionBinding"/>.
        /// </param>
        internal AggregateFunctionProperties(string functionPropertiesType, ETag? etag, IList<StreamingJobFunctionInput> inputs, StreamingJobFunctionOutput output, StreamingJobFunctionBinding binding) : base(functionPropertiesType, etag, inputs, output, binding)
        {
            FunctionPropertiesType = functionPropertiesType ?? "Aggregate";
        }
    }
}