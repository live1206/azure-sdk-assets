// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRuleBcdrLocationSpec. </summary>
    public partial class DataCollectionRuleBcdrLocationSpec
    {
        /// <summary> Initializes a new instance of DataCollectionRuleBcdrLocationSpec. </summary>
        internal DataCollectionRuleBcdrLocationSpec()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleBcdrLocationSpec. </summary>
        /// <param name="location"> Name of location. </param>
        /// <param name="provisioningStatus"> The resource provisioning state in this location. </param>
        internal DataCollectionRuleBcdrLocationSpec(AzureLocation? location, DataCollectionRuleBcdrLocationSpecProvisioningStatus? provisioningStatus)
        {
            Location = location;
            ProvisioningStatus = provisioningStatus;
        }

        /// <summary> Name of location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The resource provisioning state in this location. </summary>
        public DataCollectionRuleBcdrLocationSpecProvisioningStatus? ProvisioningStatus { get; }
    }
}