// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the RestorableDroppedManagedDatabase data model.
    /// A restorable dropped managed database resource.
    /// </summary>
    public partial class RestorableDroppedManagedDatabaseData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of RestorableDroppedManagedDatabaseData. </summary>
        /// <param name="location"> The location. </param>
        public RestorableDroppedManagedDatabaseData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of RestorableDroppedManagedDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="createdOn"> The creation date of the database (ISO8601 format). </param>
        /// <param name="deletedOn"> The deletion date of the database (ISO8601 format). </param>
        /// <param name="earliestRestoreOn"> The earliest restore date of the database (ISO8601 format). </param>
        internal RestorableDroppedManagedDatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string databaseName, DateTimeOffset? createdOn, DateTimeOffset? deletedOn, DateTimeOffset? earliestRestoreOn) : base(id, name, resourceType, systemData, tags, location)
        {
            DatabaseName = databaseName;
            CreatedOn = createdOn;
            DeletedOn = deletedOn;
            EarliestRestoreOn = earliestRestoreOn;
        }

        /// <summary> The name of the database. </summary>
        public string DatabaseName { get; }
        /// <summary> The creation date of the database (ISO8601 format). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The deletion date of the database (ISO8601 format). </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The earliest restore date of the database (ISO8601 format). </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
    }
}