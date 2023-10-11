// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareCryptoKey
    {
        internal static FirmwareCryptoKey DeserializeFirmwareCryptoKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> firmwareCryptoKeyId = default;
            Optional<string> keyType = default;
            Optional<long?> keySize = default;
            Optional<string> keyAlgorithm = default;
            Optional<IReadOnlyList<string>> usage = default;
            Optional<IReadOnlyList<string>> filePaths = default;
            Optional<PairedKey> pairedKey = default;
            Optional<IsShortKeySize?> isShortKeySize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cryptoKeyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        firmwareCryptoKeyId = null;
                        continue;
                    }
                    firmwareCryptoKeyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyType = null;
                        continue;
                    }
                    keyType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keySize = null;
                        continue;
                    }
                    keySize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("keyAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyAlgorithm = null;
                        continue;
                    }
                    keyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    usage = array;
                    continue;
                }
                if (property.NameEquals("filePaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    filePaths = array;
                    continue;
                }
                if (property.NameEquals("pairedKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pairedKey = null;
                        continue;
                    }
                    pairedKey = PairedKey.DeserializePairedKey(property.Value);
                    continue;
                }
                if (property.NameEquals("isShortKeySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isShortKeySize = null;
                        continue;
                    }
                    isShortKeySize = new IsShortKeySize(property.Value.GetString());
                    continue;
                }
            }
            return new FirmwareCryptoKey(firmwareCryptoKeyId.Value, keyType.Value, Optional.ToNullable(keySize), keyAlgorithm.Value, Optional.ToList(usage), Optional.ToList(filePaths), pairedKey.Value, Optional.ToNullable(isShortKeySize));
        }
    }
}