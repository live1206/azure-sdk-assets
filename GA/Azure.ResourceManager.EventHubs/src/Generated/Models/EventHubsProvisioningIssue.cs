// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Describes Provisioning issue for given NetworkSecurityPerimeterConfiguration. </summary>
    public partial class EventHubsProvisioningIssue
    {
        /// <summary> Initializes a new instance of EventHubsProvisioningIssue. </summary>
        public EventHubsProvisioningIssue()
        {
        }

        /// <summary> Initializes a new instance of EventHubsProvisioningIssue. </summary>
        /// <param name="name"> Name of the issue. </param>
        /// <param name="properties"> Properties of Provisioning Issue. </param>
        internal EventHubsProvisioningIssue(string name, EventHubsProvisioningIssueProperties properties)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary> Name of the issue. </summary>
        public string Name { get; set; }
        /// <summary> Properties of Provisioning Issue. </summary>
        public EventHubsProvisioningIssueProperties Properties { get; }
    }
}