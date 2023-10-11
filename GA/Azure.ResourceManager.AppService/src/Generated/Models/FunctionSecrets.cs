// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Function secrets. </summary>
    public partial class FunctionSecrets
    {
        /// <summary> Initializes a new instance of FunctionSecrets. </summary>
        internal FunctionSecrets()
        {
        }

        /// <summary> Initializes a new instance of FunctionSecrets. </summary>
        /// <param name="key"> Secret key. </param>
        /// <param name="triggerUri"> Trigger URL. </param>
        internal FunctionSecrets(string key, Uri triggerUri)
        {
            Key = key;
            TriggerUri = triggerUri;
        }

        /// <summary> Secret key. </summary>
        public string Key { get; }
        /// <summary> Trigger URL. </summary>
        public Uri TriggerUri { get; }
    }
}