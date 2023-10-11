// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> An Open Container Initiative (OCI) artifact. </summary>
    public partial class HealthcareApisServiceOciArtifactEntry
    {
        /// <summary> Initializes a new instance of HealthcareApisServiceOciArtifactEntry. </summary>
        public HealthcareApisServiceOciArtifactEntry()
        {
        }

        /// <summary> Initializes a new instance of HealthcareApisServiceOciArtifactEntry. </summary>
        /// <param name="loginServer"> The Azure Container Registry login server. </param>
        /// <param name="imageName"> The artifact name. </param>
        /// <param name="digest"> The artifact digest. </param>
        internal HealthcareApisServiceOciArtifactEntry(string loginServer, string imageName, string digest)
        {
            LoginServer = loginServer;
            ImageName = imageName;
            Digest = digest;
        }

        /// <summary> The Azure Container Registry login server. </summary>
        public string LoginServer { get; set; }
        /// <summary> The artifact name. </summary>
        public string ImageName { get; set; }
        /// <summary> The artifact digest. </summary>
        public string Digest { get; set; }
    }
}