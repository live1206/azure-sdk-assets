// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Properties that define an Analytics item that is associated to an Application Insights component. </summary>
    public partial class ApplicationInsightsComponentAnalyticsItem
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentAnalyticsItem. </summary>
        public ApplicationInsightsComponentAnalyticsItem()
        {
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentAnalyticsItem. </summary>
        /// <param name="id"> Internally assigned unique id of the item definition. </param>
        /// <param name="name"> The user-defined name of the item. </param>
        /// <param name="content"> The content of this item. </param>
        /// <param name="version"> This instance's version of the data model. This can change as new features are added. </param>
        /// <param name="scope"> Enum indicating if this item definition is owned by a specific user or is shared between all users with access to the Application Insights component. </param>
        /// <param name="itemType"> Enum indicating the type of the Analytics item. </param>
        /// <param name="timeCreated"> Date and time in UTC when this item was created. </param>
        /// <param name="timeModified"> Date and time in UTC of the last modification that was made to this item. </param>
        /// <param name="properties"> A set of properties that can be defined in the context of a specific item type. Each type may have its own properties. </param>
        internal ApplicationInsightsComponentAnalyticsItem(string id, string name, string content, string version, ItemScope? scope, ItemType? itemType, string timeCreated, string timeModified, ApplicationInsightsComponentAnalyticsItemProperties properties)
        {
            Id = id;
            Name = name;
            Content = content;
            Version = version;
            Scope = scope;
            ItemType = itemType;
            TimeCreated = timeCreated;
            TimeModified = timeModified;
            Properties = properties;
        }

        /// <summary> Internally assigned unique id of the item definition. </summary>
        public string Id { get; set; }
        /// <summary> The user-defined name of the item. </summary>
        public string Name { get; set; }
        /// <summary> The content of this item. </summary>
        public string Content { get; set; }
        /// <summary> This instance's version of the data model. This can change as new features are added. </summary>
        public string Version { get; }
        /// <summary> Enum indicating if this item definition is owned by a specific user or is shared between all users with access to the Application Insights component. </summary>
        public ItemScope? Scope { get; set; }
        /// <summary> Enum indicating the type of the Analytics item. </summary>
        public ItemType? ItemType { get; set; }
        /// <summary> Date and time in UTC when this item was created. </summary>
        public string TimeCreated { get; }
        /// <summary> Date and time in UTC of the last modification that was made to this item. </summary>
        public string TimeModified { get; }
        /// <summary> A set of properties that can be defined in the context of a specific item type. Each type may have its own properties. </summary>
        internal ApplicationInsightsComponentAnalyticsItemProperties Properties { get; set; }
        /// <summary> A function alias, used when the type of the item is Function. </summary>
        public string ApplicationInsightsComponentAnalyticsItemFunctionAlias
        {
            get => Properties is null ? default : Properties.FunctionAlias;
            set
            {
                if (Properties is null)
                    Properties = new ApplicationInsightsComponentAnalyticsItemProperties();
                Properties.FunctionAlias = value;
            }
        }
    }
}