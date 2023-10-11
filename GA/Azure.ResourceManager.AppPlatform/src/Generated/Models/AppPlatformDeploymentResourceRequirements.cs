// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Deployment resource request payload. </summary>
    public partial class AppPlatformDeploymentResourceRequirements
    {
        /// <summary> Initializes a new instance of AppPlatformDeploymentResourceRequirements. </summary>
        public AppPlatformDeploymentResourceRequirements()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformDeploymentResourceRequirements. </summary>
        /// <param name="cpu"> Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4} for Standard tier. </param>
        /// <param name="memory"> Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi, 1Gi, 2Gi, ..., 8Gi} for Standard tier. </param>
        internal AppPlatformDeploymentResourceRequirements(string cpu, string memory)
        {
            Cpu = cpu;
            Memory = memory;
        }

        /// <summary> Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4} for Standard tier. </summary>
        public string Cpu { get; set; }
        /// <summary> Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi, 1Gi, 2Gi, ..., 8Gi} for Standard tier. </summary>
        public string Memory { get; set; }
    }
}