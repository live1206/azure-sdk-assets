// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing the AuthorizationPolicyResourceFormat data model.
    /// The authorization policy resource format.
    /// </summary>
    public partial class AuthorizationPolicyResourceFormatData : ResourceData
    {
        /// <summary> Initializes a new instance of AuthorizationPolicyResourceFormatData. </summary>
        public AuthorizationPolicyResourceFormatData()
        {
            Permissions = new ChangeTrackingList<PermissionType>();
        }

        /// <summary> Initializes a new instance of AuthorizationPolicyResourceFormatData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyName"> Name of the policy. </param>
        /// <param name="permissions"> The permissions associated with the policy. </param>
        /// <param name="primaryKey"> Primary key associated with the policy. </param>
        /// <param name="secondaryKey"> Secondary key associated with the policy. </param>
        internal AuthorizationPolicyResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string policyName, IList<PermissionType> permissions, string primaryKey, string secondaryKey) : base(id, name, resourceType, systemData)
        {
            PolicyName = policyName;
            Permissions = permissions;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary> Name of the policy. </summary>
        public string PolicyName { get; }
        /// <summary> The permissions associated with the policy. </summary>
        public IList<PermissionType> Permissions { get; }
        /// <summary> Primary key associated with the policy. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> Secondary key associated with the policy. </summary>
        public string SecondaryKey { get; set; }
    }
}