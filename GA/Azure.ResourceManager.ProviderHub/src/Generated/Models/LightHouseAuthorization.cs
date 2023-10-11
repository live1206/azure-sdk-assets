// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LightHouseAuthorization. </summary>
    public partial class LightHouseAuthorization
    {
        /// <summary> Initializes a new instance of LightHouseAuthorization. </summary>
        /// <param name="principalId"></param>
        /// <param name="roleDefinitionId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="principalId"/> or <paramref name="roleDefinitionId"/> is null. </exception>
        public LightHouseAuthorization(string principalId, string roleDefinitionId)
        {
            Argument.AssertNotNull(principalId, nameof(principalId));
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> Gets or sets the principal id. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Gets or sets the role definition id. </summary>
        public string RoleDefinitionId { get; set; }
    }
}
