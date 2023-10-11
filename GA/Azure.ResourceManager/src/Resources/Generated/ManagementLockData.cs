// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ManagementLock data model.
    /// The lock information.
    /// </summary>
    public partial class ManagementLockData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagementLockData. </summary>
        /// <param name="level"> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can't modify or delete it. </param>
        public ManagementLockData(ManagementLockLevel level)
        {
            Level = level;
            Owners = new ChangeTrackingList<ManagementLockOwner>();
        }

        /// <summary> Initializes a new instance of ManagementLockData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="level"> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can't modify or delete it. </param>
        /// <param name="notes"> Notes about the lock. Maximum of 512 characters. </param>
        /// <param name="owners"> The owners of the lock. </param>
        internal ManagementLockData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagementLockLevel level, string notes, IList<ManagementLockOwner> owners) : base(id, name, resourceType, systemData)
        {
            Level = level;
            Notes = notes;
            Owners = owners;
        }

        /// <summary> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can't modify or delete it. </summary>
        public ManagementLockLevel Level { get; set; }
        /// <summary> Notes about the lock. Maximum of 512 characters. </summary>
        public string Notes { get; set; }
        /// <summary> The owners of the lock. </summary>
        public IList<ManagementLockOwner> Owners { get; }
    }
}