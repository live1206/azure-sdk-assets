// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The managed database's restore details unrestorable file properties. </summary>
    public partial class ManagedDatabaseRestoreDetailUnrestorableFileProperties
    {
        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailUnrestorableFileProperties. </summary>
        internal ManagedDatabaseRestoreDetailUnrestorableFileProperties()
        {
        }

        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailUnrestorableFileProperties. </summary>
        /// <param name="name"> File name. </param>
        internal ManagedDatabaseRestoreDetailUnrestorableFileProperties(string name)
        {
            Name = name;
        }

        /// <summary> File name. </summary>
        public string Name { get; }
    }
}