// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The restrictions that will be placed on a field in the resource by policy. </summary>
    public partial class FieldRestrictions
    {
        /// <summary> Initializes a new instance of FieldRestrictions. </summary>
        internal FieldRestrictions()
        {
            Restrictions = new ChangeTrackingList<FieldRestriction>();
        }

        /// <summary> Initializes a new instance of FieldRestrictions. </summary>
        /// <param name="field"> The name of the field. This can be a top-level property like 'name' or 'type' or an Azure Policy field alias. </param>
        /// <param name="restrictions"> The restrictions placed on that field by policy. </param>
        internal FieldRestrictions(string field, IReadOnlyList<FieldRestriction> restrictions)
        {
            Field = field;
            Restrictions = restrictions;
        }

        /// <summary> The name of the field. This can be a top-level property like 'name' or 'type' or an Azure Policy field alias. </summary>
        public string Field { get; }
        /// <summary> The restrictions placed on that field by policy. </summary>
        public IReadOnlyList<FieldRestriction> Restrictions { get; }
    }
}