// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Resource requests/limits for this instance type. </summary>
    public partial class MachineLearningInstanceTypeSchemaResources
    {
        /// <summary> Initializes a new instance of MachineLearningInstanceTypeSchemaResources. </summary>
        public MachineLearningInstanceTypeSchemaResources()
        {
            Requests = new ChangeTrackingDictionary<string, string>();
            Limits = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MachineLearningInstanceTypeSchemaResources. </summary>
        /// <param name="requests"> Resource requests for this instance type. </param>
        /// <param name="limits"> Resource limits for this instance type. </param>
        internal MachineLearningInstanceTypeSchemaResources(IDictionary<string, string> requests, IDictionary<string, string> limits)
        {
            Requests = requests;
            Limits = limits;
        }

        /// <summary> Resource requests for this instance type. </summary>
        public IDictionary<string, string> Requests { get; }
        /// <summary> Resource limits for this instance type. </summary>
        public IDictionary<string, string> Limits { get; }
    }
}