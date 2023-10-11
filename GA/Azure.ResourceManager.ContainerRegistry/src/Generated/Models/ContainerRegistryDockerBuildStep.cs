// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The Docker build step. </summary>
    public partial class ContainerRegistryDockerBuildStep : ContainerRegistryTaskStepProperties
    {
        /// <summary> Initializes a new instance of ContainerRegistryDockerBuildStep. </summary>
        /// <param name="dockerFilePath"> The Docker file path relative to the source context. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dockerFilePath"/> is null. </exception>
        public ContainerRegistryDockerBuildStep(string dockerFilePath)
        {
            Argument.AssertNotNull(dockerFilePath, nameof(dockerFilePath));

            ImageNames = new ChangeTrackingList<string>();
            DockerFilePath = dockerFilePath;
            Arguments = new ChangeTrackingList<ContainerRegistryRunArgument>();
            ContainerRegistryTaskStepType = ContainerRegistryTaskStepType.Docker;
        }

        /// <summary> Initializes a new instance of ContainerRegistryDockerBuildStep. </summary>
        /// <param name="containerRegistryTaskStepType"> The type of the step. </param>
        /// <param name="baseImageDependencies"> List of base image dependencies for a step. </param>
        /// <param name="contextPath"> The URL(absolute or relative) of the source context for the task step. </param>
        /// <param name="contextAccessToken"> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </param>
        /// <param name="imageNames"> The fully qualified image names including the repository and tag. </param>
        /// <param name="isPushEnabled"> The value of this property indicates whether the image built should be pushed to the registry or not. </param>
        /// <param name="noCache"> The value of this property indicates whether the image cache is enabled or not. </param>
        /// <param name="dockerFilePath"> The Docker file path relative to the source context. </param>
        /// <param name="target"> The name of the target build stage for the docker build. </param>
        /// <param name="arguments"> The collection of override arguments to be used when executing this build step. </param>
        internal ContainerRegistryDockerBuildStep(ContainerRegistryTaskStepType containerRegistryTaskStepType, IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies, string contextPath, string contextAccessToken, IList<string> imageNames, bool? isPushEnabled, bool? noCache, string dockerFilePath, string target, IList<ContainerRegistryRunArgument> arguments) : base(containerRegistryTaskStepType, baseImageDependencies, contextPath, contextAccessToken)
        {
            ImageNames = imageNames;
            IsPushEnabled = isPushEnabled;
            NoCache = noCache;
            DockerFilePath = dockerFilePath;
            Target = target;
            Arguments = arguments;
            ContainerRegistryTaskStepType = containerRegistryTaskStepType;
        }

        /// <summary> The fully qualified image names including the repository and tag. </summary>
        public IList<string> ImageNames { get; }
        /// <summary> The value of this property indicates whether the image built should be pushed to the registry or not. </summary>
        public bool? IsPushEnabled { get; set; }
        /// <summary> The value of this property indicates whether the image cache is enabled or not. </summary>
        public bool? NoCache { get; set; }
        /// <summary> The Docker file path relative to the source context. </summary>
        public string DockerFilePath { get; set; }
        /// <summary> The name of the target build stage for the docker build. </summary>
        public string Target { get; set; }
        /// <summary> The collection of override arguments to be used when executing this build step. </summary>
        public IList<ContainerRegistryRunArgument> Arguments { get; }
    }
}