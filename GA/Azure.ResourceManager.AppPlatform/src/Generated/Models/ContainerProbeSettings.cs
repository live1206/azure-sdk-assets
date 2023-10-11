// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Container liveness and readiness probe settings. </summary>
    internal partial class ContainerProbeSettings
    {
        /// <summary> Initializes a new instance of ContainerProbeSettings. </summary>
        public ContainerProbeSettings()
        {
        }

        /// <summary> Initializes a new instance of ContainerProbeSettings. </summary>
        /// <param name="isProbeDisabled"> Indicates whether disable the liveness and readiness probe. </param>
        internal ContainerProbeSettings(bool? isProbeDisabled)
        {
            IsProbeDisabled = isProbeDisabled;
        }

        /// <summary> Indicates whether disable the liveness and readiness probe. </summary>
        public bool? IsProbeDisabled { get; set; }
    }
}