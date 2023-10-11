// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing the WidgetTypeResourceFormat data model.
    /// The WidgetTypeResourceFormat
    /// </summary>
    public partial class WidgetTypeResourceFormatData : ResourceData
    {
        /// <summary> Initializes a new instance of WidgetTypeResourceFormatData. </summary>
        public WidgetTypeResourceFormatData()
        {
            DisplayName = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of WidgetTypeResourceFormatData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="widgetTypeName"> Name of the widget type. </param>
        /// <param name="definition"> Definition for widget type. </param>
        /// <param name="description"> Description for widget type. </param>
        /// <param name="displayName"> Localized display name for the widget type. </param>
        /// <param name="imageUri"> The image URL. </param>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="widgetVersion"> The widget version. </param>
        /// <param name="changed"> Date time when widget type was last modified. </param>
        /// <param name="created"> Date time when widget type was created. </param>
        internal WidgetTypeResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string widgetTypeName, string definition, string description, IDictionary<string, string> displayName, Uri imageUri, Guid? tenantId, string widgetVersion, DateTimeOffset? changed, DateTimeOffset? created) : base(id, name, resourceType, systemData)
        {
            WidgetTypeName = widgetTypeName;
            Definition = definition;
            Description = description;
            DisplayName = displayName;
            ImageUri = imageUri;
            TenantId = tenantId;
            WidgetVersion = widgetVersion;
            Changed = changed;
            Created = created;
        }

        /// <summary> Name of the widget type. </summary>
        public string WidgetTypeName { get; }
        /// <summary> Definition for widget type. </summary>
        public string Definition { get; set; }
        /// <summary> Description for widget type. </summary>
        public string Description { get; set; }
        /// <summary> Localized display name for the widget type. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> The image URL. </summary>
        public Uri ImageUri { get; set; }
        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> The widget version. </summary>
        public string WidgetVersion { get; set; }
        /// <summary> Date time when widget type was last modified. </summary>
        public DateTimeOffset? Changed { get; }
        /// <summary> Date time when widget type was created. </summary>
        public DateTimeOffset? Created { get; }
    }
}