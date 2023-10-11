// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies a metric to load balance a service during runtime. </summary>
    public partial class ManagedServiceScalingPolicy
    {
        /// <summary> Initializes a new instance of ManagedServiceScalingPolicy. </summary>
        /// <param name="scalingMechanism">
        /// Specifies the mechanism associated with this scaling policy
        /// Please note <see cref="ManagedServiceScalingMechanism"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionAddOrRemoveScalingMechanism"/> and <see cref="PartitionInstanceCountScalingMechanism"/>.
        /// </param>
        /// <param name="scalingTrigger">
        /// Specifies the trigger associated with this scaling policy.
        /// Please note <see cref="ManagedServiceScalingTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AveragePartitionLoadScalingTrigger"/> and <see cref="AverageServiceLoadScalingTrigger"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingMechanism"/> or <paramref name="scalingTrigger"/> is null. </exception>
        public ManagedServiceScalingPolicy(ManagedServiceScalingMechanism scalingMechanism, ManagedServiceScalingTrigger scalingTrigger)
        {
            Argument.AssertNotNull(scalingMechanism, nameof(scalingMechanism));
            Argument.AssertNotNull(scalingTrigger, nameof(scalingTrigger));

            ScalingMechanism = scalingMechanism;
            ScalingTrigger = scalingTrigger;
        }

        /// <summary>
        /// Specifies the mechanism associated with this scaling policy
        /// Please note <see cref="ManagedServiceScalingMechanism"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionAddOrRemoveScalingMechanism"/> and <see cref="PartitionInstanceCountScalingMechanism"/>.
        /// </summary>
        public ManagedServiceScalingMechanism ScalingMechanism { get; set; }
        /// <summary>
        /// Specifies the trigger associated with this scaling policy.
        /// Please note <see cref="ManagedServiceScalingTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AveragePartitionLoadScalingTrigger"/> and <see cref="AverageServiceLoadScalingTrigger"/>.
        /// </summary>
        public ManagedServiceScalingTrigger ScalingTrigger { get; set; }
    }
}
