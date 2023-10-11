// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Azure retention rule. </summary>
    public partial class DataProtectionRetentionRule : DataProtectionBasePolicyRule
    {
        /// <summary> Initializes a new instance of DataProtectionRetentionRule. </summary>
        /// <param name="name"></param>
        /// <param name="lifecycles"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="lifecycles"/> is null. </exception>
        public DataProtectionRetentionRule(string name, IEnumerable<SourceLifeCycle> lifecycles) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(lifecycles, nameof(lifecycles));

            Lifecycles = lifecycles.ToList();
            ObjectType = "AzureRetentionRule";
        }

        /// <summary> Initializes a new instance of DataProtectionRetentionRule. </summary>
        /// <param name="name"></param>
        /// <param name="objectType"></param>
        /// <param name="isDefault"></param>
        /// <param name="lifecycles"></param>
        internal DataProtectionRetentionRule(string name, string objectType, bool? isDefault, IList<SourceLifeCycle> lifecycles) : base(name, objectType)
        {
            IsDefault = isDefault;
            Lifecycles = lifecycles;
            ObjectType = objectType ?? "AzureRetentionRule";
        }

        /// <summary> Gets or sets the is default. </summary>
        public bool? IsDefault { get; set; }
        /// <summary> Gets the lifecycles. </summary>
        public IList<SourceLifeCycle> Lifecycles { get; }
    }
}
