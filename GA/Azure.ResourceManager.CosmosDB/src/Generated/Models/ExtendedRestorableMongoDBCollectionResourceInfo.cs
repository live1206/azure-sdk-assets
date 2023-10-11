// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB MongoDB collection event. </summary>
    public partial class ExtendedRestorableMongoDBCollectionResourceInfo
    {
        /// <summary> Initializes a new instance of ExtendedRestorableMongoDBCollectionResourceInfo. </summary>
        internal ExtendedRestorableMongoDBCollectionResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of ExtendedRestorableMongoDBCollectionResourceInfo. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this collection event. </param>
        /// <param name="eventTimestamp"> The time when this collection event happened. </param>
        /// <param name="collectionName"> The name of this MongoDB collection. </param>
        /// <param name="collectionId"> The resource ID of this MongoDB collection. </param>
        internal ExtendedRestorableMongoDBCollectionResourceInfo(string rid, CosmosDBOperationType? operationType, string eventTimestamp, string collectionName, string collectionId)
        {
            Rid = rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            CollectionName = collectionName;
            CollectionId = collectionId;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> The operation type of this collection event. </summary>
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> The time when this collection event happened. </summary>
        public string EventTimestamp { get; }
        /// <summary> The name of this MongoDB collection. </summary>
        public string CollectionName { get; }
        /// <summary> The resource ID of this MongoDB collection. </summary>
        public string CollectionId { get; }
    }
}