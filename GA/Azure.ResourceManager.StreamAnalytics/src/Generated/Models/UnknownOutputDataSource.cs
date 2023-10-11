// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownOutputDataSource. </summary>
    internal partial class UnknownOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of UnknownOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        internal UnknownOutputDataSource(string outputDataSourceType) : base(outputDataSourceType)
        {
            OutputDataSourceType = outputDataSourceType ?? "Unknown";
        }
    }
}
