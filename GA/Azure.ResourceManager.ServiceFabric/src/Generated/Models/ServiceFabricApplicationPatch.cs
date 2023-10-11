// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The application resource for patch operations. </summary>
    public partial class ServiceFabricApplicationPatch : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServiceFabricApplicationPatch. </summary>
        /// <param name="location"> The location. </param>
        public ServiceFabricApplicationPatch(AzureLocation location) : base(location)
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
            Metrics = new ChangeTrackingList<ApplicationMetricDescription>();
            ManagedIdentities = new ChangeTrackingList<ApplicationUserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ServiceFabricApplicationPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="typeVersion"> The version of the application type as defined in the application manifest. </param>
        /// <param name="parameters"> List of application parameters with overridden values from their default values specified in the application manifest. </param>
        /// <param name="upgradePolicy"> Describes the policy for a monitored application upgrade. </param>
        /// <param name="minimumNodes"> The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. </param>
        /// <param name="maximumNodes"> The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. </param>
        /// <param name="removeApplicationCapacity"> Remove the current application capacity settings. </param>
        /// <param name="metrics"> List of application capacity metric description. </param>
        /// <param name="managedIdentities"> List of user assigned identities for the application, each mapped to a friendly name. </param>
        /// <param name="etag"> Azure resource etag. </param>
        internal ServiceFabricApplicationPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string typeVersion, IDictionary<string, string> parameters, ApplicationUpgradePolicy upgradePolicy, long? minimumNodes, long? maximumNodes, bool? removeApplicationCapacity, IList<ApplicationMetricDescription> metrics, IList<ApplicationUserAssignedIdentity> managedIdentities, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            TypeVersion = typeVersion;
            Parameters = parameters;
            UpgradePolicy = upgradePolicy;
            MinimumNodes = minimumNodes;
            MaximumNodes = maximumNodes;
            RemoveApplicationCapacity = removeApplicationCapacity;
            Metrics = metrics;
            ManagedIdentities = managedIdentities;
            ETag = etag;
        }

        /// <summary> The version of the application type as defined in the application manifest. </summary>
        public string TypeVersion { get; set; }
        /// <summary> List of application parameters with overridden values from their default values specified in the application manifest. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Describes the policy for a monitored application upgrade. </summary>
        public ApplicationUpgradePolicy UpgradePolicy { get; set; }
        /// <summary> The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. </summary>
        public long? MinimumNodes { get; set; }
        /// <summary> The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. </summary>
        public long? MaximumNodes { get; set; }
        /// <summary> Remove the current application capacity settings. </summary>
        public bool? RemoveApplicationCapacity { get; set; }
        /// <summary> List of application capacity metric description. </summary>
        public IList<ApplicationMetricDescription> Metrics { get; }
        /// <summary> List of user assigned identities for the application, each mapped to a friendly name. </summary>
        public IList<ApplicationUserAssignedIdentity> ManagedIdentities { get; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
