// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity snowflake source. </summary>
    public partial class SnowflakeSource : CopyActivitySource
    {
        /// <summary> Initializes a new instance of SnowflakeSource. </summary>
        /// <param name="exportSettings"> Snowflake export settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportSettings"/> is null. </exception>
        public SnowflakeSource(SnowflakeExportCopyCommand exportSettings)
        {
            Argument.AssertNotNull(exportSettings, nameof(exportSettings));

            ExportSettings = exportSettings;
            CopySourceType = "SnowflakeSource";
        }

        /// <summary> Initializes a new instance of SnowflakeSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> Snowflake Sql query. Type: string (or Expression with resultType string). </param>
        /// <param name="exportSettings"> Snowflake export settings. </param>
        internal SnowflakeSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> query, SnowflakeExportCopyCommand exportSettings) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Query = query;
            ExportSettings = exportSettings;
            CopySourceType = copySourceType ?? "SnowflakeSource";
        }

        /// <summary> Snowflake Sql query. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Query { get; set; }
        /// <summary> Snowflake export settings. </summary>
        public SnowflakeExportCopyCommand ExportSettings { get; set; }
    }
}