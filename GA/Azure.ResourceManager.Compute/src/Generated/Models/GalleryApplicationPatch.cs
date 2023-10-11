// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Definition that you want to update. </summary>
    public partial class GalleryApplicationPatch : ResourceData
    {
        /// <summary> Initializes a new instance of GalleryApplicationPatch. </summary>
        public GalleryApplicationPatch()
        {
            CustomActions = new ChangeTrackingList<GalleryApplicationCustomAction>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The description of this gallery Application Definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery Application Definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public Uri PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public Uri ReleaseNoteUri { get; set; }
        /// <summary> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; set; }
        /// <summary> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public SupportedOperatingSystemType? SupportedOSType { get; set; }
        /// <summary> A list of custom actions that can be performed with all of the Gallery Application Versions within this Gallery Application. </summary>
        public IList<GalleryApplicationCustomAction> CustomActions { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}