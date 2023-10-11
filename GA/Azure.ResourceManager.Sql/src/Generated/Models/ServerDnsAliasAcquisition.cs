// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A server dns alias acquisition request. </summary>
    public partial class ServerDnsAliasAcquisition
    {
        /// <summary> Initializes a new instance of ServerDnsAliasAcquisition. </summary>
        /// <param name="oldServerDnsAliasId"> The id of the server alias that will be acquired to point to this server instead. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="oldServerDnsAliasId"/> is null. </exception>
        public ServerDnsAliasAcquisition(ResourceIdentifier oldServerDnsAliasId)
        {
            Argument.AssertNotNull(oldServerDnsAliasId, nameof(oldServerDnsAliasId));

            OldServerDnsAliasId = oldServerDnsAliasId;
        }

        /// <summary> The id of the server alias that will be acquired to point to this server instead. </summary>
        public ResourceIdentifier OldServerDnsAliasId { get; }
    }
}
