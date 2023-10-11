// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The type of the paths for alias. </summary>
    public partial class ResourceTypeAliasPath
    {
        /// <summary> Initializes a new instance of ResourceTypeAliasPath. </summary>
        internal ResourceTypeAliasPath()
        {
            ApiVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ResourceTypeAliasPath. </summary>
        /// <param name="path"> The path of an alias. </param>
        /// <param name="apiVersions"> The API versions. </param>
        /// <param name="pattern"> The pattern for an alias path. </param>
        /// <param name="metadata"> The metadata of the alias path. If missing, fall back to the default metadata of the alias. </param>
        internal ResourceTypeAliasPath(string path, IReadOnlyList<string> apiVersions, ResourceTypeAliasPattern pattern, ResourceTypeAliasPathMetadata metadata)
        {
            Path = path;
            ApiVersions = apiVersions;
            Pattern = pattern;
            Metadata = metadata;
        }

        /// <summary> The path of an alias. </summary>
        public string Path { get; }
        /// <summary> The API versions. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> The pattern for an alias path. </summary>
        public ResourceTypeAliasPattern Pattern { get; }
        /// <summary> The metadata of the alias path. If missing, fall back to the default metadata of the alias. </summary>
        public ResourceTypeAliasPathMetadata Metadata { get; }
    }
}