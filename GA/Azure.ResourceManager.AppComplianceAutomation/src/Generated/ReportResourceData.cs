// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A class representing the ReportResource data model.
    /// A class represent an AppComplianceAutomation report resource.
    /// </summary>
    public partial class ReportResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of ReportResourceData. </summary>
        /// <param name="properties"> Report property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ReportResourceData(ReportProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of ReportResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Report property. </param>
        internal ReportResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ReportProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Report property. </summary>
        public ReportProperties Properties { get; set; }
    }
}