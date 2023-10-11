// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the ScriptPackage data model.
    /// Script Package resources available for execution
    /// </summary>
    public partial class ScriptPackageData : ResourceData
    {
        /// <summary> Initializes a new instance of ScriptPackageData. </summary>
        public ScriptPackageData()
        {
        }

        /// <summary> Initializes a new instance of ScriptPackageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> User friendly description of the package. </param>
        /// <param name="version"> Module version. </param>
        /// <param name="company"> Company that created and supports the package. </param>
        /// <param name="uri"> Link to support by the package vendor. </param>
        internal ScriptPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string version, string company, Uri uri) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Version = version;
            Company = company;
            Uri = uri;
        }

        /// <summary> User friendly description of the package. </summary>
        public string Description { get; }
        /// <summary> Module version. </summary>
        public string Version { get; }
        /// <summary> Company that created and supports the package. </summary>
        public string Company { get; }
        /// <summary> Link to support by the package vendor. </summary>
        public Uri Uri { get; }
    }
}