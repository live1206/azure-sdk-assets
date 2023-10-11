// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The security context for the container. </summary>
    public partial class ContainerSecurityContextDefinition
    {
        /// <summary> Initializes a new instance of ContainerSecurityContextDefinition. </summary>
        public ContainerSecurityContextDefinition()
        {
        }

        /// <summary> Initializes a new instance of ContainerSecurityContextDefinition. </summary>
        /// <param name="isPrivileged"> The flag to determine if the container permissions is elevated to Privileged. </param>
        /// <param name="allowPrivilegeEscalation"> A boolean value indicating whether the init process can elevate its privileges. </param>
        /// <param name="capabilities"> The capabilities to add or drop from a container. </param>
        /// <param name="runAsGroup"> Sets the User GID for the container. </param>
        /// <param name="runAsUser"> Sets the User UID for the container. </param>
        /// <param name="seccompProfile"> a base64 encoded string containing the contents of the JSON in the seccomp profile. </param>
        internal ContainerSecurityContextDefinition(bool? isPrivileged, bool? allowPrivilegeEscalation, ContainerSecurityContextCapabilitiesDefinition capabilities, int? runAsGroup, int? runAsUser, string seccompProfile)
        {
            IsPrivileged = isPrivileged;
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            Capabilities = capabilities;
            RunAsGroup = runAsGroup;
            RunAsUser = runAsUser;
            SeccompProfile = seccompProfile;
        }

        /// <summary> The flag to determine if the container permissions is elevated to Privileged. </summary>
        public bool? IsPrivileged { get; set; }
        /// <summary> A boolean value indicating whether the init process can elevate its privileges. </summary>
        public bool? AllowPrivilegeEscalation { get; set; }
        /// <summary> The capabilities to add or drop from a container. </summary>
        public ContainerSecurityContextCapabilitiesDefinition Capabilities { get; set; }
        /// <summary> Sets the User GID for the container. </summary>
        public int? RunAsGroup { get; set; }
        /// <summary> Sets the User UID for the container. </summary>
        public int? RunAsUser { get; set; }
        /// <summary> a base64 encoded string containing the contents of the JSON in the seccomp profile. </summary>
        public string SeccompProfile { get; set; }
    }
}