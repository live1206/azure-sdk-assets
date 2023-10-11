// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of get log link operation. </summary>
    public partial class ContainerRegistryRunGetLogResult
    {
        /// <summary> Initializes a new instance of ContainerRegistryRunGetLogResult. </summary>
        internal ContainerRegistryRunGetLogResult()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryRunGetLogResult. </summary>
        /// <param name="logLink"> The link to logs for a run on a azure container registry. </param>
        /// <param name="logArtifactLink"> The link to logs in registry for a run on a azure container registry. </param>
        internal ContainerRegistryRunGetLogResult(string logLink, string logArtifactLink)
        {
            LogLink = logLink;
            LogArtifactLink = logArtifactLink;
        }

        /// <summary> The link to logs for a run on a azure container registry. </summary>
        public string LogLink { get; }
        /// <summary> The link to logs in registry for a run on a azure container registry. </summary>
        public string LogArtifactLink { get; }
    }
}