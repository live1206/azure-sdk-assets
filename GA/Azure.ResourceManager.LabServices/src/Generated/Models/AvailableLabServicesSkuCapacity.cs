// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The scale out/in options of the SKU. </summary>
    public partial class AvailableLabServicesSkuCapacity
    {
        /// <summary> Initializes a new instance of AvailableLabServicesSkuCapacity. </summary>
        internal AvailableLabServicesSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of AvailableLabServicesSkuCapacity. </summary>
        /// <param name="default"> The default capacity for this resource. </param>
        /// <param name="minimum"> The lowest permitted capacity for this resource. </param>
        /// <param name="maximum"> The highest permitted capacity for this resource. </param>
        /// <param name="scaleType"> The localized name of the resource. </param>
        internal AvailableLabServicesSkuCapacity(long? @default, long? minimum, long? maximum, LabServicesSkuCapacityScaleType? scaleType)
        {
            Default = @default;
            Minimum = minimum;
            Maximum = maximum;
            ScaleType = scaleType;
        }

        /// <summary> The default capacity for this resource. </summary>
        public long? Default { get; }
        /// <summary> The lowest permitted capacity for this resource. </summary>
        public long? Minimum { get; }
        /// <summary> The highest permitted capacity for this resource. </summary>
        public long? Maximum { get; }
        /// <summary> The localized name of the resource. </summary>
        public LabServicesSkuCapacityScaleType? ScaleType { get; }
    }
}