// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an Azure SQL database reference input data source. </summary>
    public partial class SqlReferenceInputDataSource : ReferenceInputDataSource
    {
        /// <summary> Initializes a new instance of SqlReferenceInputDataSource. </summary>
        public SqlReferenceInputDataSource()
        {
            ReferenceInputDataSourceType = "Microsoft.Sql/Server/Database";
        }

        /// <summary> Initializes a new instance of SqlReferenceInputDataSource. </summary>
        /// <param name="referenceInputDataSourceType"> Indicates the type of input data source containing reference data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="server"> This element is associated with the datasource element. This is the name of the server that contains the database that will be written to. </param>
        /// <param name="database"> This element is associated with the datasource element. This is the name of the database that output will be written to. </param>
        /// <param name="user"> This element is associated with the datasource element. This is the user name that will be used to connect to the SQL Database instance. </param>
        /// <param name="password"> This element is associated with the datasource element. This is the password that will be used to connect to the SQL Database instance. </param>
        /// <param name="refreshType"> Indicates the type of data refresh option. </param>
        /// <param name="refreshInterval"> This element is associated with the datasource element. This indicates how frequently the data will be fetched from the database. It is of DateTime format. </param>
        /// <param name="fullSnapshotQuery"> This element is associated with the datasource element. This query is used to fetch data from the sql database. </param>
        /// <param name="deltaSnapshotQuery"> This element is associated with the datasource element. This query is used to fetch incremental changes from the SQL database. To use this option, we recommend using temporal tables in Azure SQL Database. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        internal SqlReferenceInputDataSource(string referenceInputDataSourceType, string server, string database, string user, string password, DataRefreshType? refreshType, TimeSpan? refreshInterval, string fullSnapshotQuery, string deltaSnapshotQuery, StreamAnalyticsAuthenticationMode? authenticationMode) : base(referenceInputDataSourceType)
        {
            Server = server;
            Database = database;
            User = user;
            Password = password;
            RefreshType = refreshType;
            RefreshInterval = refreshInterval;
            FullSnapshotQuery = fullSnapshotQuery;
            DeltaSnapshotQuery = deltaSnapshotQuery;
            AuthenticationMode = authenticationMode;
            ReferenceInputDataSourceType = referenceInputDataSourceType ?? "Microsoft.Sql/Server/Database";
        }

        /// <summary> This element is associated with the datasource element. This is the name of the server that contains the database that will be written to. </summary>
        public string Server { get; set; }
        /// <summary> This element is associated with the datasource element. This is the name of the database that output will be written to. </summary>
        public string Database { get; set; }
        /// <summary> This element is associated with the datasource element. This is the user name that will be used to connect to the SQL Database instance. </summary>
        public string User { get; set; }
        /// <summary> This element is associated with the datasource element. This is the password that will be used to connect to the SQL Database instance. </summary>
        public string Password { get; set; }
        /// <summary> Indicates the type of data refresh option. </summary>
        public DataRefreshType? RefreshType { get; set; }
        /// <summary> This element is associated with the datasource element. This indicates how frequently the data will be fetched from the database. It is of DateTime format. </summary>
        public TimeSpan? RefreshInterval { get; set; }
        /// <summary> This element is associated with the datasource element. This query is used to fetch data from the sql database. </summary>
        public string FullSnapshotQuery { get; set; }
        /// <summary> This element is associated with the datasource element. This query is used to fetch incremental changes from the SQL database. To use this option, we recommend using temporal tables in Azure SQL Database. </summary>
        public string DeltaSnapshotQuery { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
    }
}