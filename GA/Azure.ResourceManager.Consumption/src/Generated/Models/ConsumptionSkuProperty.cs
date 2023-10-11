// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The Sku property. </summary>
    public partial class ConsumptionSkuProperty
    {
        /// <summary> Initializes a new instance of ConsumptionSkuProperty. </summary>
        internal ConsumptionSkuProperty()
        {
        }

        /// <summary> Initializes a new instance of ConsumptionSkuProperty. </summary>
        /// <param name="name"> The name of sku property. </param>
        /// <param name="value"> The value of sku property. </param>
        internal ConsumptionSkuProperty(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of sku property. </summary>
        public string Name { get; }
        /// <summary> The value of sku property. </summary>
        public string Value { get; }
    }
}