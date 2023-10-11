// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Response for a migration of app content request. </summary>
    public partial class StorageMigrationResult : ResourceData
    {
        /// <summary> Initializes a new instance of StorageMigrationResult. </summary>
        public StorageMigrationResult()
        {
        }

        /// <summary> Initializes a new instance of StorageMigrationResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="operationId"> When server starts the migration process, it will return an operation ID identifying that particular migration operation. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StorageMigrationResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string operationId, string kind) : base(id, name, resourceType, systemData)
        {
            OperationId = operationId;
            Kind = kind;
        }

        /// <summary> When server starts the migration process, it will return an operation ID identifying that particular migration operation. </summary>
        public string OperationId { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}