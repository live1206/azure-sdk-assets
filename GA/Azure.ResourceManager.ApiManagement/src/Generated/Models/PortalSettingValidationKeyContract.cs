// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Client or app secret used in IdentityProviders, Aad, OpenID or OAuth. </summary>
    public partial class PortalSettingValidationKeyContract
    {
        /// <summary> Initializes a new instance of PortalSettingValidationKeyContract. </summary>
        internal PortalSettingValidationKeyContract()
        {
        }

        /// <summary> Initializes a new instance of PortalSettingValidationKeyContract. </summary>
        /// <param name="validationKey"> This is secret value of the validation key in portal settings. </param>
        internal PortalSettingValidationKeyContract(string validationKey)
        {
            ValidationKey = validationKey;
        }

        /// <summary> This is secret value of the validation key in portal settings. </summary>
        public string ValidationKey { get; }
    }
}