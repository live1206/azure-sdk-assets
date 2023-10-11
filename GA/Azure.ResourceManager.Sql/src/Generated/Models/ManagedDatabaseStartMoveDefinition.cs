// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the information necessary to start a managed database move. </summary>
    public partial class ManagedDatabaseStartMoveDefinition
    {
        /// <summary> Initializes a new instance of ManagedDatabaseStartMoveDefinition. </summary>
        /// <param name="destinationManagedDatabaseId"> The destination managed database ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="destinationManagedDatabaseId"/> is null. </exception>
        public ManagedDatabaseStartMoveDefinition(ResourceIdentifier destinationManagedDatabaseId)
        {
            Argument.AssertNotNull(destinationManagedDatabaseId, nameof(destinationManagedDatabaseId));

            DestinationManagedDatabaseId = destinationManagedDatabaseId;
        }

        /// <summary> The destination managed database ID. </summary>
        public ResourceIdentifier DestinationManagedDatabaseId { get; }
        /// <summary> The move operation mode. </summary>
        public ManagedDatabaseMoveOperationMode? OperationMode { get; set; }
    }
}