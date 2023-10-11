// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing the SphereDeployment data model.
    /// An deployment resource belonging to a device group resource.
    /// Serialized Name: Deployment
    /// </summary>
    public partial class SphereDeploymentData : ResourceData
    {
        /// <summary> Initializes a new instance of SphereDeploymentData. </summary>
        public SphereDeploymentData()
        {
            DeployedImages = new ChangeTrackingList<SphereImageData>();
        }

        /// <summary> Initializes a new instance of SphereDeploymentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deploymentId">
        /// Deployment ID
        /// Serialized Name: Deployment.properties.deploymentId
        /// </param>
        /// <param name="deployedImages">
        /// Images deployed
        /// Serialized Name: Deployment.properties.deployedImages
        /// </param>
        /// <param name="deploymentDateUtc">
        /// Deployment date UTC
        /// Serialized Name: Deployment.properties.deploymentDateUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Deployment.properties.provisioningState
        /// </param>
        internal SphereDeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deploymentId, IList<SphereImageData> deployedImages, DateTimeOffset? deploymentDateUtc, SphereProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            DeploymentId = deploymentId;
            DeployedImages = deployedImages;
            DeploymentDateUtc = deploymentDateUtc;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Deployment ID
        /// Serialized Name: Deployment.properties.deploymentId
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// Images deployed
        /// Serialized Name: Deployment.properties.deployedImages
        /// </summary>
        public IList<SphereImageData> DeployedImages { get; }
        /// <summary>
        /// Deployment date UTC
        /// Serialized Name: Deployment.properties.deploymentDateUtc
        /// </summary>
        public DateTimeOffset? DeploymentDateUtc { get; }
        /// <summary>
        /// The status of the last operation.
        /// Serialized Name: Deployment.properties.provisioningState
        /// </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}