// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Dicom Service patch properties. </summary>
    public partial class DicomServicePatch : HealthcareApisResourceTags
    {
        /// <summary> Initializes a new instance of DicomServicePatch. </summary>
        public DicomServicePatch()
        {
        }

        /// <summary> Initializes a new instance of DicomServicePatch. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        internal DicomServicePatch(IDictionary<string, string> tags, ManagedServiceIdentity identity) : base(tags)
        {
            Identity = identity;
        }

        /// <summary> Setting indicating whether the service has a managed identity associated with it. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}