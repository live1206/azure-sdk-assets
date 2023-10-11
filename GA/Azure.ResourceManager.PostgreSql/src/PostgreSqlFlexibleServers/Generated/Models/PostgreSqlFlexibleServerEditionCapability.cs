// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Flexible server edition capabilities. </summary>
    public partial class PostgreSqlFlexibleServerEditionCapability : PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerEditionCapability. </summary>
        internal PostgreSqlFlexibleServerEditionCapability()
        {
            SupportedStorageEditions = new ChangeTrackingList<PostgreSqlFlexibleServerStorageEditionCapability>();
            SupportedServerSkus = new ChangeTrackingList<PostgreSqlFlexibleServerSkuCapability>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerEditionCapability. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="name"> Server edition name. </param>
        /// <param name="defaultSkuName"> Default sku name for the server edition. </param>
        /// <param name="supportedStorageEditions"> The list of editions supported by this server edition. </param>
        /// <param name="supportedServerSkus"> List of supported server SKUs. </param>
        internal PostgreSqlFlexibleServerEditionCapability(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason, string name, string defaultSkuName, IReadOnlyList<PostgreSqlFlexibleServerStorageEditionCapability> supportedStorageEditions, IReadOnlyList<PostgreSqlFlexibleServerSkuCapability> supportedServerSkus) : base(capabilityStatus, reason)
        {
            Name = name;
            DefaultSkuName = defaultSkuName;
            SupportedStorageEditions = supportedStorageEditions;
            SupportedServerSkus = supportedServerSkus;
        }

        /// <summary> Server edition name. </summary>
        public string Name { get; }
        /// <summary> Default sku name for the server edition. </summary>
        public string DefaultSkuName { get; }
        /// <summary> The list of editions supported by this server edition. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerStorageEditionCapability> SupportedStorageEditions { get; }
        /// <summary> List of supported server SKUs. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerSkuCapability> SupportedServerSkus { get; }
    }
}