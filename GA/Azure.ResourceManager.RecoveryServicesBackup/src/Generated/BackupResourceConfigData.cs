// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing the BackupResourceConfig data model.
    /// The resource storage details.
    /// </summary>
    public partial class BackupResourceConfigData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of BackupResourceConfigData. </summary>
        /// <param name="location"> The location. </param>
        public BackupResourceConfigData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of BackupResourceConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> BackupResourceConfigResource properties. </param>
        /// <param name="eTag"> Optional ETag. </param>
        internal BackupResourceConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupResourceConfigProperties properties, ETag? eTag) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary> BackupResourceConfigResource properties. </summary>
        public BackupResourceConfigProperties Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}