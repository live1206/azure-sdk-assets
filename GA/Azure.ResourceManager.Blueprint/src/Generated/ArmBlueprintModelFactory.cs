// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Blueprint;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmBlueprintModelFactory
    {
        /// <summary> Initializes a new instance of BlueprintData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="status"> Status of the blueprint. This field is readonly. </param>
        /// <param name="targetScope"> The scope where this blueprint definition can be assigned. </param>
        /// <param name="parameters"> Parameters required by this blueprint definition. </param>
        /// <param name="resourceGroups"> Resource group placeholders defined by this blueprint definition. </param>
        /// <param name="versions"> Published versions of this blueprint definition. </param>
        /// <param name="layout"> Layout view of the blueprint definition for UI reference. </param>
        /// <returns> A new <see cref="Blueprint.BlueprintData"/> instance for mocking. </returns>
        public static BlueprintData BlueprintData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, BlueprintStatus status = null, BlueprintTargetScope? targetScope = null, IDictionary<string, ParameterDefinition> parameters = null, IDictionary<string, ResourceGroupDefinition> resourceGroups = null, BinaryData versions = null, BinaryData layout = null)
        {
            parameters ??= new Dictionary<string, ParameterDefinition>();
            resourceGroups ??= new Dictionary<string, ResourceGroupDefinition>();

            return new BlueprintData(id, name, resourceType, systemData, displayName, description, status, targetScope, parameters, resourceGroups, versions, layout);
        }

        /// <summary> Initializes a new instance of BlueprintStatus. </summary>
        /// <param name="timeCreated"> Creation time of this blueprint definition. </param>
        /// <param name="lastModified"> Last modified time of this blueprint definition. </param>
        /// <returns> A new <see cref="Models.BlueprintStatus"/> instance for mocking. </returns>
        public static BlueprintStatus BlueprintStatus(DateTimeOffset? timeCreated = null, DateTimeOffset? lastModified = null)
        {
            return new BlueprintStatus(timeCreated, lastModified);
        }

        /// <summary> Initializes a new instance of BlueprintResourceStatusBase. </summary>
        /// <param name="timeCreated"> Creation time of this blueprint definition. </param>
        /// <param name="lastModified"> Last modified time of this blueprint definition. </param>
        /// <returns> A new <see cref="Models.BlueprintResourceStatusBase"/> instance for mocking. </returns>
        public static BlueprintResourceStatusBase BlueprintResourceStatusBase(DateTimeOffset? timeCreated = null, DateTimeOffset? lastModified = null)
        {
            return new BlueprintResourceStatusBase(timeCreated, lastModified);
        }

        /// <summary> Initializes a new instance of ArtifactData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of blueprint artifact. </param>
        /// <returns> A new <see cref="Blueprint.ArtifactData"/> instance for mocking. </returns>
        public static ArtifactData ArtifactData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string kind = "Unknown")
        {
            return new ArtifactData(id, name, resourceType, systemData, kind);
        }

        /// <summary> Initializes a new instance of PublishedBlueprintData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="status"> Status of the blueprint. This field is readonly. </param>
        /// <param name="targetScope"> The scope where this blueprint definition can be assigned. </param>
        /// <param name="parameters"> Parameters required by this blueprint definition. </param>
        /// <param name="resourceGroups"> Resource group placeholders defined by this blueprint definition. </param>
        /// <param name="blueprintName"> Name of the published blueprint definition. </param>
        /// <param name="changeNotes"> Version-specific change notes. </param>
        /// <returns> A new <see cref="Blueprint.PublishedBlueprintData"/> instance for mocking. </returns>
        public static PublishedBlueprintData PublishedBlueprintData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, BlueprintStatus status = null, BlueprintTargetScope? targetScope = null, IDictionary<string, ParameterDefinition> parameters = null, IDictionary<string, ResourceGroupDefinition> resourceGroups = null, string blueprintName = null, string changeNotes = null)
        {
            parameters ??= new Dictionary<string, ParameterDefinition>();
            resourceGroups ??= new Dictionary<string, ResourceGroupDefinition>();

            return new PublishedBlueprintData(id, name, resourceType, systemData, displayName, description, status, targetScope, parameters, resourceGroups, blueprintName, changeNotes);
        }

        /// <summary> Initializes a new instance of AssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Managed identity for this blueprint assignment. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="blueprintId"> ID of the published version of a blueprint definition. </param>
        /// <param name="scope"> The target subscription scope of the blueprint assignment (format: '/subscriptions/{subscriptionId}'). For management group level assignments, the property is required. </param>
        /// <param name="parameters"> Blueprint assignment parameter values. </param>
        /// <param name="resourceGroups"> Names and locations of resource group placeholders. </param>
        /// <param name="status"> Status of blueprint assignment. This field is readonly. </param>
        /// <param name="locks"> Defines how resources deployed by a blueprint assignment are locked. </param>
        /// <param name="provisioningState"> State of the blueprint assignment. </param>
        /// <param name="location"> The location of this blueprint assignment. </param>
        /// <returns> A new <see cref="Blueprint.AssignmentData"/> instance for mocking. </returns>
        public static AssignmentData AssignmentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServiceIdentity identity = null, string displayName = null, string description = null, string blueprintId = null, string scope = null, IDictionary<string, ParameterValue> parameters = null, IDictionary<string, ResourceGroupValue> resourceGroups = null, AssignmentStatus status = null, AssignmentLockSettings locks = null, AssignmentProvisioningState? provisioningState = null, AzureLocation location = default)
        {
            parameters ??= new Dictionary<string, ParameterValue>();
            resourceGroups ??= new Dictionary<string, ResourceGroupValue>();

            return new AssignmentData(id, name, resourceType, systemData, identity, displayName, description, blueprintId, scope, parameters, resourceGroups, status, locks, provisioningState, location);
        }

        /// <summary> Initializes a new instance of AssignmentStatus. </summary>
        /// <param name="timeCreated"> Creation time of this blueprint definition. </param>
        /// <param name="lastModified"> Last modified time of this blueprint definition. </param>
        /// <param name="managedResources"> List of resources that were created by the blueprint assignment. </param>
        /// <returns> A new <see cref="Models.AssignmentStatus"/> instance for mocking. </returns>
        public static AssignmentStatus AssignmentStatus(DateTimeOffset? timeCreated = null, DateTimeOffset? lastModified = null, IEnumerable<string> managedResources = null)
        {
            managedResources ??= new List<string>();

            return new AssignmentStatus(timeCreated, lastModified, managedResources?.ToList());
        }

        /// <summary> Initializes a new instance of WhoIsBlueprintContract. </summary>
        /// <param name="objectId"> AAD object Id of the Azure Blueprints service principal in the tenant. </param>
        /// <returns> A new <see cref="Models.WhoIsBlueprintContract"/> instance for mocking. </returns>
        public static WhoIsBlueprintContract WhoIsBlueprintContract(string objectId = null)
        {
            return new WhoIsBlueprintContract(objectId);
        }

        /// <summary> Initializes a new instance of AssignmentOperationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="blueprintVersion"> The published version of the blueprint definition used for the blueprint assignment operation. </param>
        /// <param name="assignmentState"> State of this blueprint assignment operation. </param>
        /// <param name="timeCreated"> Create time of this blueprint assignment operation. </param>
        /// <param name="timeStarted"> Start time of the underlying deployment. </param>
        /// <param name="timeFinished"> Finish time of the overall underlying deployments. </param>
        /// <param name="deployments"> List of jobs in this blueprint assignment operation. </param>
        /// <returns> A new <see cref="Blueprint.AssignmentOperationData"/> instance for mocking. </returns>
        public static AssignmentOperationData AssignmentOperationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string blueprintVersion = null, string assignmentState = null, string timeCreated = null, string timeStarted = null, string timeFinished = null, IEnumerable<AssignmentDeploymentJob> deployments = null)
        {
            deployments ??= new List<AssignmentDeploymentJob>();

            return new AssignmentOperationData(id, name, resourceType, systemData, blueprintVersion, assignmentState, timeCreated, timeStarted, timeFinished, deployments?.ToList());
        }

        /// <summary> Initializes a new instance of AssignmentJobCreatedResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Additional properties in a dictionary. </param>
        /// <returns> A new <see cref="Models.AssignmentJobCreatedResult"/> instance for mocking. </returns>
        public static AssignmentJobCreatedResult AssignmentJobCreatedResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> properties = null)
        {
            properties ??= new Dictionary<string, string>();

            return new AssignmentJobCreatedResult(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of TemplateArtifact. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="dependsOn"> Artifacts which need to be deployed before the specified artifact. </param>
        /// <param name="template"> The Resource Manager template blueprint artifact body. </param>
        /// <param name="resourceGroup"> If applicable, the name of the resource group placeholder to which the Resource Manager template blueprint artifact will be deployed. </param>
        /// <param name="parameters"> Resource Manager template blueprint artifact parameter values. </param>
        /// <returns> A new <see cref="Models.TemplateArtifact"/> instance for mocking. </returns>
        public static TemplateArtifact TemplateArtifact(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, IEnumerable<string> dependsOn = null, BinaryData template = null, string resourceGroup = null, IDictionary<string, ParameterValue> parameters = null)
        {
            dependsOn ??= new List<string>();
            parameters ??= new Dictionary<string, ParameterValue>();

            return new TemplateArtifact(id, name, resourceType, systemData, ArtifactKind.Template, displayName, description, dependsOn?.ToList(), template, resourceGroup, parameters);
        }

        /// <summary> Initializes a new instance of RoleAssignmentArtifact. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="dependsOn"> Artifacts which need to be deployed before the specified artifact. </param>
        /// <param name="roleDefinitionId"> Azure resource ID of the RoleDefinition. </param>
        /// <param name="principalIds"> Array of user or group identities in Azure Active Directory. The roleDefinition will apply to each identity. </param>
        /// <param name="resourceGroup"> RoleAssignment will be scope to this resourceGroup. If empty, it scopes to the subscription. </param>
        /// <returns> A new <see cref="Models.RoleAssignmentArtifact"/> instance for mocking. </returns>
        public static RoleAssignmentArtifact RoleAssignmentArtifact(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, IEnumerable<string> dependsOn = null, string roleDefinitionId = null, BinaryData principalIds = null, string resourceGroup = null)
        {
            dependsOn ??= new List<string>();

            return new RoleAssignmentArtifact(id, name, resourceType, systemData, ArtifactKind.RoleAssignment, displayName, description, dependsOn?.ToList(), roleDefinitionId, principalIds, resourceGroup);
        }

        /// <summary> Initializes a new instance of PolicyAssignmentArtifact. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="dependsOn"> Artifacts which need to be deployed before the specified artifact. </param>
        /// <param name="policyDefinitionId"> Azure resource ID of the policy definition. </param>
        /// <param name="parameters"> Parameter values for the policy definition. </param>
        /// <param name="resourceGroup"> Name of the resource group placeholder to which the policy will be assigned. </param>
        /// <returns> A new <see cref="Models.PolicyAssignmentArtifact"/> instance for mocking. </returns>
        public static PolicyAssignmentArtifact PolicyAssignmentArtifact(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, IEnumerable<string> dependsOn = null, string policyDefinitionId = null, IDictionary<string, ParameterValue> parameters = null, string resourceGroup = null)
        {
            dependsOn ??= new List<string>();
            parameters ??= new Dictionary<string, ParameterValue>();

            return new PolicyAssignmentArtifact(id, name, resourceType, systemData, ArtifactKind.PolicyAssignment, displayName, description, dependsOn?.ToList(), policyDefinitionId, parameters, resourceGroup);
        }
    }
}