// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the checks that should be made while validating the JWT Claims. </summary>
    public partial class JwtClaimChecks
    {
        /// <summary> Initializes a new instance of JwtClaimChecks. </summary>
        public JwtClaimChecks()
        {
            AllowedGroups = new ChangeTrackingList<string>();
            AllowedClientApplications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of JwtClaimChecks. </summary>
        /// <param name="allowedGroups"> The list of the allowed groups. </param>
        /// <param name="allowedClientApplications"> The list of the allowed client applications. </param>
        internal JwtClaimChecks(IList<string> allowedGroups, IList<string> allowedClientApplications)
        {
            AllowedGroups = allowedGroups;
            AllowedClientApplications = allowedClientApplications;
        }

        /// <summary> The list of the allowed groups. </summary>
        public IList<string> AllowedGroups { get; }
        /// <summary> The list of the allowed client applications. </summary>
        public IList<string> AllowedClientApplications { get; }
    }
}