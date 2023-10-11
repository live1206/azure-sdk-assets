// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxAccountCredentialDetails
    {
        internal static DataBoxAccountCredentialDetails DeserializeDataBoxAccountCredentialDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountName = default;
            Optional<DataAccountType> dataAccountType = default;
            Optional<string> accountConnectionString = default;
            Optional<IReadOnlyList<ShareCredentialDetails>> shareCredentialDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("accountConnectionString"u8))
                {
                    accountConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareCredentialDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShareCredentialDetails> array = new List<ShareCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ShareCredentialDetails.DeserializeShareCredentialDetails(item));
                    }
                    shareCredentialDetails = array;
                    continue;
                }
            }
            return new DataBoxAccountCredentialDetails(accountName.Value, Optional.ToNullable(dataAccountType), accountConnectionString.Value, Optional.ToList(shareCredentialDetails));
        }
    }
}