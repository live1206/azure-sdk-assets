// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> User registration delegation settings properties. </summary>
    internal partial class RegistrationDelegationSettingProperties
    {
        /// <summary> Initializes a new instance of RegistrationDelegationSettingProperties. </summary>
        public RegistrationDelegationSettingProperties()
        {
        }

        /// <summary> Initializes a new instance of RegistrationDelegationSettingProperties. </summary>
        /// <param name="isUserRegistrationDelegationEnabled"> Enable or disable delegation for user registration. </param>
        internal RegistrationDelegationSettingProperties(bool? isUserRegistrationDelegationEnabled)
        {
            IsUserRegistrationDelegationEnabled = isUserRegistrationDelegationEnabled;
        }

        /// <summary> Enable or disable delegation for user registration. </summary>
        public bool? IsUserRegistrationDelegationEnabled { get; set; }
    }
}