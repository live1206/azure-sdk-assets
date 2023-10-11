// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmChangeAnalysisModelFactory
    {
        /// <summary> Initializes a new instance of DetectedChangeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a change. </param>
        /// <returns> A new <see cref="Models.DetectedChangeData"/> instance for mocking. </returns>
        public static DetectedChangeData DetectedChangeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ChangeProperties properties = null)
        {
            return new DetectedChangeData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of ChangeProperties. </summary>
        /// <param name="resourceId"> The resource id that the change is attached to. </param>
        /// <param name="changeDetectedOn"> The time when the change is detected. </param>
        /// <param name="initiatedByList">
        /// The list of identities who might initiated the change.
        /// The identity could be user name (email address) or the object ID of the Service Principal.
        /// </param>
        /// <param name="changeType"> The type of the change. </param>
        /// <param name="propertyChanges"> The list of detailed changes at json property level. </param>
        /// <returns> A new <see cref="Models.ChangeProperties"/> instance for mocking. </returns>
        public static ChangeProperties ChangeProperties(ResourceIdentifier resourceId = null, DateTimeOffset? changeDetectedOn = null, IEnumerable<string> initiatedByList = null, ChangeType? changeType = null, IEnumerable<PropertyChange> propertyChanges = null)
        {
            initiatedByList ??= new List<string>();
            propertyChanges ??= new List<PropertyChange>();

            return new ChangeProperties(resourceId, changeDetectedOn, initiatedByList?.ToList(), changeType, propertyChanges?.ToList());
        }

        /// <summary> Initializes a new instance of PropertyChange. </summary>
        /// <param name="changeType"> The type of the change. </param>
        /// <param name="changeCategory"> The change category. </param>
        /// <param name="jsonPath"> The json path of the changed property. </param>
        /// <param name="displayName"> The enhanced display name of the json path. E.g., the json path value[0].properties will be translated to something meaningful like slots["Staging"].properties. </param>
        /// <param name="level"></param>
        /// <param name="description"> The description of the changed property. </param>
        /// <param name="oldValue"> The value of the property before the change. </param>
        /// <param name="newValue"> The value of the property after the change. </param>
        /// <param name="isDataMasked"> The boolean indicating whether the oldValue and newValue are masked. The values are masked if it contains sensitive information that the user doesn't have access to. </param>
        /// <returns> A new <see cref="Models.PropertyChange"/> instance for mocking. </returns>
        public static PropertyChange PropertyChange(ChangeType? changeType = null, ChangeCategory? changeCategory = null, string jsonPath = null, string displayName = null, PropertyChangeLevel? level = null, string description = null, string oldValue = null, string newValue = null, bool? isDataMasked = null)
        {
            return new PropertyChange(changeType, changeCategory, jsonPath, displayName, level, description, oldValue, newValue, isDataMasked);
        }
    }
}