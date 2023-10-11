// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> VM Sizes properties. </summary>
    internal partial class VmSize
    {
        /// <summary> Initializes a new instance of VmSize. </summary>
        internal VmSize()
        {
        }

        /// <summary> Initializes a new instance of VmSize. </summary>
        /// <param name="size"> VM Size name. </param>
        internal VmSize(string size)
        {
            Size = size;
        }

        /// <summary> VM Size name. </summary>
        public string Size { get; }
    }
}