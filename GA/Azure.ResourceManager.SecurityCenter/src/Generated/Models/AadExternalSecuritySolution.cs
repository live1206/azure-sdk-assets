// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents an AAD identity protection solution which sends logs to an OMS workspace. </summary>
    public partial class AadExternalSecuritySolution : ExternalSecuritySolution
    {
        /// <summary> Initializes a new instance of AadExternalSecuritySolution. </summary>
        public AadExternalSecuritySolution()
        {
            Kind = ExternalSecuritySolutionKind.Aad;
        }

        /// <summary> Initializes a new instance of AadExternalSecuritySolution. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the external solution. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        /// <param name="properties"> The external security solution properties for AAD solutions. </param>
        internal AadExternalSecuritySolution(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExternalSecuritySolutionKind? kind, AzureLocation? location, AadSolutionProperties properties) : base(id, name, resourceType, systemData, kind, location)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> The external security solution properties for AAD solutions. </summary>
        public AadSolutionProperties Properties { get; set; }
    }
}