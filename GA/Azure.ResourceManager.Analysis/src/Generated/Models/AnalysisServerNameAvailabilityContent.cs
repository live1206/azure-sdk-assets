// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> Details of server name request body. </summary>
    public partial class AnalysisServerNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of AnalysisServerNameAvailabilityContent. </summary>
        public AnalysisServerNameAvailabilityContent()
        {
        }

        /// <summary> Name for checking availability. </summary>
        public string Name { get; set; }
        /// <summary> The resource type of azure analysis services. </summary>
        public string ResourceType { get; set; }
    }
}