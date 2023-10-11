// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Describes an available Cognitive Services Model SKU. </summary>
    public partial class CognitiveServicesModelSku
    {
        /// <summary> Initializes a new instance of CognitiveServicesModelSku. </summary>
        public CognitiveServicesModelSku()
        {
            RateLimits = new ChangeTrackingList<ServiceAccountCallRateLimit>();
        }

        /// <summary> Initializes a new instance of CognitiveServicesModelSku. </summary>
        /// <param name="name"> The name of the model SKU. </param>
        /// <param name="usageName"> The usage name of the model SKU. </param>
        /// <param name="deprecationOn"> The datetime of deprecation of the model SKU. </param>
        /// <param name="capacity"> The capacity configuration. </param>
        /// <param name="rateLimits"> The list of rateLimit. </param>
        internal CognitiveServicesModelSku(string name, string usageName, DateTimeOffset? deprecationOn, CognitiveServicesCapacityConfig capacity, IReadOnlyList<ServiceAccountCallRateLimit> rateLimits)
        {
            Name = name;
            UsageName = usageName;
            DeprecationOn = deprecationOn;
            Capacity = capacity;
            RateLimits = rateLimits;
        }

        /// <summary> The name of the model SKU. </summary>
        public string Name { get; set; }
        /// <summary> The usage name of the model SKU. </summary>
        public string UsageName { get; set; }
        /// <summary> The datetime of deprecation of the model SKU. </summary>
        public DateTimeOffset? DeprecationOn { get; set; }
        /// <summary> The capacity configuration. </summary>
        public CognitiveServicesCapacityConfig Capacity { get; set; }
        /// <summary> The list of rateLimit. </summary>
        public IReadOnlyList<ServiceAccountCallRateLimit> RateLimits { get; }
    }
}