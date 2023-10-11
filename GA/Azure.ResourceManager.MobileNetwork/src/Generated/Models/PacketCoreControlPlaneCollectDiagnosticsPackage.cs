// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Packet core control plane collect diagnostics package options. </summary>
    public partial class PacketCoreControlPlaneCollectDiagnosticsPackage
    {
        /// <summary> Initializes a new instance of PacketCoreControlPlaneCollectDiagnosticsPackage. </summary>
        /// <param name="storageAccountBlobUri"> The Storage Account Blob URL to upload the diagnostics package to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountBlobUri"/> is null. </exception>
        public PacketCoreControlPlaneCollectDiagnosticsPackage(Uri storageAccountBlobUri)
        {
            Argument.AssertNotNull(storageAccountBlobUri, nameof(storageAccountBlobUri));

            StorageAccountBlobUri = storageAccountBlobUri;
        }

        /// <summary> The Storage Account Blob URL to upload the diagnostics package to. </summary>
        public Uri StorageAccountBlobUri { get; }
    }
}