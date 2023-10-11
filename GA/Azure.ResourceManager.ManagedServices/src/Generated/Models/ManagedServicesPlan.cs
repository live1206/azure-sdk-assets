// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The details for the Managed Services offer’s plan in Azure Marketplace. </summary>
    public partial class ManagedServicesPlan
    {
        /// <summary> Initializes a new instance of ManagedServicesPlan. </summary>
        /// <param name="name"> Azure Marketplace plan name. </param>
        /// <param name="publisher"> Azure Marketplace publisher ID. </param>
        /// <param name="product"> Azure Marketplace product code. </param>
        /// <param name="version"> Azure Marketplace plan's version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="publisher"/>, <paramref name="product"/> or <paramref name="version"/> is null. </exception>
        public ManagedServicesPlan(string name, string publisher, string product, string version)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(publisher, nameof(publisher));
            Argument.AssertNotNull(product, nameof(product));
            Argument.AssertNotNull(version, nameof(version));

            Name = name;
            Publisher = publisher;
            Product = product;
            Version = version;
        }

        /// <summary> Azure Marketplace plan name. </summary>
        public string Name { get; set; }
        /// <summary> Azure Marketplace publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> Azure Marketplace product code. </summary>
        public string Product { get; set; }
        /// <summary> Azure Marketplace plan's version. </summary>
        public string Version { get; set; }
    }
}