// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of custom data column. </summary>
    public partial class DataColumnDefinition
    {
        /// <summary> Initializes a new instance of DataColumnDefinition. </summary>
        public DataColumnDefinition()
        {
        }

        /// <summary> Initializes a new instance of DataColumnDefinition. </summary>
        /// <param name="name"> The name of the column. </param>
        /// <param name="definitionType"> The type of the column data. </param>
        internal DataColumnDefinition(string name, DataColumnDefinitionType? definitionType)
        {
            Name = name;
            DefinitionType = definitionType;
        }

        /// <summary> The name of the column. </summary>
        public string Name { get; set; }
        /// <summary> The type of the column data. </summary>
        public DataColumnDefinitionType? DefinitionType { get; set; }
    }
}