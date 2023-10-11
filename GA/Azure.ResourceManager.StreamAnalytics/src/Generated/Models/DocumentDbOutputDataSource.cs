// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a DocumentDB output data source. </summary>
    public partial class DocumentDbOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of DocumentDbOutputDataSource. </summary>
        public DocumentDbOutputDataSource()
        {
            OutputDataSourceType = "Microsoft.Storage/DocumentDB";
        }

        /// <summary> Initializes a new instance of DocumentDbOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="accountId"> The DocumentDB account name or ID. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="accountKey"> The account key for the DocumentDB account. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="database"> The name of the DocumentDB database. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="collectionNamePattern"> The collection name pattern for the collections to be used. The collection name format can be constructed using the optional {partition} token, where partitions start from 0. See the DocumentDB section of https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for more information. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="partitionKey"> The name of the field in output events used to specify the key for partitioning output across collections. If 'collectionNamePattern' contains the {partition} token, this property is required to be specified. </param>
        /// <param name="documentId"> The name of the field in output events used to specify the primary key which insert or update operations are based on. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        internal DocumentDbOutputDataSource(string outputDataSourceType, string accountId, string accountKey, string database, string collectionNamePattern, string partitionKey, string documentId, StreamAnalyticsAuthenticationMode? authenticationMode) : base(outputDataSourceType)
        {
            AccountId = accountId;
            AccountKey = accountKey;
            Database = database;
            CollectionNamePattern = collectionNamePattern;
            PartitionKey = partitionKey;
            DocumentId = documentId;
            AuthenticationMode = authenticationMode;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.Storage/DocumentDB";
        }

        /// <summary> The DocumentDB account name or ID. Required on PUT (CreateOrReplace) requests. </summary>
        public string AccountId { get; set; }
        /// <summary> The account key for the DocumentDB account. Required on PUT (CreateOrReplace) requests. </summary>
        public string AccountKey { get; set; }
        /// <summary> The name of the DocumentDB database. Required on PUT (CreateOrReplace) requests. </summary>
        public string Database { get; set; }
        /// <summary> The collection name pattern for the collections to be used. The collection name format can be constructed using the optional {partition} token, where partitions start from 0. See the DocumentDB section of https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for more information. Required on PUT (CreateOrReplace) requests. </summary>
        public string CollectionNamePattern { get; set; }
        /// <summary> The name of the field in output events used to specify the key for partitioning output across collections. If 'collectionNamePattern' contains the {partition} token, this property is required to be specified. </summary>
        public string PartitionKey { get; set; }
        /// <summary> The name of the field in output events used to specify the primary key which insert or update operations are based on. </summary>
        public string DocumentId { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
    }
}