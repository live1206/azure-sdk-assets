// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Capture Virtual Machine parameters. </summary>
    public partial class VirtualMachineCaptureContent
    {
        /// <summary> Initializes a new instance of VirtualMachineCaptureContent. </summary>
        /// <param name="vhdPrefix"> The captured virtual hard disk's name prefix. </param>
        /// <param name="destinationContainerName"> The destination container name. </param>
        /// <param name="overwriteVhds"> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vhdPrefix"/> or <paramref name="destinationContainerName"/> is null. </exception>
        public VirtualMachineCaptureContent(string vhdPrefix, string destinationContainerName, bool overwriteVhds)
        {
            Argument.AssertNotNull(vhdPrefix, nameof(vhdPrefix));
            Argument.AssertNotNull(destinationContainerName, nameof(destinationContainerName));

            VhdPrefix = vhdPrefix;
            DestinationContainerName = destinationContainerName;
            OverwriteVhds = overwriteVhds;
        }

        /// <summary> The captured virtual hard disk's name prefix. </summary>
        public string VhdPrefix { get; }
        /// <summary> The destination container name. </summary>
        public string DestinationContainerName { get; }
        /// <summary> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </summary>
        public bool OverwriteVhds { get; }
    }
}
