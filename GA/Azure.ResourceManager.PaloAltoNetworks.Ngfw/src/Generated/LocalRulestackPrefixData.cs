// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing the LocalRulestackPrefix data model.
    /// LocalRulestack prefixList
    /// </summary>
    public partial class LocalRulestackPrefixData : ResourceData
    {
        /// <summary> Initializes a new instance of LocalRulestackPrefixData. </summary>
        /// <param name="prefixList"> prefix list. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixList"/> is null. </exception>
        public LocalRulestackPrefixData(IEnumerable<string> prefixList)
        {
            Argument.AssertNotNull(prefixList, nameof(prefixList));

            PrefixList = prefixList.ToList();
        }

        /// <summary> Initializes a new instance of LocalRulestackPrefixData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> prefix description. </param>
        /// <param name="prefixList"> prefix list. </param>
        /// <param name="etag"> etag info. </param>
        /// <param name="auditComment"> comment for this object. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        internal LocalRulestackPrefixData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, IList<string> prefixList, ETag? etag, string auditComment, FirewallProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Description = description;
            PrefixList = prefixList;
            ETag = etag;
            AuditComment = auditComment;
            ProvisioningState = provisioningState;
        }

        /// <summary> prefix description. </summary>
        public string Description { get; set; }
        /// <summary> prefix list. </summary>
        public IList<string> PrefixList { get; }
        /// <summary> etag info. </summary>
        public ETag? ETag { get; set; }
        /// <summary> comment for this object. </summary>
        public string AuditComment { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public FirewallProvisioningState? ProvisioningState { get; }
    }
}