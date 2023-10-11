// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Identity attributes of a lab user. </summary>
    public partial class DevTestLabUserIdentity
    {
        /// <summary> Initializes a new instance of DevTestLabUserIdentity. </summary>
        public DevTestLabUserIdentity()
        {
        }

        /// <summary> Initializes a new instance of DevTestLabUserIdentity. </summary>
        /// <param name="principalName"> Set to the principal name / UPN of the client JWT making the request. </param>
        /// <param name="principalId"> Set to the principal Id of the client JWT making the request. Service principal will not have the principal Id. </param>
        /// <param name="tenantId"> Set to the tenant ID of the client JWT making the request. </param>
        /// <param name="objectId"> Set to the object Id of the client JWT making the request. Not all users have object Id. For CSP (reseller) scenarios for example, object Id is not available. </param>
        /// <param name="appId"> Set to the app Id of the client JWT making the request. </param>
        internal DevTestLabUserIdentity(string principalName, string principalId, Guid? tenantId, string objectId, string appId)
        {
            PrincipalName = principalName;
            PrincipalId = principalId;
            TenantId = tenantId;
            ObjectId = objectId;
            AppId = appId;
        }

        /// <summary> Set to the principal name / UPN of the client JWT making the request. </summary>
        public string PrincipalName { get; set; }
        /// <summary> Set to the principal Id of the client JWT making the request. Service principal will not have the principal Id. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Set to the tenant ID of the client JWT making the request. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Set to the object Id of the client JWT making the request. Not all users have object Id. For CSP (reseller) scenarios for example, object Id is not available. </summary>
        public string ObjectId { get; set; }
        /// <summary> Set to the app Id of the client JWT making the request. </summary>
        public string AppId { get; set; }
    }
}
