// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The managed server capability. </summary>
    public partial class ManagedInstanceEditionCapability
    {
        /// <summary> Initializes a new instance of ManagedInstanceEditionCapability. </summary>
        internal ManagedInstanceEditionCapability()
        {
            SupportedFamilies = new ChangeTrackingList<ManagedInstanceFamilyCapability>();
            SupportedStorageCapabilities = new ChangeTrackingList<StorageCapability>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceEditionCapability. </summary>
        /// <param name="name"> The managed server version name. </param>
        /// <param name="supportedFamilies"> The supported families. </param>
        /// <param name="supportedStorageCapabilities"> The list of supported storage capabilities for this edition. </param>
        /// <param name="isZoneRedundant"> Whether or not zone redundancy is supported for the edition. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal ManagedInstanceEditionCapability(string name, IReadOnlyList<ManagedInstanceFamilyCapability> supportedFamilies, IReadOnlyList<StorageCapability> supportedStorageCapabilities, bool? isZoneRedundant, SqlCapabilityStatus? status, string reason)
        {
            Name = name;
            SupportedFamilies = supportedFamilies;
            SupportedStorageCapabilities = supportedStorageCapabilities;
            IsZoneRedundant = isZoneRedundant;
            Status = status;
            Reason = reason;
        }

        /// <summary> The managed server version name. </summary>
        public string Name { get; }
        /// <summary> The supported families. </summary>
        public IReadOnlyList<ManagedInstanceFamilyCapability> SupportedFamilies { get; }
        /// <summary> The list of supported storage capabilities for this edition. </summary>
        public IReadOnlyList<StorageCapability> SupportedStorageCapabilities { get; }
        /// <summary> Whether or not zone redundancy is supported for the edition. </summary>
        public bool? IsZoneRedundant { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
