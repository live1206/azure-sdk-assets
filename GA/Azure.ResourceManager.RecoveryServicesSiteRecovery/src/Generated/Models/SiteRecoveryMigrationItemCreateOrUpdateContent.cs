// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Enable migration input. </summary>
    public partial class SiteRecoveryMigrationItemCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of SiteRecoveryMigrationItemCreateOrUpdateContent. </summary>
        /// <param name="properties"> Enable migration input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryMigrationItemCreateOrUpdateContent(EnableMigrationProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Enable migration input properties. </summary>
        public EnableMigrationProperties Properties { get; }
    }
}