// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Azure query for the update configuration. </summary>
    public partial class AzureQueryProperties
    {
        /// <summary> Initializes a new instance of AzureQueryProperties. </summary>
        public AzureQueryProperties()
        {
            Scope = new ChangeTrackingList<string>();
            Locations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of AzureQueryProperties. </summary>
        /// <param name="scope"> List of Subscription or Resource Group ARM Ids. </param>
        /// <param name="locations"> List of locations to scope the query to. </param>
        /// <param name="tagSettings"> Tag settings for the VM. </param>
        internal AzureQueryProperties(IList<string> scope, IList<AzureLocation> locations, QueryTagSettingsProperties tagSettings)
        {
            Scope = scope;
            Locations = locations;
            TagSettings = tagSettings;
        }

        /// <summary> List of Subscription or Resource Group ARM Ids. </summary>
        public IList<string> Scope { get; }
        /// <summary> List of locations to scope the query to. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> Tag settings for the VM. </summary>
        public QueryTagSettingsProperties TagSettings { get; set; }
    }
}