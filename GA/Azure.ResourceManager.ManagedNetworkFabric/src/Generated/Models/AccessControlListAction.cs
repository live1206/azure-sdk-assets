// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Action that need to performed. </summary>
    public partial class AccessControlListAction
    {
        /// <summary> Initializes a new instance of AccessControlListAction. </summary>
        public AccessControlListAction()
        {
        }

        /// <summary> Initializes a new instance of AccessControlListAction. </summary>
        /// <param name="aclActionType"> Type of actions that can be performed. </param>
        /// <param name="counterName"> Name of the counter block to get match count information. </param>
        internal AccessControlListAction(AclActionType? aclActionType, string counterName)
        {
            AclActionType = aclActionType;
            CounterName = counterName;
        }

        /// <summary> Type of actions that can be performed. </summary>
        public AclActionType? AclActionType { get; set; }
        /// <summary> Name of the counter block to get match count information. </summary>
        public string CounterName { get; set; }
    }
}