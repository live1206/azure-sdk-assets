// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing the RoleAssignment data model.
    /// Role Assignments
    /// </summary>
    public partial class RoleAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of RoleAssignmentData. </summary>
        internal RoleAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role assignment scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="description"> Description of role assignment. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently the only accepted value is '2.0'. </param>
        /// <param name="createdOn"> Time it was created. </param>
        /// <param name="updatedOn"> Time it was updated. </param>
        /// <param name="createdBy"> Id of the user who created the assignment. </param>
        /// <param name="updatedBy"> Id of the user who updated the assignment. </param>
        /// <param name="delegatedManagedIdentityResourceId"> Id of the delegated managed identity resource. </param>
        internal RoleAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, Guid? principalId, RoleManagementPrincipalType? principalType, string description, string condition, string conditionVersion, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string createdBy, string updatedBy, ResourceIdentifier delegatedManagedIdentityResourceId) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            Description = description;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            DelegatedManagedIdentityResourceId = delegatedManagedIdentityResourceId;
        }

        /// <summary> The role assignment scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public RoleManagementPrincipalType? PrincipalType { get; }
        /// <summary> Description of role assignment. </summary>
        public string Description { get; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </summary>
        public string Condition { get; }
        /// <summary> Version of the condition. Currently the only accepted value is '2.0'. </summary>
        public string ConditionVersion { get; }
        /// <summary> Time it was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time it was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Id of the user who created the assignment. </summary>
        public string CreatedBy { get; }
        /// <summary> Id of the user who updated the assignment. </summary>
        public string UpdatedBy { get; }
        /// <summary> Id of the delegated managed identity resource. </summary>
        public ResourceIdentifier DelegatedManagedIdentityResourceId { get; }
    }
}