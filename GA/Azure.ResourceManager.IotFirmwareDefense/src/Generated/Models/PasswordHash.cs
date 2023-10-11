// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Password hash properties. </summary>
    public partial class PasswordHash
    {
        /// <summary> Initializes a new instance of PasswordHash. </summary>
        internal PasswordHash()
        {
        }

        /// <summary> Initializes a new instance of PasswordHash. </summary>
        /// <param name="passwordHashId"> ID for password hash. </param>
        /// <param name="filePath"> File path of the password hash. </param>
        /// <param name="salt"> Salt of the password hash. </param>
        /// <param name="hash"> Hash of the password. </param>
        /// <param name="context"> Context of password hash. </param>
        /// <param name="username"> User name of password hash. </param>
        /// <param name="algorithm"> Algorithm of the password hash. </param>
        internal PasswordHash(string passwordHashId, string filePath, string salt, string hash, string context, string username, string algorithm)
        {
            PasswordHashId = passwordHashId;
            FilePath = filePath;
            Salt = salt;
            Hash = hash;
            Context = context;
            Username = username;
            Algorithm = algorithm;
        }

        /// <summary> ID for password hash. </summary>
        public string PasswordHashId { get; }
        /// <summary> File path of the password hash. </summary>
        public string FilePath { get; }
        /// <summary> Salt of the password hash. </summary>
        public string Salt { get; }
        /// <summary> Hash of the password. </summary>
        public string Hash { get; }
        /// <summary> Context of password hash. </summary>
        public string Context { get; }
        /// <summary> User name of password hash. </summary>
        public string Username { get; }
        /// <summary> Algorithm of the password hash. </summary>
        public string Algorithm { get; }
    }
}