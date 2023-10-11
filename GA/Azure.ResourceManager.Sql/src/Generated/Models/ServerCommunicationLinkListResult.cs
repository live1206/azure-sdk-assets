// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of server communication links. </summary>
    internal partial class ServerCommunicationLinkListResult
    {
        /// <summary> Initializes a new instance of ServerCommunicationLinkListResult. </summary>
        internal ServerCommunicationLinkListResult()
        {
            Value = new ChangeTrackingList<SqlServerCommunicationLinkData>();
        }

        /// <summary> Initializes a new instance of ServerCommunicationLinkListResult. </summary>
        /// <param name="value"> The list of server communication links. </param>
        internal ServerCommunicationLinkListResult(IReadOnlyList<SqlServerCommunicationLinkData> value)
        {
            Value = value;
        }

        /// <summary> The list of server communication links. </summary>
        public IReadOnlyList<SqlServerCommunicationLinkData> Value { get; }
    }
}