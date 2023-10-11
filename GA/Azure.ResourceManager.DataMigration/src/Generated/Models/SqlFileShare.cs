// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> File share. </summary>
    public partial class SqlFileShare
    {
        /// <summary> Initializes a new instance of SqlFileShare. </summary>
        public SqlFileShare()
        {
        }

        /// <summary> Initializes a new instance of SqlFileShare. </summary>
        /// <param name="path"> Location as SMB share or local drive where backups are placed. </param>
        /// <param name="username"> Username to access the file share location for backups. </param>
        /// <param name="password"> Password for username to access file share location. </param>
        internal SqlFileShare(string path, string username, string password)
        {
            Path = path;
            Username = username;
            Password = password;
        }

        /// <summary> Location as SMB share or local drive where backups are placed. </summary>
        public string Path { get; set; }
        /// <summary> Username to access the file share location for backups. </summary>
        public string Username { get; set; }
        /// <summary> Password for username to access file share location. </summary>
        public string Password { get; set; }
    }
}