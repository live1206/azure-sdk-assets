// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the resource to query the troubleshooting result. </summary>
    public partial class QueryTroubleshootingContent
    {
        /// <summary> Initializes a new instance of QueryTroubleshootingContent. </summary>
        /// <param name="targetResourceId"> The target resource ID to query the troubleshooting result. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> is null. </exception>
        public QueryTroubleshootingContent(ResourceIdentifier targetResourceId)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));

            TargetResourceId = targetResourceId;
        }

        /// <summary> The target resource ID to query the troubleshooting result. </summary>
        public ResourceIdentifier TargetResourceId { get; }
    }
}