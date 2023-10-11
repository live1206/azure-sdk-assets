// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating a docker build step. </summary>
    public partial class ContainerRegistryDockerBuildStepUpdateContent : ContainerRegistryTaskStepUpdateContent
    {
        /// <summary> Initializes a new instance of ContainerRegistryDockerBuildStepUpdateContent. </summary>
        public ContainerRegistryDockerBuildStepUpdateContent()
        {
            ImageNames = new ChangeTrackingList<string>();
            Arguments = new ChangeTrackingList<ContainerRegistryRunArgument>();
            StepType = ContainerRegistryTaskStepType.Docker;
        }

        /// <summary> The fully qualified image names including the repository and tag. </summary>
        public IList<string> ImageNames { get; }
        /// <summary> The value of this property indicates whether the image built should be pushed to the registry or not. </summary>
        public bool? IsPushEnabled { get; set; }
        /// <summary> The value of this property indicates whether the image cache is enabled or not. </summary>
        public bool? NoCache { get; set; }
        /// <summary> The Docker file path relative to the source context. </summary>
        public string DockerFilePath { get; set; }
        /// <summary> The collection of override arguments to be used when executing this build step. </summary>
        public IList<ContainerRegistryRunArgument> Arguments { get; }
        /// <summary> The name of the target build stage for the docker build. </summary>
        public string Target { get; set; }
    }
}