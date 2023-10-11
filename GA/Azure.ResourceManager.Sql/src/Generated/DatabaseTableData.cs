// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the DatabaseTable data model.
    /// A database table resource.
    /// </summary>
    public partial class DatabaseTableData : ResourceData
    {
        /// <summary> Initializes a new instance of DatabaseTableData. </summary>
        public DatabaseTableData()
        {
        }

        /// <summary> Initializes a new instance of DatabaseTableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="temporalType"> The table temporal type. </param>
        /// <param name="isMemoryOptimized"> Whether or not the table is memory optimized. </param>
        internal DatabaseTableData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TableTemporalType? temporalType, bool? isMemoryOptimized) : base(id, name, resourceType, systemData)
        {
            TemporalType = temporalType;
            IsMemoryOptimized = isMemoryOptimized;
        }

        /// <summary> The table temporal type. </summary>
        public TableTemporalType? TemporalType { get; set; }
        /// <summary> Whether or not the table is memory optimized. </summary>
        public bool? IsMemoryOptimized { get; set; }
    }
}