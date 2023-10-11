// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Defines the properties to access the artifacts using an Azure Storage SAS URI. </summary>
    public partial class SasAuthentication : Authentication
    {
        /// <summary> Initializes a new instance of SasAuthentication. </summary>
        public SasAuthentication()
        {
            AuthenticationType = "Sas";
        }

        /// <summary> Initializes a new instance of SasAuthentication. </summary>
        /// <param name="authenticationType"> The authentication type. </param>
        /// <param name="sasUri"> The SAS URI to the Azure Storage blob container. Any offset from the root of the container to where the artifacts are located can be defined in the artifactRoot. </param>
        internal SasAuthentication(string authenticationType, Uri sasUri) : base(authenticationType)
        {
            SasUri = sasUri;
            AuthenticationType = authenticationType ?? "Sas";
        }

        /// <summary> The SAS URI to the Azure Storage blob container. Any offset from the root of the container to where the artifacts are located can be defined in the artifactRoot. </summary>
        public Uri SasUri { get; set; }
    }
}