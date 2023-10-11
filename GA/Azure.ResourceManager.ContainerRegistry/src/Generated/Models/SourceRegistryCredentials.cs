// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Describes the credential parameters for accessing the source registry. </summary>
    internal partial class SourceRegistryCredentials
    {
        /// <summary> Initializes a new instance of SourceRegistryCredentials. </summary>
        public SourceRegistryCredentials()
        {
        }

        /// <summary> Initializes a new instance of SourceRegistryCredentials. </summary>
        /// <param name="loginMode">
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </param>
        internal SourceRegistryCredentials(SourceRegistryLoginMode? loginMode)
        {
            LoginMode = loginMode;
        }

        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        public SourceRegistryLoginMode? LoginMode { get; set; }
    }
}