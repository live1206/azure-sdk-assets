// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB Table event. </summary>
    public partial class ExtendedRestorableTableResourceInfo
    {
        /// <summary> Initializes a new instance of ExtendedRestorableTableResourceInfo. </summary>
        internal ExtendedRestorableTableResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of ExtendedRestorableTableResourceInfo. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this table event. </param>
        /// <param name="eventTimestamp"> The time when this table event happened. </param>
        /// <param name="tableName"> The name of this Table. </param>
        /// <param name="tableId"> The resource ID of this Table. </param>
        internal ExtendedRestorableTableResourceInfo(string rid, CosmosDBOperationType? operationType, string eventTimestamp, string tableName, string tableId)
        {
            Rid = rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            TableName = tableName;
            TableId = tableId;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> The operation type of this table event. </summary>
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> The time when this table event happened. </summary>
        public string EventTimestamp { get; }
        /// <summary> The name of this Table. </summary>
        public string TableName { get; }
        /// <summary> The resource ID of this Table. </summary>
        public string TableId { get; }
    }
}