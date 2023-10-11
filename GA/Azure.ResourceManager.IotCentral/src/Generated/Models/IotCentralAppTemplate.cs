// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> IoT Central Application Template. </summary>
    public partial class IotCentralAppTemplate
    {
        /// <summary> Initializes a new instance of IotCentralAppTemplate. </summary>
        internal IotCentralAppTemplate()
        {
            Locations = new ChangeTrackingList<IotCentralAppTemplateLocation>();
        }

        /// <summary> Initializes a new instance of IotCentralAppTemplate. </summary>
        /// <param name="manifestId"> The ID of the template. </param>
        /// <param name="manifestVersion"> The version of the template. </param>
        /// <param name="name"> The name of the template. </param>
        /// <param name="title"> The title of the template. </param>
        /// <param name="order"> The order of the template in the templates list. </param>
        /// <param name="description"> The description of the template. </param>
        /// <param name="industry"> The industry of the template. </param>
        /// <param name="locations"> A list of locations that support the template. </param>
        internal IotCentralAppTemplate(string manifestId, string manifestVersion, string name, string title, int? order, string description, string industry, IReadOnlyList<IotCentralAppTemplateLocation> locations)
        {
            ManifestId = manifestId;
            ManifestVersion = manifestVersion;
            Name = name;
            Title = title;
            Order = order;
            Description = description;
            Industry = industry;
            Locations = locations;
        }

        /// <summary> The ID of the template. </summary>
        public string ManifestId { get; }
        /// <summary> The version of the template. </summary>
        public string ManifestVersion { get; }
        /// <summary> The name of the template. </summary>
        public string Name { get; }
        /// <summary> The title of the template. </summary>
        public string Title { get; }
        /// <summary> The order of the template in the templates list. </summary>
        public int? Order { get; }
        /// <summary> The description of the template. </summary>
        public string Description { get; }
        /// <summary> The industry of the template. </summary>
        public string Industry { get; }
        /// <summary> A list of locations that support the template. </summary>
        public IReadOnlyList<IotCentralAppTemplateLocation> Locations { get; }
    }
}