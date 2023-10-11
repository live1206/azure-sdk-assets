// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a section in the fabric settings of the cluster. </summary>
    public partial class ClusterFabricSettingsSection
    {
        /// <summary> Initializes a new instance of ClusterFabricSettingsSection. </summary>
        /// <param name="name"> The section name of the fabric settings. </param>
        /// <param name="parameters"> The collection of parameters in the section. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public ClusterFabricSettingsSection(string name, IEnumerable<ClusterFabricSettingsParameterDescription> parameters)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));

            Name = name;
            Parameters = parameters.ToList();
        }

        /// <summary> Initializes a new instance of ClusterFabricSettingsSection. </summary>
        /// <param name="name"> The section name of the fabric settings. </param>
        /// <param name="parameters"> The collection of parameters in the section. </param>
        internal ClusterFabricSettingsSection(string name, IList<ClusterFabricSettingsParameterDescription> parameters)
        {
            Name = name;
            Parameters = parameters;
        }

        /// <summary> The section name of the fabric settings. </summary>
        public string Name { get; set; }
        /// <summary> The collection of parameters in the section. </summary>
        public IList<ClusterFabricSettingsParameterDescription> Parameters { get; }
    }
}