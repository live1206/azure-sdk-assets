// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster configs per component. </summary>
    public partial class ClusterServiceConfig
    {
        /// <summary> Initializes a new instance of ClusterServiceConfig. </summary>
        /// <param name="component"> Name of the component the config files should apply to. </param>
        /// <param name="files"> List of Config Files. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="component"/> or <paramref name="files"/> is null. </exception>
        public ClusterServiceConfig(string component, IEnumerable<ClusterConfigFile> files)
        {
            Argument.AssertNotNull(component, nameof(component));
            Argument.AssertNotNull(files, nameof(files));

            Component = component;
            Files = files.ToList();
        }

        /// <summary> Initializes a new instance of ClusterServiceConfig. </summary>
        /// <param name="component"> Name of the component the config files should apply to. </param>
        /// <param name="files"> List of Config Files. </param>
        internal ClusterServiceConfig(string component, IList<ClusterConfigFile> files)
        {
            Component = component;
            Files = files;
        }

        /// <summary> Name of the component the config files should apply to. </summary>
        public string Component { get; set; }
        /// <summary> List of Config Files. </summary>
        public IList<ClusterConfigFile> Files { get; }
    }
}