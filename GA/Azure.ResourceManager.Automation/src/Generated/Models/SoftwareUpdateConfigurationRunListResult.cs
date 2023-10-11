// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> result of listing all software update configuration runs. </summary>
    internal partial class SoftwareUpdateConfigurationRunListResult
    {
        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationRunListResult. </summary>
        internal SoftwareUpdateConfigurationRunListResult()
        {
            Value = new ChangeTrackingList<SoftwareUpdateConfigurationRun>();
        }

        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationRunListResult. </summary>
        /// <param name="value"> outer object returned when listing all software update configuration runs. </param>
        /// <param name="nextLink"> link to next page of results. </param>
        internal SoftwareUpdateConfigurationRunListResult(IReadOnlyList<SoftwareUpdateConfigurationRun> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> outer object returned when listing all software update configuration runs. </summary>
        public IReadOnlyList<SoftwareUpdateConfigurationRun> Value { get; }
        /// <summary> link to next page of results. </summary>
        public string NextLink { get; }
    }
}