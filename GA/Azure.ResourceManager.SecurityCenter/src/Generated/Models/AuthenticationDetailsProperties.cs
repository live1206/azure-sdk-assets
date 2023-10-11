// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// Settings for cloud authentication management
    /// Please note <see cref="AuthenticationDetailsProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AwsAssumeRoleAuthenticationDetailsProperties"/>, <see cref="AwsCredsAuthenticationDetailsProperties"/> and <see cref="GcpCredentialsDetailsProperties"/>.
    /// </summary>
    public abstract partial class AuthenticationDetailsProperties
    {
        /// <summary> Initializes a new instance of AuthenticationDetailsProperties. </summary>
        protected AuthenticationDetailsProperties()
        {
            GrantedPermissions = new ChangeTrackingList<SecurityCenterCloudPermission>();
        }

        /// <summary> Initializes a new instance of AuthenticationDetailsProperties. </summary>
        /// <param name="authenticationProvisioningState"> State of the multi-cloud connector. </param>
        /// <param name="grantedPermissions"> The permissions detected in the cloud account. </param>
        /// <param name="authenticationType"> Connect to your cloud account, for AWS use either account credentials or role-based authentication. For GCP use account organization credentials. </param>
        internal AuthenticationDetailsProperties(AuthenticationProvisioningState? authenticationProvisioningState, IReadOnlyList<SecurityCenterCloudPermission> grantedPermissions, AuthenticationType authenticationType)
        {
            AuthenticationProvisioningState = authenticationProvisioningState;
            GrantedPermissions = grantedPermissions;
            AuthenticationType = authenticationType;
        }

        /// <summary> State of the multi-cloud connector. </summary>
        public AuthenticationProvisioningState? AuthenticationProvisioningState { get; }
        /// <summary> The permissions detected in the cloud account. </summary>
        public IReadOnlyList<SecurityCenterCloudPermission> GrantedPermissions { get; }
        /// <summary> Connect to your cloud account, for AWS use either account credentials or role-based authentication. For GCP use account organization credentials. </summary>
        internal AuthenticationType AuthenticationType { get; set; }
    }
}
