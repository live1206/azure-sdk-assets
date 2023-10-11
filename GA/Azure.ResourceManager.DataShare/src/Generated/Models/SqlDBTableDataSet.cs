// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A SQL DB table data set. </summary>
    public partial class SqlDBTableDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of SqlDBTableDataSet. </summary>
        public SqlDBTableDataSet()
        {
            Kind = DataSetKind.SqlDBTable;
        }

        /// <summary> Initializes a new instance of SqlDBTableDataSet. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="databaseName"> Database name of the source data set. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="schemaName"> Schema of the table. Default value is dbo. </param>
        /// <param name="sqlServerResourceId"> Resource id of SQL server. </param>
        /// <param name="tableName"> SQL DB table name. </param>
        internal SqlDBTableDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, string databaseName, Guid? dataSetId, string schemaName, ResourceIdentifier sqlServerResourceId, string tableName) : base(id, name, resourceType, systemData, kind)
        {
            DatabaseName = databaseName;
            DataSetId = dataSetId;
            SchemaName = schemaName;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            Kind = kind;
        }

        /// <summary> Database name of the source data set. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Schema of the table. Default value is dbo. </summary>
        public string SchemaName { get; set; }
        /// <summary> Resource id of SQL server. </summary>
        public ResourceIdentifier SqlServerResourceId { get; set; }
        /// <summary> SQL DB table name. </summary>
        public string TableName { get; set; }
    }
}