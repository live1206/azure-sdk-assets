// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Immutability Settings of vault. </summary>
    internal partial class ImmutabilitySettings
    {
        /// <summary> Initializes a new instance of ImmutabilitySettings. </summary>
        public ImmutabilitySettings()
        {
        }

        /// <summary> Initializes a new instance of ImmutabilitySettings. </summary>
        /// <param name="state"></param>
        internal ImmutabilitySettings(ImmutabilityState? state)
        {
            State = state;
        }

        /// <summary> Gets or sets the state. </summary>
        public ImmutabilityState? State { get; set; }
    }
}