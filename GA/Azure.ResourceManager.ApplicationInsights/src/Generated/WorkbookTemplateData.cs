// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing the WorkbookTemplate data model.
    /// An Application Insights workbook template definition.
    /// </summary>
    public partial class WorkbookTemplateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of WorkbookTemplateData. </summary>
        /// <param name="location"> The location. </param>
        public WorkbookTemplateData(AzureLocation location) : base(location)
        {
            Galleries = new ChangeTrackingList<WorkbookTemplateGallery>();
            LocalizedGalleries = new ChangeTrackingDictionary<string, IList<WorkbookTemplateLocalizedGallery>>();
        }

        /// <summary> Initializes a new instance of WorkbookTemplateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="priority"> Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. </param>
        /// <param name="author"> Information about the author of the workbook template. </param>
        /// <param name="templateData"> Valid JSON object containing workbook template payload. </param>
        /// <param name="galleries"> Workbook galleries supported by the template. </param>
        /// <param name="localizedGalleries"> Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal. </param>
        internal WorkbookTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, int? priority, string author, BinaryData templateData, IList<WorkbookTemplateGallery> galleries, IDictionary<string, IList<WorkbookTemplateLocalizedGallery>> localizedGalleries) : base(id, name, resourceType, systemData, tags, location)
        {
            Priority = priority;
            Author = author;
            TemplateData = templateData;
            Galleries = galleries;
            LocalizedGalleries = localizedGalleries;
        }

        /// <summary> Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. </summary>
        public int? Priority { get; set; }
        /// <summary> Information about the author of the workbook template. </summary>
        public string Author { get; set; }
        /// <summary>
        /// Valid JSON object containing workbook template payload.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData TemplateData { get; set; }
        /// <summary> Workbook galleries supported by the template. </summary>
        public IList<WorkbookTemplateGallery> Galleries { get; }
        /// <summary> Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal. </summary>
        public IDictionary<string, IList<WorkbookTemplateLocalizedGallery>> LocalizedGalleries { get; }
    }
}