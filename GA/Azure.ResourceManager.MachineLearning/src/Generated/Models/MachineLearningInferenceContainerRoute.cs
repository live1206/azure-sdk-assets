// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningInferenceContainerRoute. </summary>
    public partial class MachineLearningInferenceContainerRoute
    {
        /// <summary> Initializes a new instance of MachineLearningInferenceContainerRoute. </summary>
        /// <param name="path"> [Required] The path for the route. </param>
        /// <param name="port"> [Required] The port for the route. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public MachineLearningInferenceContainerRoute(string path, int port)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
            Port = port;
        }

        /// <summary> [Required] The path for the route. </summary>
        public string Path { get; set; }
        /// <summary> [Required] The port for the route. </summary>
        public int Port { get; set; }
    }
}