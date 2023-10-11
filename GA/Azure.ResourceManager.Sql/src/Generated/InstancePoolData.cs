// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the InstancePool data model.
    /// An Azure SQL instance pool.
    /// </summary>
    public partial class InstancePoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of InstancePoolData. </summary>
        /// <param name="location"> The location. </param>
        public InstancePoolData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of InstancePoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The name and tier of the SKU. </param>
        /// <param name="subnetId"> Resource ID of the subnet to place this instance pool in. </param>
        /// <param name="vCores"> Count of vCores belonging to this instance pool. </param>
        /// <param name="licenseType"> The license type. Possible values are 'LicenseIncluded' (price for SQL license is included) and 'BasePrice' (without SQL license price). </param>
        internal InstancePoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SqlSku sku, ResourceIdentifier subnetId, int? vCores, InstancePoolLicenseType? licenseType) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            SubnetId = subnetId;
            VCores = vCores;
            LicenseType = licenseType;
        }

        /// <summary> The name and tier of the SKU. </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Resource ID of the subnet to place this instance pool in. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Count of vCores belonging to this instance pool. </summary>
        public int? VCores { get; set; }
        /// <summary> The license type. Possible values are 'LicenseIncluded' (price for SQL license is included) and 'BasePrice' (without SQL license price). </summary>
        public InstancePoolLicenseType? LicenseType { get; set; }
    }
}