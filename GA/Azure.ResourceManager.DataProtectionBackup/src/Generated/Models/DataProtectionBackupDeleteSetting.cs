// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Delete Option
    /// Please note <see cref="DataProtectionBackupDeleteSetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataProtectionBackupAbsoluteDeleteSetting"/>.
    /// </summary>
    public abstract partial class DataProtectionBackupDeleteSetting
    {
        /// <summary> Initializes a new instance of DataProtectionBackupDeleteSetting. </summary>
        /// <param name="duration"> Duration of deletion after given timespan. </param>
        protected DataProtectionBackupDeleteSetting(TimeSpan duration)
        {
            Duration = duration;
        }

        /// <summary> Initializes a new instance of DataProtectionBackupDeleteSetting. </summary>
        /// <param name="duration"> Duration of deletion after given timespan. </param>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal DataProtectionBackupDeleteSetting(TimeSpan duration, string objectType)
        {
            Duration = duration;
            ObjectType = objectType;
        }

        /// <summary> Duration of deletion after given timespan. </summary>
        public TimeSpan Duration { get; set; }
        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}