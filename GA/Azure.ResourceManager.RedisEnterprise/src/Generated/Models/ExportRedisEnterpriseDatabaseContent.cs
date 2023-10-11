// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Parameters for a Redis Enterprise export operation. </summary>
    public partial class ExportRedisEnterpriseDatabaseContent
    {
        /// <summary> Initializes a new instance of ExportRedisEnterpriseDatabaseContent. </summary>
        /// <param name="sasUri"> SAS URI for the target directory to export to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUri"/> is null. </exception>
        public ExportRedisEnterpriseDatabaseContent(Uri sasUri)
        {
            Argument.AssertNotNull(sasUri, nameof(sasUri));

            SasUri = sasUri;
        }

        /// <summary> SAS URI for the target directory to export to. </summary>
        public Uri SasUri { get; }
    }
}