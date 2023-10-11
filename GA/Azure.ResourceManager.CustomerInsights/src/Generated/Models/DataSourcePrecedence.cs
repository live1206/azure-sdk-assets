// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The data source precedence is a way to know the precedence of each data source. </summary>
    public partial class DataSourcePrecedence
    {
        /// <summary> Initializes a new instance of DataSourcePrecedence. </summary>
        internal DataSourcePrecedence()
        {
        }

        /// <summary> Initializes a new instance of DataSourcePrecedence. </summary>
        /// <param name="precedence"> the precedence value. </param>
        /// <param name="name"> The data source name. </param>
        /// <param name="dataSourceType"> The data source type. </param>
        /// <param name="status"> The data source status. </param>
        /// <param name="id"> The data source ID. </param>
        /// <param name="dataSourceReferenceId"> The data source reference id. </param>
        internal DataSourcePrecedence(int? precedence, string name, DataSourceType? dataSourceType, Status? status, int? id, string dataSourceReferenceId)
        {
            Precedence = precedence;
            Name = name;
            DataSourceType = dataSourceType;
            Status = status;
            Id = id;
            DataSourceReferenceId = dataSourceReferenceId;
        }

        /// <summary> the precedence value. </summary>
        public int? Precedence { get; }
        /// <summary> The data source name. </summary>
        public string Name { get; }
        /// <summary> The data source type. </summary>
        public DataSourceType? DataSourceType { get; }
        /// <summary> The data source status. </summary>
        public Status? Status { get; }
        /// <summary> The data source ID. </summary>
        public int? Id { get; }
        /// <summary> The data source reference id. </summary>
        public string DataSourceReferenceId { get; }
    }
}