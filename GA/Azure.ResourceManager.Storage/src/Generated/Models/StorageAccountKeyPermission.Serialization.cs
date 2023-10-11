// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class StorageAccountKeyPermissionExtensions
    {
        public static string ToSerialString(this StorageAccountKeyPermission value) => value switch
        {
            StorageAccountKeyPermission.Read => "Read",
            StorageAccountKeyPermission.Full => "Full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageAccountKeyPermission value.")
        };

        public static StorageAccountKeyPermission ToStorageAccountKeyPermission(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Read")) return StorageAccountKeyPermission.Read;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Full")) return StorageAccountKeyPermission.Full;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageAccountKeyPermission value.");
        }
    }
}