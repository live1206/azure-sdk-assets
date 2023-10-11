// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> A role that can be assigned to a user. </summary>
    public partial class DevCenterEnvironmentRole
    {
        /// <summary> Initializes a new instance of DevCenterEnvironmentRole. </summary>
        public DevCenterEnvironmentRole()
        {
        }

        /// <summary> Initializes a new instance of DevCenterEnvironmentRole. </summary>
        /// <param name="roleName"> The common name of the Role Assignment. This is a descriptive name such as 'AcrPush'. </param>
        /// <param name="description"> This is a description of the Role Assignment. </param>
        internal DevCenterEnvironmentRole(string roleName, string description)
        {
            RoleName = roleName;
            Description = description;
        }

        /// <summary> The common name of the Role Assignment. This is a descriptive name such as 'AcrPush'. </summary>
        public string RoleName { get; }
        /// <summary> This is a description of the Role Assignment. </summary>
        public string Description { get; }
    }
}