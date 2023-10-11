// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The array of capabilities of a lab services SKU. </summary>
    public partial class AvailableLabServicesSkuCapability
    {
        /// <summary> Initializes a new instance of AvailableLabServicesSkuCapability. </summary>
        internal AvailableLabServicesSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of AvailableLabServicesSkuCapability. </summary>
        /// <param name="name"> The name of the capability for a SKU. </param>
        /// <param name="value"> The value of the capability for a SKU. </param>
        internal AvailableLabServicesSkuCapability(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the capability for a SKU. </summary>
        public string Name { get; }
        /// <summary> The value of the capability for a SKU. </summary>
        public string Value { get; }
    }
}