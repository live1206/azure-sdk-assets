// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for retention policy.
    /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
    /// </summary>
    public abstract partial class BackupRetentionPolicy
    {
        /// <summary> Initializes a new instance of BackupRetentionPolicy. </summary>
        protected BackupRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of BackupRetentionPolicy. </summary>
        /// <param name="retentionPolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal BackupRetentionPolicy(string retentionPolicyType)
        {
            RetentionPolicyType = retentionPolicyType;
        }

        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string RetentionPolicyType { get; set; }
    }
}
