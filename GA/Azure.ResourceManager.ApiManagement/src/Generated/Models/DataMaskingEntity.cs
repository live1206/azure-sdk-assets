// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The DataMaskingEntity. </summary>
    public partial class DataMaskingEntity
    {
        /// <summary> Initializes a new instance of DataMaskingEntity. </summary>
        public DataMaskingEntity()
        {
        }

        /// <summary> Initializes a new instance of DataMaskingEntity. </summary>
        /// <param name="value"> The name of an entity to mask (e.g. a name of a header or a query parameter). </param>
        /// <param name="mode"> Data masking mode. </param>
        internal DataMaskingEntity(string value, DataMaskingMode? mode)
        {
            Value = value;
            Mode = mode;
        }

        /// <summary> The name of an entity to mask (e.g. a name of a header or a query parameter). </summary>
        public string Value { get; set; }
        /// <summary> Data masking mode. </summary>
        public DataMaskingMode? Mode { get; set; }
    }
}