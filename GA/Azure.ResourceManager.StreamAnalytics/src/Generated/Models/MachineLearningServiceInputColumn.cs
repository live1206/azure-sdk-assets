// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an input column for the Azure Machine Learning web service endpoint. </summary>
    public partial class MachineLearningServiceInputColumn
    {
        /// <summary> Initializes a new instance of MachineLearningServiceInputColumn. </summary>
        public MachineLearningServiceInputColumn()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningServiceInputColumn. </summary>
        /// <param name="name"> The name of the input column. </param>
        /// <param name="dataType"> The (Azure Machine Learning supported) data type of the input column. </param>
        /// <param name="mapTo"> The zero based index of the function parameter this input maps to. </param>
        internal MachineLearningServiceInputColumn(string name, string dataType, int? mapTo)
        {
            Name = name;
            DataType = dataType;
            MapTo = mapTo;
        }

        /// <summary> The name of the input column. </summary>
        public string Name { get; set; }
        /// <summary> The (Azure Machine Learning supported) data type of the input column. </summary>
        public string DataType { get; set; }
        /// <summary> The zero based index of the function parameter this input maps to. </summary>
        public int? MapTo { get; set; }
    }
}