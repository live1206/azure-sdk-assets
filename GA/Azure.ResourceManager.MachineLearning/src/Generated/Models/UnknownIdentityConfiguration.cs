// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownIdentityConfiguration. </summary>
    internal partial class UnknownIdentityConfiguration : MachineLearningIdentityConfiguration
    {
        /// <summary> Initializes a new instance of UnknownIdentityConfiguration. </summary>
        /// <param name="identityType"> [Required] Specifies the type of identity framework. </param>
        internal UnknownIdentityConfiguration(IdentityConfigurationType identityType) : base(identityType)
        {
            IdentityType = identityType;
        }
    }
}
