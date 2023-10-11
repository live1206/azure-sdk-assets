// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownEnvironmentData. </summary>
    internal partial class UnknownEnvironmentData : SecurityConnectorEnvironment
    {
        /// <summary> Initializes a new instance of UnknownEnvironmentData. </summary>
        /// <param name="environmentType"> The type of the environment data. </param>
        internal UnknownEnvironmentData(EnvironmentType environmentType) : base(environmentType)
        {
            EnvironmentType = environmentType;
        }
    }
}