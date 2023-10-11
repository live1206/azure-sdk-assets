// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownConnectionInfo. </summary>
    internal partial class UnknownConnectionInfo : ConnectionInfo
    {
        /// <summary> Initializes a new instance of UnknownConnectionInfo. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        internal UnknownConnectionInfo(string connectionInfoType, string userName, string password) : base(connectionInfoType, userName, password)
        {
            ConnectionInfoType = connectionInfoType ?? "Unknown";
        }
    }
}
