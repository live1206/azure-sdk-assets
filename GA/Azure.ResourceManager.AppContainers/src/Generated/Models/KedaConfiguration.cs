// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration properties Keda component. </summary>
    internal partial class KedaConfiguration
    {
        /// <summary> Initializes a new instance of KedaConfiguration. </summary>
        public KedaConfiguration()
        {
        }

        /// <summary> Initializes a new instance of KedaConfiguration. </summary>
        /// <param name="version"> The version of Keda. </param>
        internal KedaConfiguration(string version)
        {
            Version = version;
        }

        /// <summary> The version of Keda. </summary>
        public string Version { get; }
    }
}